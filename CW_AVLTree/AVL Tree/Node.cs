namespace AVL_Tree
{
    public class Node
    {
        public int key, height;
        public Node left, right;
        public string idCircle;
        public string idLine;

        public Node(int _key,string _idCircle)
        {
            key = _key;
            idCircle = _idCircle;
            height = 1;

        }
    }


}
