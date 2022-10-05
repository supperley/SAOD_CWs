using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace CW
{
    public partial class Form1 : Form
    {
        Graphics g;
        public static BinaryTree tree;
        private int box = 50;   // ширина одной "клетки"
        public int Box
        {
            get
            {
                return box;    // возвращаем значение свойства
            }
            set
            {
                box = value;   // устанавливаем новое значение свойства
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Num_count.Value = 12;
            TB_from.Text = "0";
            TB_to.Text = "100";
            TB_find.Text = "32";
            int[] arr = { 41, 20, 65, 11, 29, 50, 91, 9, 12, 25, 32, 45, 55, 72, 99 };
            Array.Sort(arr);
            tree = new BinaryTree();
            BinaryTreeHelper.BalancedAddFromArray(tree, arr, 0, arr.Length - 1);
        }

        private void Btn_generate_Click(object sender, EventArgs e)
        {
            tree = BinaryTreeHelper.GenerateBinaryTreeRandom(Convert.ToInt32(Num_count.Value), Convert.ToInt32(TB_from.Text), Convert.ToInt32(TB_to.Text));
            BinaryTree.Clear(tree.Root);
            PictureBox1.Refresh();
        }

        private void Btn_find_Click(object sender, EventArgs e)
        {
            BinaryTree.Clear(tree.Root);
            tb_find_step.Text = BinaryTree.Find(tree.Root, Convert.ToInt32(TB_find.Text));
            PictureBox1.Refresh();
        }
        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.AntiAlias;
            g.Clear(Color.White);
            BinaryTreeHelper.Display(tree, tree.Root, g, Box);
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2
            {
                Owner = this
            };
            form2.ShowDialog();
            PictureBox1.Refresh();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
