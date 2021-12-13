// See https://aka.ms/new-console-template for more information
//Console.WriteLine("************* Welcome To BST **************");
using BinarysearchTree;
Console.Write("Select Number:\n1)CreateBST\n2)ADDElements");
int option = Convert.ToInt32(Console.ReadLine());
BinaryTree<int> binaryTree = new BinaryTree<int>(56);
switch (option)
{
    case 1:
        binaryTree.Add(30);
        binaryTree.Add(70);
        binaryTree.Display();
        break;

    case 2:
        binaryTree.Add(30);
        binaryTree.Add(70);
        binaryTree.Add(22);
        binaryTree.Add(40);
        binaryTree.Add(60);
        binaryTree.Add(95);
        binaryTree.Add(11);
        binaryTree.Add(65);
        binaryTree.Add(3);
        binaryTree.Add(16);
        binaryTree.Add(63);
        binaryTree.Add(67);
        binaryTree.Display();
        break;

    default:
        Console.WriteLine("Invalid Option");
        break;
}