using System.Drawing;
namespace AVL_Tree
{
    public class Circle
    {
        public int x;
        public int y;
        public string value;
        public Brush brush;
        public Circle(int _x, int _y, string _value)
        {
            x = _x;
            y = _y;
            value = _value;
            brush = new SolidBrush(Color.Black);
        }
    }

}
