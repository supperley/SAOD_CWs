using System.Drawing;

namespace BinaryTree
{
    public class BinaryTree
    {
        private TreeNode root;
        public TreeNode Root
        {
            get { return root; }
        }


        //O(Log n)
        public TreeNode Find(int data)
        {
            //if the root is not null then we call the find method on the root
            if (root != null)
            {
                // call node method Find
                return root.Find(data);
            }
            else
            {//the root is null so we return null, nothing to find
                return null;
            }
        }

        //O(Log n)
        public TreeNode FindRecursive(int data)
        {
            //if the root is not null then we call the recursive find method on the root
            if (root != null)
            {
                //call Node Method FindRecursive
                return root.FindRecursive(data);
            }
            else
            {//the root is null so we return null, nothing to find
                return null;
            }

        }

        //O(Log n)
        public void Insert(int data)
        {
            //if the root is not null then we call the Insert method on the root node
            if (root != null)
            {
                root.Insert(data);
            }
            else
            {//if the root is null then we set the root to be a new node based on the data passed in
                root = new TreeNode(data);
            }
        }

        //Tree Traversal 
        //Preorder
        //Go to the Root then the left then the right recursively
        public void PreorderTraversal()
        {
            if (root != null)
                root.PreOrderTraversal();
        }

        public void DrawTree(Graphics gr)
        {
            // Draw the links.
            root.DrawSubtreeLinks(gr);

            // Draw the nodes.
            root.DrawSubtreeNodes(gr);
        }

        public void Calculate(Graphics gr, ref float xmin, ref float ymin)
        {
            //if the root is not null then we call the recursive find method on the root
            if (root != null)
            {
                //call Node Method FindRecursive
                root.Calculate(gr, ref xmin, ref ymin);
            }
        }

        public void SetSubtreeBg(Brush brush)
        {
            //if the root is not null then we call the recursive find method on the root
            if (root != null)
            {
                //call Node Method FindRecursive
                root.SetSubtreeBg(brush);
            }
        }
    }
}
