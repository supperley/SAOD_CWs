using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace AVL_Tree
{
    public class AVLTree
    {
        public Node root;
        public string inOrderResult;

        public Dictionary<string, Circle> Circle = new Dictionary<string, Circle>();
        public Dictionary<string, Line> Line = new Dictionary<string, Line>();
        readonly Form1 form;
        int ctrLine = 1;
        int ctrCircle = 1;

        public AVLTree(Form1 _form)
        {
            form = _form;
            root = null;
        }
        // Высота узла
        int Height(Node N)
        {
            if (N == null)
                return 0;
            return N.height;
        }

        // Правый поворот поддререва с корнем y
        Node RightRotate(Node y)
        {
            Node x = y.left;
            Node T2 = x.right;

            // Поворот
            x.right = y;
            y.left = T2;

            // Обновить высоты
            y.height = Math.Max(Height(y.left), Height(y.right)) + 1;
            x.height = Math.Max(Height(x.left), Height(x.right)) + 1;

            // Вернуть новый корень
            return x;
        }

        // Левый поворот поддерева с корнем x
        Node LeftRotate(Node x)
        {
            // Y - новый корень
            // T2 - новый корневой левый дочерний элемент
            Node y = x.right;
            Node T2 = y.left;

            // Поворот
            y.left = x;
            x.right = T2;

            // Обновить высоты 
            x.height = Math.Max(Height(x.left), Height(x.right)) + 1;
            y.height = Math.Max(Height(y.left), Height(y.right)) + 1;

            // Вернуть новый корень
            return y;
        }
        // Задержка вывода текста
        public void Delay()
        {
            form.pictureBox1.Invalidate();
            Application.DoEvents();
            Thread.Sleep(1000);

        }
        // Просчитать балансированность
        int GetBalance(Node N)
        {
            if (N == null)
                return 0;
            return Height(N.left) - Height(N.right);
        }
        public Node InsertHelper(Node node, int key)
        {
            return Insert(node, key, 1, 1, 34);
        }
        public Node Insert(Node node, int key, int num, int level, int height)
        {
            if (node == null)
            {
                form.Status.Text = "Данной вершины не существует";
                Delay();
                form.Status.Text = "Создаем узел";
                Delay();

                Circle.Add("Circle" + ctrCircle, new Circle(484 / level * num + 1, height, key.ToString()));
                ctrCircle++;
                form.pictureBox1.Invalidate();
                return (new Node(key, "Circle" + (ctrCircle - 1)));

            }

            if (key < node.key)
            {
                form.Status.Text = key + " меньше чем " + node.key;
                Circle[node.idCircle].brush = new SolidBrush(Color.Yellow);
                Delay();
                form.Status.Text = " Переходим влево";
                Circle[node.idCircle].brush = new SolidBrush(Color.Black);
                Delay();

                node.left = Insert(node.left, key, (num * 2) - 1, level * 2, height + 100);
            }
            else if (key > node.key)
            {
                form.Status.Text = key + " больше чем " + node.key;
                Circle[node.idCircle].brush = new SolidBrush(Color.Yellow);
                Delay();
                form.Status.Text = " Переходим вправо";
                Circle[node.idCircle].brush = new SolidBrush(Color.Black);
                Delay();
                node.right = Insert(node.right, key, (num * 2) + 1, level * 2, height + 100);
            }
            else
                return node;

            // Обновить высоту этого узла-предка
            node.height = 1 + Math.Max(Height(node.left), Height(node.right));

            /* Получите коэффициент баланса этого узла-предка, 
             * чтобы проверить, не стал ли этот узел несбалансированным. */
            int balance = GetBalance(node);

            // Если этот узел становится несбалансированным, то
            // есть 4 случая - R поворот
            if (balance > 1 && key < node.left.key)
            {
                form.Status.Text = "Правый поворот для " + node.key;
                Delay();
                return RightRotate(node);
            }

            // L поворот
            if (balance < -1 && key > node.right.key)
            {
                form.Status.Text = "Левый поворот для " + node.key;
                Delay();
                return LeftRotate(node);
            }

            // LR поворот
            if (balance > 1 && key > node.left.key)
            {
                form.Status.Text = "LR поворот для " + node.key;
                Delay();
                node.left = LeftRotate(node.left);
                return RightRotate(node);
            }

            // RL поворот
            if (balance < -1 && key < node.right.key)
            {
                form.Status.Text = "RL поворот для " + node.key;
                Delay();
                node.right = RightRotate(node.right);
                return LeftRotate(node);
            }
            return node;
        }

        public void Clear()
        {
            Circle.Clear();
            Line.Clear();
            ctrCircle = 1;
            ctrLine = 1;
            root = null;
            form.pictureBox1.Invalidate();
        }

        public void InOrder(Node root)
        {
            if (root == null) return;
            InOrder(root.left);
            Circle[root.idCircle].brush = new SolidBrush(Color.Yellow);
            Delay();
            inOrderResult += root.key + " ";
            InOrder(root.right);

        }

        public void InOrderHelper()
        {
            Circle.Clear();
            Line.Clear();
            ctrCircle = 1;
            ctrLine = 1;
            InOrderClear(ref this.root, 1, 1, 50);
        }

        public void InOrderClear(ref Node root, int num, int level, int height)
        {
            if (root == null) return;
            InOrderClear(ref root.left, (num * 2) - 1, level * 2, height + 100);

            Circle.Add("Circle" + ctrCircle, new Circle(484 / level * num + 1, height, root.key.ToString()));
            root.idCircle = "Circle" + ctrCircle;
            ctrCircle++;
            form.pictureBox1.Invalidate();
            Application.DoEvents();
            if (root.left != null)
            {
                Line.Add("Line" + ctrLine, new Line((484 / level * num + 1) + 25, height + 30, (484 / (level * 2)) * ((num * 2) - 1) + 25, height + 100));
                ctrLine++;
                form.pictureBox1.Invalidate();
            }

            if (root.right != null)
            {
                Line.Add("Line" + ctrLine, new Line((484 / level * num + 1) + 25, height + 30, (484 / (level * 2)) * ((num * 2) + 1) + 25, height + 100));
                ctrLine++;
                form.pictureBox1.Invalidate();
            }
            InOrderClear(ref root.right, (num * 2) + 1, level * 2, height + 100);
        }
    }
}