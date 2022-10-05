using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсач_саод
{
    public partial class Form1 : Form
    {
        private List<TextBox> textBoxes_in;     // массив TB исходный
        private List<TextBox> textBoxes_out;    // массив TB отсотрированный
        bool async_working = false;             // работает ли сортировка
        bool cancel_required = false;           // останавливать ли операцию
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // после загрузки формы
            textBoxes_in = new List<TextBox> { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10 };
            textBoxes_out = new List<TextBox> { textBox11, textBox12, textBox13, textBox14, textBox15, textBox16, textBox17, textBox18, textBox19, textBox20 };
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int comparing = 0;
                int replacing = 0;
                cancel_required = false;
                async_working = true;
                ViborSort(textBoxes_out.ToArray(), comparing, replacing);
            }
            else
            {
                MessageBox.Show("Данных для сортировки не обнаружено.");
            }        
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (async_working == true)
                cancel_required = true;
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                textBoxes_in[i].Text = textBoxes_out[i].Text = (rnd.Next(100)).ToString();
                textBoxes_in[i].BackColor = textBoxes_out[i].BackColor = SystemColors.Window;
            }
        }
        private async void ViborSort(TextBox[] textBoxes, int comparing, int replacing)
        {
            for (int i = 0; i < textBoxes.Length - 1; i++)
            {
                int min = i;
                textBoxes[min].BackColor = SystemColors.Desktop;
                for (int j = i + 1; j < textBoxes.Length; j++)
                {
                    textBoxes[j].BackColor = SystemColors.Info;
                    await Task.Delay(1000);

                    if (Convert.ToInt64(textBoxes[j].Text) < Convert.ToInt64(textBoxes[min].Text))
                    {
                        textBoxes[min].BackColor = SystemColors.Window;
                        textBoxes[j].BackColor = SystemColors.Desktop;
                        min = j;
                    }
                    else
                        textBoxes[j].BackColor = SystemColors.Window;
                    comparing++;
                    // если нужно остановить операцию
                    if (cancel_required == true)
                        return;
                }
                await Task.Delay(1000);

                string temp_str = textBoxes[min].Text;
                textBoxes[min].Text = textBoxes[i].Text;
                textBoxes[i].Text = temp_str;

                textBoxes[min].BackColor = SystemColors.Window;
                textBoxes[i].BackColor = Color.LightGreen;

                replacing++;
            }
            textBoxes[textBoxes.Length - 1].BackColor = Color.LightGreen;
            string compare = Convert.ToString(comparing);
            string replace = Convert.ToString(replacing);
            richTextBox1.Text = "Количество сравнений = " + compare + "\n" + "Количество перестановок = " + replace;
            async_working = false;
        }
    }
}