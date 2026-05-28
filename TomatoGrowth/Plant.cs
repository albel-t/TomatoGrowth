using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TomatoGrowth
{
    public class Plant
    {
        public static double MaxLen;
        public static double Bushiness;
        public static double DyingOff;
        public static double Youth;
        public static double Vegetation;
        public static double Curly;

        public static Random rand;

        public static int tick;

        public Plant()
        { }
        public Plant(
            double MaxLen,
            double Bushiness,
            double DyingOff,
            double Youth,
            double Vegetation)
        {
            Plant.MaxLen = MaxLen;
            Plant.Bushiness = Bushiness;
            Plant.DyingOff = DyingOff;
            Plant.Youth = Youth;
            Plant.Vegetation = Vegetation;
            
            rand = new Random();
        }
        public static bool RandomChance(double percent)
        {
            
            double randomValue = rand.NextDouble() * 100;

            return randomValue < percent;
        }

    }
    public class part_of_a_plant : Plant
    {
        part_of_a_plant mainKid;
        List<part_of_a_plant> kids;
        int old;
        public string status; // none active passive dead
        Vec2d end;
        public part_of_a_plant(Vec2d parent_end) : base()
        {
            old = 0;

            status = "none";
            end = parent_end;
            end.RotateVector(rand.NextDouble() * Curly * 140);
        }
        public void born()
        {
            kids = new List<part_of_a_plant>();
            mainKid = new part_of_a_plant(end);
        }
        void drow(Vec2d parentDot)
        {

        }
        void oneTick(int len)
        {
            old++;
            if (old == Youth)
                status = "active";
            if (old == DyingOff)
                status = "passive";

            if ((len == MaxLen) || (status == "none"))
                return;
            else
            {
                if(status == "active")
                {
                    if(RandomChance(Vegetation) && (mainKid.status == "none"))
                    {
                        mainKid.status = "active";
                        mainKid.born();
                    }
                    if (RandomChance(Vegetation * Bushiness))
                    {
                        part_of_a_plant newKid = new part_of_a_plant(end);
                        newKid.status = "active";
                        kids.Add(newKid);
                    }
                }

            }
        }

    }

    public class Vec2d
    {
        double x, y;
        public Vec2d(double x, double y)
        {
            this.x = x;
            this.y = y;
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
    }


}