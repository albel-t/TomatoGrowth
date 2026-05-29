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

                int maxLen = 0;
                if (!string.IsNullOrWhiteSpace(textBoxMaxLen.Text))
                {
                    maxLen = int.Parse(textBoxMaxLen.Text);
                }

                double bushiness = 0;
                if (!string.IsNullOrWhiteSpace(textBoxBushiness.Text))
                {
                    bushiness = double.Parse(textBoxBushiness.Text) / 100;
                }

                double dyingOff = 0;
                if (!string.IsNullOrWhiteSpace(textBoxDyingOff.Text))
                {
                    dyingOff = double.Parse(textBoxDyingOff.Text);
                }

                double youth = 0;
                if (!string.IsNullOrWhiteSpace(textBoxYouth.Text))
                {
                    youth = double.Parse(textBoxYouth.Text);
                }

                double vegetation = 0;
                if (!string.IsNullOrWhiteSpace(textBoxVegetation.Text))
                {
                    vegetation = double.Parse(textBoxVegetation.Text) / 100;
                }

                double curly = 0;
                if (!string.IsNullOrWhiteSpace(textBoxCurly.Text))
                {
                    curly = double.Parse(textBoxCurly.Text) / 100;
                }

                double slimness = 0;
                if (!string.IsNullOrWhiteSpace(textBoxSlimness.Text))
                {
                    slimness = double.Parse(textBoxSlimness.Text) / 100;
                }

                double fade = 0;
                if (!string.IsNullOrWhiteSpace(textBoxFade.Text))
                {
                    fade = double.Parse(textBoxFade.Text) / 100;
                }
                double branches = 0;
                if (!string.IsNullOrWhiteSpace(textBoxBranches.Text))
                {
                    branches = double.Parse(textBoxBranches.Text);
                }
                STREAM.WriteLine($"MaxLen: {maxLen}");
                STREAM.WriteLine($"Bushiness: {bushiness}");
                STREAM.WriteLine($"DyingOff: {dyingOff}");
                STREAM.WriteLine($"Youth: {youth}");
                STREAM.WriteLine($"Vegetation: {vegetation}");
                STREAM.WriteLine($"Curly: {curly}");
                STREAM.WriteLine($"Slimness: {slimness}");
                STREAM.WriteLine($"Fade: {fade}");
                STREAM.WriteLine($"Branches: {branches}");

                Plant.connect(STREAM);

                currentPlant = new Plant(pictureBox1, maxLen, bushiness, dyingOff, youth, vegetation, curly, slimness, fade, branches);
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
