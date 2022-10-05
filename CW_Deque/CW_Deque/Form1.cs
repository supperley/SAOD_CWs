using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CW_Deque
{
    public partial class Form1 : Form
    {
        private readonly Deque deque = new Deque();
        public Form1()
        {
            InitializeComponent();
        }
        private void Update_ListView()
        {

            DequeNode current = deque.head;
            while (current != null)
            {
                ListViewItem listViewItem = new ListViewItem(current.Data);
                listViewItem.SubItems.Add(deque.GetAddress(current));
                listViewItem.SubItems.Add(deque.GetAddress(current.Previous));
                listViewItem.SubItems.Add(deque.GetAddress(current.Next));
                listView_deque.Items.Add(listViewItem);
                current = current.Next;
            }
        }

        private void Btn_PushFront_Click(object sender, System.EventArgs e)
        {
            string str = textBox_input.Text;
            if (str == "")
            {
                MessageBox.Show("Введите строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            textBox_input.Clear();
            deque.PushFront(str);
            listView_deque.Items.Clear();
            Update_ListView();
        }

        private void Btn_PushBack_Click(object sender, System.EventArgs e)
        {
            string str = textBox_input.Text;
            if (str == "")
            {
                MessageBox.Show("Введите строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            textBox_input.Clear();
            deque.PushBack(str);
            listView_deque.Items.Clear();
            Update_ListView();
        }
        private void Btn_PopFront_Click(object sender, System.EventArgs e)
        {
            deque.PopFront();
            listView_deque.Items.Clear();
            Update_ListView();
        }

        private void Btn_PopBack_Click(object sender, System.EventArgs e)
        {
            deque.PopBack();
            listView_deque.Items.Clear();
            Update_ListView();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            deque.Clear();
            listView_deque.Items.Clear();
            Update_ListView();
        }

        private void Btn_IsEqual_Click(object sender, EventArgs e)
        {
            string str = textBox_input.Text;
            if (str == "")
            {
                MessageBox.Show("Введите строку!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string ans = (deque.Contains(str) == true) ? "Элемент в деке найден!" : "Элемент в деке не найден!";
            MessageBox.Show(ans, "Поиск в деке", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение, реализующее дек с графической иллюстрацией работы дека. 2021 г.", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    // Дэк
    public class Deque
    {
        public DequeNode head;  // Первый элемент
        public DequeNode tail;  // Последний элемент
        int count = 0;          // Количество элементов в списке

        // Получить адрес
        public unsafe string GetAddress(DequeNode element)
        {
            TypedReference a = __makeref(element);
            IntPtr address = **(IntPtr**)&a;
            return Convert.ToString(address);
        }

        // Добавить в конец
        public void PushBack(string data)
        {
            DequeNode node = new DequeNode(data);

            if (head == null)
                head = node;
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            count++;
        }
        // Добавить в начало
        public void PushFront(string data)
        {
            DequeNode node = new DequeNode(data)
            {
                Next = head
            };
            if (count == 0)
                tail = node;
            else
                head.Previous = node;
            head = node;
            count++;
        }
        // Удалить с начала
        public void PopFront()
        {
            if (count == 0)
            {
                MessageBox.Show("Дек пуст!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (count == 1)
            {
                head = tail = null;
            }
            else
            {
                head = head.Next;
                head.Previous = null;
            }
            count--;
            return;
        }
        // Удалить с конца
        public void PopBack()
        {
            if (count == 0)
            {
                MessageBox.Show("Дек пуст!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (count == 1)
            {
                head = tail = null;
            }
            else
            {
                tail = tail.Previous;
                tail.Next = null;
            }
            count--;
            return;
        }
        // Очистить
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        // Содержится ли элементы 
        public bool Contains(string data)
        {
            DequeNode current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }
    }
    // Каждый элемент дека
    public class DequeNode
    {
        public DequeNode(string data)
        {
            Data = data;
        }
        public string Data { get; set; }
        public DequeNode Previous { get; set; }
        public DequeNode Next { get; set; }
    }
}
