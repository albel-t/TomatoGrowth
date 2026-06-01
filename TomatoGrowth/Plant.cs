using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace TomatoGrowth
{
    public class Plant
    {
        public static InputOutputStream stream;
        public part_of_a_plant root;
        public static double MaxLen;            //максимальное количество ступеней
        public static double Bushiness;         //желание отпускать боковые ветки
        public static double DyingOff;          //старение
        public static double Youth;             //молодость
        public static double Vegetation;        //желание рости

        public static double Curly;             //кривость новых веток
        public static double Slimness;          //желание расти к свету
        public static double Fade;              //желание умереть
        public static double Branches;          //количество веток из 1 почки

        public static Random rand;

        public static int tick;
        public static Vec2d sun;
        public static Bitmap bmp;
        public static System.Windows.Forms.PictureBox thisPictureBox;
        public static Pen pen;
        public Plant()
        { }
        public Plant(
            System.Windows.Forms.PictureBox thisPictureBox, 
            double MaxLen,
            double Bushiness,
            double DyingOff,
            double Youth,
            double Vegetation,
            double Curly,
            double Slimness,
            double Fade,
            double Branches)
        {
            Plant.MaxLen = MaxLen;
            Plant.Bushiness = Bushiness;
            Plant.DyingOff = DyingOff;
            Plant.Youth = Youth;
            Plant.Vegetation = Vegetation;
            Plant.Curly = Curly;
            Plant.Slimness = Slimness;
            Plant.Fade = Fade;
            Plant.Branches = Branches;

            Plant.thisPictureBox = thisPictureBox;

            sun = new Vec2d(200, -5000);
            rand = new Random();            
            
            bmp = new Bitmap(thisPictureBox.Width, thisPictureBox.Height);

            root = new part_of_a_plant(new Vec2d(0, -30));

        }
        public static void connect(InputOutputStream stream)
        {
            Plant.stream = stream;
            stream.WriteLine("{Plant} - connected to stream");
        }
        public static bool RandomChance(double percent)
        {

            double randomValue = rand.NextDouble();// * 100;

            return randomValue < percent;
        }
        public void tickPlant()
        {
            root.oneTick(1);
        }
        public void firatTickPlant()
        {
            root.born("A");
            stream.WriteLine("root   was born");

        }
        public void drowPlant()
        {
            stream.WriteLine($"tick {root.old}");
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
            }
            root.drow(new Vec2d(200, 500));

            thisPictureBox.Image = bmp;
        }
        public static void DrawLine(Vec2d start, Vec2d stop, int color, double width = 0)
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                switch(color)
                {
                    case 0:
                        pen = new Pen(Color.LightGreen, (float)(3 + width));
                        break;
                    case 1:
                        pen = new Pen(Color.Green, (float)(3 + width));
                        break;

                    case 2:
                        pen = new Pen(Color.Brown, (float)(3 + width));
                        break;

                }
                g.DrawLine(pen, (float)start.x, (float)start.y, (float)stop.x, (float)stop.y);

            }
        }
    }
    public class part_of_a_plant : Plant
    {

        part_of_a_plant mainKid;
        List<part_of_a_plant> kids;
        public int old;
        public string status;   // none active passive dead
        public string ID;       // 0-9 - main, a-z - slave
        public Vec2d end;
        public part_of_a_plant(Vec2d parent_end) : base()
        {
            old = 0;

            status = "none";
            end = new Vec2d(parent_end);
            end.RotateVector(rand.NextDouble() * Curly * 140 * (RandomChance(Slimness) ? end.GetSide(sun) : -end.GetSide(sun)));
        }
        public void born(string ID)
        {
            this.ID = ID;
            kids = new List<part_of_a_plant>();
            mainKid = new part_of_a_plant(new Vec2d(end));
            status = "active";

        }
        public void die()
        {
            if (this.status == "none")
            {
                //stream.WriteLine($"status none");
                return;
            }
            //stream.WriteLine($"status die");

            mainKid.die();
                foreach (var kid in kids)
                    kid.die();
                status = "dead";
            if (status == "dead")
            {
                stream.WriteLine($"branch {ID} is dead");
            }

        }
        public void drow(Vec2d parentDot)
        {
            //DrawLine(new Vec2d(0, 0), new Vec2d(200, 200), 0);
            Vec2d myDot = parentDot + (end + Math.Pow(old, 0.75));
            //stream.WriteLine($"parentDot {parentDot} myDot {myDot}");

            if (status != "none")
            {
                DrawLine(parentDot, myDot, (status == "active") ? 0 : ((status == "passive") ? 1 : 2), Math.Sqrt(old) );

                mainKid.drow(myDot);
                foreach (var kid in kids)
                    kid.drow(myDot);
            }
        }
        public void oneTick(int len)
        {

            if ((len == MaxLen) || (status == "none") || (status == "dead"))
                return;
            len++;
            old++;
            if (old == Youth)
                status = "active";
            if (old == DyingOff)
                status = "passive";

            if (len == MaxLen)
            {
                stream.WriteLine($"branch {ID} is finished");
            }

            else
            {
                if(status == "active")
                {                
                    mainKid.oneTick(len);
                    foreach (var kid in kids)
                        kid.oneTick(len);
                    //stream.WriteLine($"try Vegetation {Vegetation}, mainKid.status == {mainKid.status}");

                    if (RandomChance(Vegetation) && (mainKid.status == "none"))
                    {
                        //mainKid.status = "active";
                        mainKid.born(ID + "A");
                    }
                    if (RandomChance(Bushiness) && (kids.Count() <= Branches))
                    {
                        part_of_a_plant newKid = new part_of_a_plant(end);
                        newKid.status = "active";
                        newKid.born(ID + (ID[ID.Length - 1] + 1));
                        kids.Add(newKid);
                    }
                }
                if (status == "passive")
                {
                    mainKid.oneTick(len);
                    foreach (var kid in kids)
                        kid.oneTick(len);

                    foreach (var kid in kids)
                        if (RandomChance(Fade))
                            kid.die();
                }


            }
        }


    }

    public class Vec2d
    {
        public double x, y;
        public Vec2d(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Vec2d(Vec2d other)
        {
            this.x = other.x;
            this.y = other.y;
        }
        public override string ToString()
        {
            return $"({x}, {y})";
        }
        public double Length()
        {
            return Math.Sqrt(x * x + y * y);
        }

        // Метод для нормализации вектора
        public Vec2d Normalize()
        {
            double len = Length();
            if (len == 0) return new Vec2d(0, 0);
            return new Vec2d(x / len, y / len);
        }
        public void Vec2dPlant(double angle, double len)
        {
            double angleRadians = angle * Math.PI / 180.0;
            x = Math.Sin(angleRadians) * len;
            y = -Math.Cos(angleRadians) * len;

        }
        public void RotateVector(double angle)
        {
            double length = Math.Sqrt(x * x + y * y);
            double currentAngleRad = Math.Atan2(x, -y);
            double newAngleRad = currentAngleRad + (angle * Math.PI / 180.0);

            x = Math.Sin(newAngleRad) * length;
            y = -Math.Cos(newAngleRad) * length;
        }
        public int GetSide(Vec2d p2)
        {
            double cross = x * p2.y - y * p2.x;

            if (cross < 0)
                return -1; 
            else
                return 1; 
        }

        public static Vec2d operator +(Vec2d a, Vec2d b)
        {
            return new Vec2d(a.x + b.x, a.y + b.y);
        }

        public static Vec2d operator -(Vec2d a, Vec2d b)
        {
            return new Vec2d(a.x - b.x, a.y - b.y);
        }

        public static Vec2d operator *(Vec2d v, double scalar)
        {
            return new Vec2d(v.x * scalar, v.y * scalar);
        }

        public static Vec2d operator *(double scalar, Vec2d v)
        {
            return new Vec2d(v.x * scalar, v.y * scalar);
        }

        public static Vec2d operator /(Vec2d v, double scalar)
        {
            return new Vec2d(v.x / scalar, v.y / scalar);
        }
        public static Vec2d operator +(Vec2d v, double scalar)
        {
            if (v == null) return null;

            double len = v.Length();
            if (len == 0) return new Vec2d(0, 0);

            // Сохраняем направление, увеличиваем длину
            double newLen = len + scalar;
            double scale = newLen / len;

            return new Vec2d(v.x * scale, v.y * scale);
        }

        // Оператор: число + вектор (симметричная операция)
        public static Vec2d operator +(double scalar, Vec2d v)
        {
            return v + scalar;
        }
    }


}