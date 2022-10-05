using CW_Stack;
using System;
using System.Collections;
using System.Windows.Forms;

namespace CW_Stack
{
    public partial class Form1 : Form
    {
        readonly Stack stack = new Stack();
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            string str = TB_input.Text;
            if (str == "")
            {
                MessageBox.Show("Введите строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TB_input.Clear();
            stack.Push(str);
            listView_stack.Items.Clear();
            Update_ListBox();
        }

        private void Update_ListBox()
        {
            
            Node current = stack.Head;
            while (current != null)
            {
                ListViewItem listViewItem = new ListViewItem(current.Data);
                listViewItem.SubItems.Add(stack.GetAddress(current));
                listViewItem.SubItems.Add(stack.GetAddress(current.Next));
                listView_stack.Items.Add(listViewItem);
                //listView_stack.Items.Add(current.Data);
                current = current.Next;
            }
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                stack.Pop();
            }
            catch (Exception)
            {
                MessageBox.Show("Cтек пустой!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            listView_stack.Items.Clear();
            Update_ListBox();
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            stack.Clear();
            listView_stack.Items.Clear();
            Update_ListBox();
        }

        private void Btn_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение, реализующее стек с графической иллюстрацией работы стека.", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    class Node
    {
        public string Data { get; set; }
        public Node Next { get; set; }
        public Node(string data)
        {
            Data = data;
            Next = null;
        }
    };
    class Stack
    {
        public Node Head { get; set; }
        public int Length { get; set; }

        public string Get_top()
        {
            return Head.Data;
        }

        public unsafe string GetAddress(Node element)
        {
            TypedReference a = __makeref(element);
            IntPtr address = **(IntPtr**)&a;
            return Convert.ToString(address);
        }

        public void Push(string data)
        {
            Node temp_node = new Node(data)
            {
                Next = Head
            };
            Head = temp_node;
            Length++;
        }

        public string Pop()
        {
            if (Length == 0)
            {
                throw new InvalidOperationException();
            }
            string temp = Head.Data;
            Head = Head.Next;
            Length--;
            return temp; 
        }
        public void Clear()
        {
            Head = null;
            Length = 0;
        }
    }
}
