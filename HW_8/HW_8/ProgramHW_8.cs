namespace HW_8
{
    internal class Program
    {
        public class Node
        {
            public string Name { get; set; }
            public int Salary { get; set; }
            public Node LeftDaughter { get; set; }
            public Node RightDaughter { get; set; }

        }

        static void Main()
        {
            static void AddNode(Node root, Node getNode)
            {
                if (getNode.Salary < root.Salary)
                {
                    if (root.LeftDaughter == null) root.LeftDaughter = getNode;
                    else AddNode(root.LeftDaughter, getNode);
                }
                else
                {
                    if (root.RightDaughter == null) root.RightDaughter = getNode;
                    else AddNode(root.RightDaughter, getNode);
                }
             }
            static void GetAscendingList(Node startRoot)
            {
                if (startRoot.LeftDaughter != null)
                {
                    GetAscendingList(startRoot.LeftDaughter);
                }
                Console.Write(startRoot.Name + " ");
                Console.WriteLine(startRoot.Salary);
                if (startRoot.RightDaughter != null)
                {
                    GetAscendingList(startRoot.RightDaughter);
                }
            }
            Node root = null;
            while (true)
            {
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();
                if (name == "") break;
                Console.WriteLine("Enter salary:");
                int salary = Int32.Parse(Console.ReadLine());

                Node nodeToAdd = new Node
                {
                    Name = name,
                    Salary = salary
                };
                if (root == null)
                {
                    root = nodeToAdd;
                }
                else
                {
                    AddNode(root, nodeToAdd);
                }
            }
            if (root == null) Console.WriteLine("Tree is empty");
            else GetAscendingList(root);

        }
    }
}