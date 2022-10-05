using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace CW
{
    public partial class Form1 : Form
    {
        public BinarySearchTree tree = new BinarySearchTree();
        public TextBox[] arr;
        public double hight = 4.0;
        public int count = 0;
        public Form1()
        {
            InitializeComponent();
            arr = new TextBox[]{ text1, text2, text3, text4, text5, text6, text7, text8,
                text9, text10, text11, text12, text13, text14, text15 };
            tree.createTree();
            feelTree(tree.head);
            count = 0;
        }

        public void feelTree(Node head)
        {
            if (head != null)
            {
                arr[count].Text = head.key.ToString();
                count++;
                feelTree(head.left);
                feelTree(head.right);
            }
        }

        public Node visualSearch(Node node, int key)
        {
            if (node == null)
            {
                return null;
            }
            arr[count].BackColor = Color.Yellow;
            Update();
            Thread.Sleep(2000);
            if (node.key == key)
            {
                arr[count].BackColor = Color.LightGreen;
                Update();
                return node;
            }
            else
            {
                hight--;
                arr[count].BackColor = Color.LightPink;
                Update();
            }
            if (key < node.key)
            {
                count++;
                return visualSearch(node.left, key);
            }
            else
            {
                count += Convert.ToInt32(Math.Pow(2.0, hight));
                return visualSearch(node.right, key);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int key = Int32.Parse(textKey.Text);
                button1.Enabled = false;
                button1.Visible = false;
                Node answer = visualSearch(tree.head, key);
                string str = "Элемент не найден\nКоличество сравнений:4";
                if(answer != null)
                {
                    str = "Элемент " + Convert.ToString(answer.key) + "\nКоличество сравнений:" 
                        + Convert.ToString(5 - hight);
                }
                textOut.Text = str;
                count = 0;
            }
            catch(Exception)
            {
                textKey.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int ind = 0;ind < 15; ind++)
            {
                arr[ind].BackColor = Color.White;
            }
            textOut.Text = "";
            tree.createTree();
            feelTree(tree.head);
            count = 0;
            hight = 4.0;
            button1.Enabled = true;
            button1.Visible = true;
        }
    }

    public class Node
    {
        public int key;
        public Node left = null;
        public Node right = null;

        public Node(int k)
        {
            key = k;
        }
    }

    public class BinarySearchTree
    {
        public Node head = null;
        public int count = 0;

        private void sort(int[] array)
        {
            int len = array.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        private int search(int[] arr, int key, int len)
        {
            int answer = -1;
            for(int ind =0;ind< len; ind++)
            {
                if(arr[ind]== key)
                {
                    answer = ind;
                }
            }
            return answer;
        }

        private Node createBalancedTree(int[] arr)
        {
            return createBTrecursive(arr, 0, arr.Length - 1);
        }

        private Node createBTrecursive(int[] arr, int start, int end)
        {
            if (end < start)
            {
                return null;
            }
            int mid = (start + end) / 2;
            Node node = new Node(arr[mid]);

            node.left = createBTrecursive(arr, start, mid - 1);
            node.right = createBTrecursive(arr, mid + 1, end);

            return node;
        }

        public void createTree()
        {
            count = 0;
            int[] arr = new int[15];
            Random rand = new Random();
            int currentKey;
            while (count < 15)
            {
                currentKey = rand.Next(1, 99);
                if (search(arr, currentKey, count) == -1)
                {
                    arr[count] = currentKey;
                    count++;
                }
            }
            sort(arr);
            head = createBalancedTree(arr);
        }

    }
}
