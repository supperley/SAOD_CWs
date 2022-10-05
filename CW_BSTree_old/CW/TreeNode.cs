using System;
using System.Drawing;

namespace BinaryTree
{
    public class TreeNode
    {
        // Drawing properties.
        public Font MyFont = null;
        public Pen MyPen = Pens.Black;
        public Brush FontBrush = Brushes.Black;
        public Brush BgBrush = Brushes.White;

        // Space to skip horizontally between siblings
        // and vertically between generations.
        private const float Hoffset = 5;
        private const float Voffset = 10;
        private const float MinSubtreeWidth = 20;

        // Set this node's center position.
        // The node's center after arranging.
        private PointF Center;

        public string Text;

        //property to store the nodes data could be a key and object pair
        private int data;
        public int Data
        {
            get { return data; }
        }

        //Right Child
        private TreeNode rightNode;
        public TreeNode RightNode
        {
            get { return rightNode; }
            set { rightNode = value; }
        }

        //Left Child
        private TreeNode leftNode;
        public TreeNode LeftNode
        {
            get { return leftNode; }
            set { leftNode = value; }
        }

        //Node constructor
        public TreeNode(int value)
        {
            data = value;
            Text = value.ToString();
            MyFont = new Font("Times New Roman", 12);
        }

        public TreeNode Find(int value)
        {
            //this node is the starting current node
            TreeNode currentNode = this;

            //loop through this node and all of the children of this node
            while (currentNode != null)
            {
                currentNode.BgBrush = Brushes.LightGray;
                //if the current nodes data is equal to the value passed in return it
                if (value == currentNode.data)
                {
                    return currentNode;
                }
                else if (value > currentNode.data)//if the value passed in is greater than the current data then go to the right child
                {
                    currentNode = currentNode.rightNode;
                }
                else//otherwise if the value is less than the current nodes data the go to the left child node 
                {
                    currentNode = currentNode.leftNode;
                }
            }
            //Node not found
            return null;
        }

        public TreeNode FindRecursive(int value)
        {
            //value passed in matches nodes data return the node
            if (value == data)
            {
                return this;
            }
            else if (value < data && leftNode != null)//if the value passed in is less than the current data then go to the left child
            {
                return leftNode.FindRecursive(value);
            }
            else if (rightNode != null)//if its great then go to the right child node
            {
                return rightNode.FindRecursive(value);
            }
            else
            {
                return null;
            }
        }

        //recursively calls insert down the tree until it find an open spot
        public void Insert(int value)
        {
            //if the value passed in is greater or equal to the data then insert to right node
            if (value >= data)
            {   //if right child node is null create one
                if (rightNode == null)
                {
                    rightNode = new TreeNode(value);
                }
                else
                {//if right node is not null recursivly call insert on the right node
                    rightNode.Insert(value);
                }
            }
            else
            {//if the value passed in is less than the data then insert to left node
                if (leftNode == null)
                {//if the leftnode is null then create a new node
                    leftNode = new TreeNode(value);
                }
                else
                {//if the left node is not null then recursively call insert on the left node
                    leftNode.Insert(value);
                }
            }
        }

        //Root->Left->Right Nodes recursively of each subtree 
        public void PreOrderTraversal()
        {
            //First we print the root node 
            Console.WriteLine(data + " ");

            //Then go to left child its children will be null so we print its data
            if (leftNode != null)
                leftNode.PreOrderTraversal();

            //Then we go to the right node which will print itself as both its children are null
            if (rightNode != null)
                rightNode.PreOrderTraversal();
        }

        // Calculate the node and its children in the allowed area.
        // Set xmin to indicate the right edge of our subtree.
        // Set ymin to indicate the bottom edge of our subtree.
        public void Calculate(Graphics gr, ref float xmin, ref float ymin)
        {
            // See how big this node is.
            SizeF my_size = GetSize(gr, MyFont);

            // Recursively arrange our children,
            // allowing room for this node.
            float x = xmin;
            float biggest_ymin = ymin + my_size.Height;
            float subtree_ymin = ymin + my_size.Height + Voffset;

            if (LeftNode != null)
            {
                // Arrange this child's subtree.
                float child_ymin = subtree_ymin;
                LeftNode.Calculate(gr, ref x, ref child_ymin);

                // See if this increases the biggest ymin value.
                if (biggest_ymin < child_ymin) biggest_ymin = child_ymin;
            }
            else x += MinSubtreeWidth;

            // Allow room between the children.
            x += Hoffset;

            if (RightNode != null)
            {
                // Arrange this child's subtree.
                float child_ymin = subtree_ymin;
                RightNode.Calculate(gr, ref x, ref child_ymin);

                // See if this increases the biggest ymin value.
                if (biggest_ymin < child_ymin) biggest_ymin = child_ymin;
            }
            else x += MinSubtreeWidth;

            // See if this node is wider than the subtree under it.
            float subtree_width = x - xmin;
            if (my_size.Width > subtree_width)
            {
                // Center the subtree under this node.
                // Make the children rearrange themselves
                // moved to center their subtrees.
                x = xmin + (my_size.Width - subtree_width) / 2;
                if (LeftNode != null)
                {
                    // Arrange this child's subtree.
                    LeftNode.Calculate(gr, ref x, ref subtree_ymin);
                }
                else x += MinSubtreeWidth;

                // Allow room between the children.
                x += Hoffset;

                if (RightNode != null)
                {
                    // Arrange this child's subtree.
                    RightNode.Calculate(gr, ref x, ref subtree_ymin);
                }
                else x += MinSubtreeWidth;

                // The subtree's width is this node's width.
                subtree_width = my_size.Width;
            }

            // Set this node's center position.
            Center = new PointF(
                xmin + subtree_width / 2,
                ymin + my_size.Height / 2);

            // Increase xmin to allow room for
            // the subtree before returning.
            xmin += subtree_width;

            // Set the return value for ymin.
            ymin = biggest_ymin;
        }

        // Draw the links for the subtree rooted at this node.
        public void DrawSubtreeLinks(Graphics gr)
        {
            if (LeftNode != null)
            {
                // Draw the link between this node this child.
                gr.DrawLine(MyPen, Center, LeftNode.Center);

                // Recursively make the child draw its subtree nodes.
                LeftNode.DrawSubtreeLinks(gr);
            }
            if (RightNode != null)
            {
                // Draw the link between this node this child.
                gr.DrawLine(MyPen, Center, RightNode.Center);

                // Recursively make the child draw its subtree nodes.
                RightNode.DrawSubtreeLinks(gr);
            }
        }

        // Draw the nodes for the subtree rooted at this node.
        public void DrawSubtreeNodes(Graphics gr)
        {
            // Draw this node.
            Draw(Center.X, Center.Y, gr, MyPen, BgBrush, FontBrush, MyFont);

            // Recursively make the child draw its subtree nodes.
            if (LeftNode != null)
                LeftNode.DrawSubtreeNodes(gr);
            if (RightNode != null)
                RightNode.DrawSubtreeNodes(gr);
        }

        private void Draw(float x, float y, Graphics gr, Pen pen, Brush bg_brush, Brush text_brush, Font font)
        {
            // Fill and draw an ellipse at our location.
            SizeF my_size = GetSize(gr, font);
            //my_size.Width = Math.Max(my_size.Width, my_size.Height);
            //my_size.Height = my_size.Width;
            RectangleF rect = new RectangleF(
                x - my_size.Width / 2,
                y - my_size.Height / 2,
                my_size.Width, my_size.Height);
            gr.FillEllipse(bg_brush, rect);
            gr.DrawEllipse(pen, rect);

            // Draw the text.
            using (StringFormat string_format = new StringFormat())
            {
                string_format.Alignment = StringAlignment.Center;
                string_format.LineAlignment = StringAlignment.Center;
                gr.DrawString(Text, font, text_brush, x, y, string_format);
            }
        }
        public SizeF GetSize(Graphics gr, Font font)
        {
            return gr.MeasureString(Text, font) + new SizeF(10, 10);
        }

        // Set the background color for this subtree.
        public void SetSubtreeBg(Brush brush)
        {
            BgBrush = brush;
            if (LeftNode != null) LeftNode.SetSubtreeBg(brush);
            if (RightNode != null) RightNode.SetSubtreeBg(brush);
        }
    }
}