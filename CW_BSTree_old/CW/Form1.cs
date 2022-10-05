using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace CW
{
    public partial class Form1 : Form
    {
        BinaryTree.BinaryTree binaryTree = new BinaryTree.BinaryTree();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Binary Search Tree\n");

            binaryTree.Insert(75);
            binaryTree.Insert(57);
            binaryTree.Insert(90);
            binaryTree.Insert(32);
            binaryTree.Insert(11);
            binaryTree.Insert(44);
            binaryTree.Insert(60);
            binaryTree.Insert(86);
            binaryTree.Insert(93);
            binaryTree.Insert(99);
            binaryTree.Insert(100);

            Console.WriteLine("\nPre Order Traversal (Root->Left->Right)");
            binaryTree.PreorderTraversal();

            CalculateTree();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            CalculateTree();
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            // Clear any previously selected nodes.
            binaryTree.SetSubtreeBg(Brushes.White);

            if (tb_find.Text != "")
            {
                // Find the indicated node.
                int number = int.Parse(tb_find.Text);

                BinaryTree.TreeNode selected_node =
                    binaryTree.Find(number);

                // Mark the node.
                if (selected_node != null)
                    selected_node.BgBrush = Brushes.OrangeRed;

                pictureBox.Refresh();
            }

            tb_find.Text = "";
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (tb_insert.Text != "")
            {
                int number = int.Parse(tb_insert.Text);
                binaryTree.Insert(number);
                CalculateTree();
            }
            tb_insert.Text = "";
        }
        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            binaryTree.DrawTree(e.Graphics);
        }

        private void CalculateTree()
        {
            using (Graphics gr = pictureBox.CreateGraphics())
            {
                float xmin = 0, ymin = 0;

                // Calculate the tree to center it horizontally.
                xmin = pictureBox.Width / 2 - btn_find.Width;
                ymin = 10;
                binaryTree.Calculate(gr, ref xmin, ref ymin);
            }

            pictureBox.Refresh();
        }
    }
}
