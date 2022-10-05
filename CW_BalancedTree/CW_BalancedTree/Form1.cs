using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_BalancedTree
{
    public partial class Form1 : Form
    {
        private List<TextBox> textBoxes_arr;     // список TB - массив
        private List<TextBox> textBoxes_tree;    // массив TB - дерево
        private List<int> arr = new List<int>();
        BinarySearchTree tree = new BinarySearchTree();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxes_arr = new List<TextBox> { TB_arr_1, TB_arr_2, TB_arr_3, TB_arr_4, TB_arr_5, TB_arr_6, TB_arr_7, TB_arr_8, TB_arr_9, TB_arr_10, TB_arr_11, TB_arr_12, TB_arr_13, TB_arr_14, TB_arr_15 };
            textBoxes_tree = new List<TextBox> { TB_tree_1, TB_tree_2, TB_tree_3, TB_tree_4, TB_tree_5, TB_tree_6, TB_tree_7, TB_tree_8, TB_tree_9, TB_tree_10, TB_tree_11, TB_tree_12, TB_tree_13, TB_tree_14, TB_tree_15 };
            TB_delay.Text = "2000";
        }

        private void Btn_generate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
                textBoxes_tree[i].Text = "";
            if (tree.async_working == true)
            {
                MessageBox.Show("Дождитесь окончания балансировки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Random rnd = new Random();
            arr.Clear();
            for (int i = 0; i < 15; i++)
            {
                int x = rnd.Next(100);
                arr.Add(x);
                textBoxes_arr[i].Text = x.ToString();
                textBoxes_arr[i].BackColor = SystemColors.Window;
            }
        }

        private async void Btn_balance_ClickAsync(object sender, EventArgs e)
        {
            if (arr.Count < 15)
            {
                MessageBox.Show("Сгенерируйте массив!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tree.async_working = true;
            arr.Sort();
            for (int i = 0; i < 15; i++)
            {
                textBoxes_arr[i].Text = arr[i].ToString();
                textBoxes_arr[i].BackColor = SystemColors.Window;
            }
            int delay = Convert.ToInt32(TB_delay.Text);
            await Task.Delay(delay);
            await tree.SortedArrayToBST(textBoxes_tree, textBoxes_arr, arr, delay, 0, 14, 0);
            tree.async_working = false;
        }

        private void Btn_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение для иллюстрации балансировки бинарного дерева.", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    public class TNode
    {
        public int data;
        public TNode left;
        public TNode right;
        public TNode(int in_data)
        {
            data = in_data;
            left = null;
            right = null;
        }
        public TNode()
        {
            data = 0;
            left = null;
            right = null;
        }
    };
    public class BinarySearchTree
    {
        public TNode root = null;
        public int count = 0;
        public bool async_working = false;  // работает ли алгоритм
        public async Task<TNode> SortedArrayToBST(List<TextBox> textBoxes_tree, List<TextBox> textBoxes_arr, List<int> arr, int delay, int start, int end, int number)
        {
            if (start > end)
                return new TNode();

            for (int i = start; i <= end; i++)
                textBoxes_arr[i].BackColor = SystemColors.ControlDark;

            int mid = (start + end) / 2;
            TNode new_root = new TNode(arr[mid]);
            textBoxes_arr[mid].BackColor = Color.Yellow;
            textBoxes_tree[number].Text = arr[mid].ToString();
            await Task.Delay(delay);
            for (int i = start; i <= end; i++)
                textBoxes_arr[i].BackColor = SystemColors.Window;

            new_root.left = await SortedArrayToBST(textBoxes_tree, textBoxes_arr, arr, delay, start, mid - 1, 2 * number + 1);

            new_root.right = await SortedArrayToBST(textBoxes_tree, textBoxes_arr, arr, delay, mid + 1, end, 2 * number + 2);

            root = new_root;
            return new_root;
        }
    };
}
