using System;
using System.Collections.Generic;
using System.Drawing;

namespace CW
{
    /// <summary>
    /// Класс для взаимодействия формы с бинарным деревом поиска
    /// </summary>
    public static class BinaryTreeHelper
    {
        private static readonly Random rand = new Random(DateTime.Now.Day);
        /// Метод для заполнения бинарного дерева случайными числами (без повторений)
        public static BinaryTree GenerateBinaryTreeRandom(int count, int from, int to)
        {
            BinaryTree binaryTree = new BinaryTree();
            List<int> list = new List<int>();
            while (list.Count < count)
            {
                int new_number = rand.Next(from, to);
                if (!list.Contains(new_number))
                    list.Add(new_number);
            }
            list.Sort();
            BalancedAddFromArray(binaryTree, list.ToArray(), 0, count - 1);
            return binaryTree;
        }
        // Сбалансированное добавление в дерево
        public static void BalancedAddFromArray(BinaryTree binaryTree, int[] arr, int start, int end)
        {
            if (start > end)
                return;
            // Выбираем средний элемент
            int mid = start + (end - start) / 2;
            binaryTree.Add(arr[mid]);
            // Рекурсивно заполняем левое поддерево
            BalancedAddFromArray(binaryTree, arr, start, mid - 1);
            // Рекурсивно заполняем правое поддерево
            BalancedAddFromArray(binaryTree, arr, mid + 1, end);
            return;
        }
        // Рекурсивная прорисовка дерева
        // i - порядковый номер элемента в полном дереве
        public static void Display(BinaryTree tree, BinaryTreeNode currentNode, Graphics canvas, int box, int i = 0)
        {
            var height = BinaryTree.GetHeight(tree.Root);
            Pen pen = new Pen(Brushes.Gray, (float)0.5);
            if (Convert.ToInt32(currentNode.Value) != int.MaxValue)
                DrawNode(currentNode.Value, canvas, GetX(height, i, box), GetY(i, box), currentNode.Color);

            if (height + 1 - BinaryTree.CurrentLevel(i) == 1)
                return;

            var xN = GetX(height, i, box);
            var yN = GetY(i, box);

            if (currentNode.Left != null)
            {
                var xL = GetX(height, 2 * i + 1, box);
                var yL = GetY(2 * i + 1, box);
                canvas.DrawLine(pen, xN, yN, xL, yL);
                Display(tree, currentNode.Left, canvas, box, 2 * i + 1);
            }

            if (currentNode.Right != null)
            {
                var xR = GetX(height, 2 * i + 2, box);
                var yR = GetY(2 * i + 2, box);
                canvas.DrawLine(pen, xN, yN, xR, yR);
                Display(tree, currentNode.Right, canvas, box, 2 * i + 2);
            }
        }
        // Прорисовка узла
        private static void DrawNode(string val, Graphics canvas, int x, int y, int color = 0)
        {
            const float PT_DM = 10;    // диаметр точки
            SolidBrush brush = new SolidBrush(Color.SteelBlue);

            if (color == 1)
                brush.Color = Color.Yellow;
            else if (color == 2)
                brush.Color = Color.Red;

            canvas.FillEllipse(brush, x - PT_DM / 2, y, PT_DM, PT_DM);

            Font drawFont = new Font("Arial", 10);
            SolidBrush fontBrush = new SolidBrush(Color.Gray);

            canvas.DrawString(val, drawFont, fontBrush, x + PT_DM / 2, y + PT_DM / 2);
        }
        // Координата по оси X
        private static int GetX(int height, int i, int box)
        {
            var level = BinaryTree.CurrentLevel(i);             // уровень
            var weight = (int)Math.Pow(2, level - 1);           // количество узлов на уровне
            var order = i - weight + 1;                         // номер узла на уровне
            var depth = height + 1 - level;                     // глубина
            var f_step = (int)Math.Pow(2, depth - 1) - 1;       // шаг по горизонтали
            var s_step = (int)Math.Pow(2, depth);               // шаг по вертикали
            var x = 20 + f_step * box + s_step * order * box;     
            return x;
        }
        // Координата по оси Y
        private static int GetY(int i, int box)
        {
            var y = box * BinaryTree.CurrentLevel(i);
            return y;
        }
    }
}
