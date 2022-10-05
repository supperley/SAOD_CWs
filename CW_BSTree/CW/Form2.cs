using System;
using System.Windows.Forms;

namespace CW
{
    public partial class Form2 : Form
    {
        Form1 form1;
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            form1 = (Form1)this.Owner;
            NumericUpDown1.Value = form1.Box;
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            form1.Box = (int)NumericUpDown1.Value;
        }
    }
}
