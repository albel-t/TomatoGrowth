using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace TomatoGrowth
{
    public partial class Form1 : Form
    {
        InputOutputStream STREAM;
        Plant currentPlant;
        public Form1()
        {
            InitializeComponent();

            STREAM = new InputOutputTextbox();
            ((InputOutputTextbox)STREAM).Connect(richTextBoxLogs);
        }
        private void buttonTick_Click(object sender, EventArgs e)
        {
            currentPlant.tickPlant();
            currentPlant.drowPlant();
        }
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                PlantParams p = new PlantParams
                {
                    visual = new PP_visual
                    {
                        TickPerClick = GetFromTextBox<int>(textBoxTickPerClick),
                        StepX = GetFromTextBox<int>(textBoxStepX),
                        StepY = GetFromTextBox<int>(textBoxStepY)
                    },
                    gr = new PP_growing
                    {
                        MaxLen = GetFromTextBox<int>(textBoxMaxLen),
                        DyingOff = GetFromTextBox<int>(textBoxDyingOff),
                        Youth = GetFromTextBox<int>(textBoxYouth),
                        Branches = GetFromTextBox<int>(textBoxBranches),

                        StepMaxLen = GetFromTextBox<int>(textBoxStepMaxLen),
                        StepMinLen = GetFromTextBox<int>(textBoxStepMinLen),

                        Bushiness = GetFromTextBox<double>(textBoxBushiness, true),
                        Vegetation = GetFromTextBox<double>(textBoxVegetation, true),
                        Slimness = GetFromTextBox<double>(textBoxSlimness, true),
                        Fade = GetFromTextBox<double>(textBoxFade, true),
                        CurlyMin = GetFromTextBox<double>(textBoxCurlyMin, true),
                        CurlyMax = GetFromTextBox<double>(textBoxCurlyMax, true),

                        Weight = GetFromTextBox<double>(textBoxWeight, true),
                        Fall = GetFromTextBox<double>(textBoxFall, true),
                        Plasticity = GetFromTextBox<double>(textBoxPlasticity, true),
                        Deviation = GetFromTextBox<double>(textBoxDeviation, true)

                    }
                };

                STREAM.WriteLine($"{p}");

                Plant.connect(STREAM);

                currentPlant = new Plant(pictureBox1, p);
                currentPlant.firatTickPlant();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.\n" +
                               "Используйте точку (.) для разделения дробной части.",
                                "Ошибка ввода",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        public T GetFromTextBox<T>(System.Windows.Forms.TextBox textBox, bool percent = false) where T : struct
        {
            if (textBox == null || string.IsNullOrWhiteSpace(textBox.Text))
            {
                STREAM.WriteLine($"GetFromTextBox - fail");

                return default(T);
            }

            Type targetType = typeof(T);

            if (targetType == typeof(double))
            {
                double value = double.Parse(textBox.Text) / (percent ? 100 : 1);
                return (T)(object)value;
            }
            else if (targetType == typeof(int))
            {
                double value = double.Parse(textBox.Text) / (percent ? 100 : 1);
                int intValue = (int)Math.Round(value);
                return (T)(object)intValue;
            }
            else if (targetType == typeof(float))
            {
                float value = float.Parse(textBox.Text) / (percent ? 100 : 1);
                return (T)(object)value;
            }
            else
            {
                throw new NotSupportedException($"Тип {targetType} не поддерживается");
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < Plant.Gens.visual.TickPerClick; i++)
            {
                currentPlant.tickPlant();
                currentPlant.drowPlant();
            }
        }

    }
    public struct PlantParams
    {
        public PP_visual visual;
        public PP_growing gr;
        public override string ToString()
        {
            return $"Visual: [{visual}], \nGrowing: [{gr}]";
        }
    }       
    public struct PP_visual
    {
        public int StepX, StepY, TickPerClick;
        public override string ToString()
        {
            return $"StepX: {StepX}, StepY: {StepY}, TickPerClick:{TickPerClick}";
        }
    } 
    public struct PP_growing
    {
        public int MaxLen, DyingOff, Youth, Branches;
        public int StepMaxLen, StepMinLen;
        public double Bushiness, Vegetation, Slimness, Fade, CurlyMax, CurlyMin, Weight, Fall, Plasticity, Deviation;
        public override string ToString()
        {
            return $"MaxLen: {MaxLen},\n DyingOff: {DyingOff},\n Youth: {Youth},\n Branches: {Branches},\n - \n " +
                   $"StepMaxLen: {StepMaxLen},\n StepMinLen: {StepMinLen},\n - \n " +
                   $"Bushiness: {Bushiness:F2},\n Vegetation: {Vegetation:F2},\n Slimness: {Slimness:F2},\n " +
                   $"Fade: {Fade:F2},\n CurlyMin: {CurlyMin:F2},\n CurlyMax: {CurlyMax:F2}, \n " +
                   $"Weight: {Weight:F2},\n Fall: {Fall:F3},\n Plasticity: {Plasticity:F2},\n Deviation: {Deviation:F2}";
        }
    }
    public interface InputOutputStream
    {
        string ReadLine(); 
        void WriteLine(string line);
    }
    public class InputOutputTextbox : InputOutputStream
    {
        RichTextBox console;
        string InputOutputStream.ReadLine()
        {
            if (console.Lines.Length == 0)
                return string.Empty;

            return console.Lines[console.Lines.Length - 1];
        }
        void InputOutputStream.WriteLine(string line)
        {
            console.AppendText(line + Environment.NewLine);
            console.ScrollToCaret();

        }
        public void Connect(RichTextBox consoleTextBox)
        {
            console = consoleTextBox;
            console.BackColor = Color.Black;
            console.ForeColor = Color.LimeGreen;
            console.Font = new Font("Consolas", 10);
            console.ScrollBars = RichTextBoxScrollBars.Vertical;
        }
    }
}
