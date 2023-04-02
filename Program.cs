namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree Problem !!!");

            BinarySearchTree<int> binaryTree = new BinarySearchTree<int>(56);
            Console.WriteLine("\n1.Create Binary Search Tree \n2.Size of Binary Tree \n3.Search Binary Tree");
            Console.WriteLine("Select the option from above");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Creating BST to insert and display node value");
                    binaryTree.Insert(30);
                    binaryTree.Insert(70);
                    binaryTree.Display();
                    break;
                case 2:
                    Console.WriteLine("Inserting more node and get size of binary tree ");
                    binaryTree.Insert(30);
                    binaryTree.Insert(70);
                    binaryTree.Insert(22);
                    binaryTree.Insert(44);
                    binaryTree.Insert(60);
                    binaryTree.Insert(95);
                    binaryTree.Insert(11);
                    binaryTree.Insert(65);
                    binaryTree.Insert(3);
                    binaryTree.Insert(16);
                    binaryTree.Insert(63);
                    binaryTree.Insert(67);
                    binaryTree.Display();
                    binaryTree.GetSize();
                    break;
                case 3:
                    binaryTree.Insert(30);
                    binaryTree.Insert(70);
                    binaryTree.Insert(22);
                    binaryTree.Insert(44);
                    binaryTree.Insert(60);
                    binaryTree.Insert(95);
                    binaryTree.Insert(11);
                    binaryTree.Insert(65);
                    binaryTree.Insert(3);
                    binaryTree.Insert(16);
                    binaryTree.Insert(63);
                    binaryTree.Insert(67);
                    Console.WriteLine("Searching node is present or not in binary tree");
                    bool result = binaryTree.IfExists(63, binaryTree);
                    break;
                default:
                    Console.WriteLine("Please enter the correct option");
                    break;
            }
        }
    }
}