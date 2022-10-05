using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;
namespace AVL_Tree
{
    public partial class Form1 : Form
    {
        readonly AVLTree tree;
        public Form1()
        {
            InitializeComponent();
            tree = new AVLTree(this);
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;

            foreach (var item in tree.Line.Values)
            {
                e.Graphics.DrawLine(new Pen(Color.Black), item.x1, item.y1, item.x2, item.y2);
            }

            foreach (var item in tree.Circle.Values)
            {
                e.Graphics.FillEllipse(item.brush, item.x, item.y, 50, 50);
                e.Graphics.DrawString(item.value, new Font("Arial", 16), new SolidBrush(Color.White), new Point(item.x + 8, item.y + 10));
                // e.Graphics.DrawString(item.height.ToString(), new Font("Arial", 16), new SolidBrush(Color.Black), new Point(item.x + 38, item.y + 10));
            }
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            tree.root = tree.InsertHelper(tree.root, Convert.ToInt32(valueBox.Text));
            tree.InOrderHelper();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            tree.Clear();
            tree.InOrderHelper();
            Status.Text = "";
        }

        private void Btn_About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение для иллюстрации балансировки бинарного дерева.", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
