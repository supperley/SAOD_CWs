using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW
{
    /// <summary>
    /// Класс для описания узла дерева
    /// </summary>
    public class BinaryTreeNode
    {
        public string Value;                        // Информационное поле
        public int Color;                           // Служебное поле (цвет вершины, 1 - промежутчная, 2 - искомая)
        public BinaryTreeNode Parent, Left, Right;  // Указатели на родителя, левое и правое поддеревья
        public BinaryTreeNode(string value, BinaryTreeNode parent = null)
        // Конструктор 
        {
            Left = null;
            Right = null;
            Parent = parent;
            Value = value;
            Color = 0;
        }
    }
}
