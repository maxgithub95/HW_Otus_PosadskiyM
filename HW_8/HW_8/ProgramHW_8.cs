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
        static void EmployeeRequest(Node root)
        {
            Console.WriteLine("Enter salary to search for an employee:");
            int DesiredSalary = Int32.Parse(Console.ReadLine());
            Console.WriteLine(GetEmployee(DesiredSalary, root));
        }
        static string GetEmployee(int salary, Node startRoot)
        {
            if (salary == startRoot.Salary) return startRoot.Name;
            if ((salary < startRoot.Salary) && (startRoot.LeftDaughter != null)) return GetEmployee(salary, startRoot.LeftDaughter);
            if ((salary > startRoot.Salary) && (startRoot.RightDaughter != null)) return GetEmployee(salary, startRoot.RightDaughter);
            return "Такой сотрудник не найден";
        }
        static void TheEnd(Node root)
        {
            Console.WriteLine("Write 0, if you want to repeat data filling/nWrite 1, if you want to find a new employee/nWrite stop for finish program");
            string end = Console.ReadLine();
            switch (end)
            {
                case "0":
                    {
                        Main();
                        break;
                    }
                case "1":
                    {
                        EmployeeRequest(root);
                        break;
                    }
                case "stop":
                    {
                        Console.WriteLine("See you later!");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter right instruction");
                        TheEnd(root);
                        break;
                    }
            }
        }
        static void DataFilling(ref Node root)
        {
            Console.WriteLine("We start to fill data! To stop the process entry empty string");
            int n = 1;
            while (true)
            {
                Console.WriteLine($"Enter name{n}:");
                string name = Console.ReadLine();
                if (name == "") break;
                Console.WriteLine($"Enter salary{n}:");
                bool success = int.TryParse(Console.ReadLine(), out int salary);
                while (!success)
                {
                    Console.WriteLine("Enter salary as an integer:");
                    success = int.TryParse(Console.ReadLine(), out salary);
                }
                n++;
                Node nodeToAdd = new Node
                {
                    Name = name,
                    Salary = salary
                };
                if (root == null)
                {
                    root = nodeToAdd;
                    Console.WriteLine("Add first root");
                }
                else
                {
                    AddNode(root, nodeToAdd);
                }
            }
        }
        static void Main()
        {
            Node RootNode = null;
            //Хотел бы узнать, почему функция "DataFilling" работает только, если отправлять туда ссылку на узел дерева (иначе не происходит заполнения дерева в теле "Main"), 
            //а, например, в функцию "AddNode" можно отправлять просто сам узел и все работает.
            DataFilling(ref RootNode);
            while (RootNode == null)
            {
                Console.WriteLine("I don't have data. Please repeat data filling:");
                DataFilling(ref RootNode);
            }
            GetAscendingList(RootNode);
            EmployeeRequest(RootNode);
            TheEnd(RootNode);

        }
    }
}