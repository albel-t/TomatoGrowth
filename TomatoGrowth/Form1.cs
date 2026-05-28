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
                
                STREAM.WriteLine($"MaxLen: {maxLen}");
                STREAM.WriteLine($"Bushiness: {bushiness}");
                STREAM.WriteLine($"DyingOff: {dyingOff}");
                STREAM.WriteLine($"Youth: {youth}");
                STREAM.WriteLine($"Vegetation: {vegetation}");

                currentPlant = new Plant(maxLen, bushiness, dyingOff, youth, vegetation);

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
    interface InputOutputStream
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
