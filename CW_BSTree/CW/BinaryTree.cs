using System;

namespace CW
{
    /// <summary>
    /// Класс для описания бинарного дерева поиска
    /// </summary>
    public class BinaryTree
    {
        public BinaryTreeNode Root; // Корень
        public int Count;           // Количество элементов в дереве
        public BinaryTree()         // Конструктор
        {
            Root = null;
        }
        // Добавление элемента в дерево
        public void Add(int value)
        {
            Count++;
            if (Root == null)       // Если корня не существует
            {
                Root = new BinaryTreeNode(Convert.ToString(value));
            }
            else
            {
                BinaryTreeNode iterator = Root;
                while (true)        // Спуск по дереву
                {
                    if (Convert.ToInt32(value) > Convert.ToInt32(iterator.Value))
                    {
                        if (iterator.Right != null)
                            iterator = iterator.Right;
                        else
                        {
                            iterator.Right = new BinaryTreeNode(Convert.ToString(value), iterator);
                            break;
                        }
                    }
                    else
                    {
                        if (iterator.Left != null)
                            iterator = iterator.Left;
                        else
                        {
                            iterator.Left = new BinaryTreeNode(Convert.ToString(value), iterator);
                            break;
                        }
                    }
                }
            }
        }
        // Очистка цветов дерева
        public static void Clear(BinaryTreeNode currentNode)
        {
            currentNode.Color = 0;

            if (currentNode.Right != null)
                Clear(currentNode.Right);
            if (currentNode.Left != null)
                Clear(currentNode.Left);
        }
        // Поиск по дереву
        public static string Find(BinaryTreeNode root, int value)
        {
            BinaryTreeNode currentNode = root;
            string ans = "";    // Строка для вывода пути поиска
            
            while (currentNode != null)
            {
                currentNode.Color = 1;

                if (value == Convert.ToInt32(currentNode.Value))
                {
                    ans += currentNode.Value;
                    currentNode.Color = 2;
                    return ans;
                }
                else if (value > Convert.ToInt32(currentNode.Value))
                {
                    ans += currentNode.Value + " -> ";
                    currentNode = currentNode.Right;
                }
                else
                {
                    ans += currentNode.Value + " -> ";
                    currentNode = currentNode.Left;
                }
                if (currentNode == null)
                    ans += "Не найдено";
            }
            return ans;
        }
        // Высота дерева
        public static int GetHeight(BinaryTreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return Math.Max(GetHeight(root.Left), GetHeight(root.Right)) + 1;
        }
        // Текущий уровень
        public static int CurrentLevel(int length)
        {
            var i = 1;
            var sum = 0;
            while (i < 32)
            {
                sum += 1 << (i - 1);
                if (length + 1 <= sum)
                    break;
                i++;
            }

            return i;
        }
    }
}
