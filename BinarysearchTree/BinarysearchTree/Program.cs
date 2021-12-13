// See https://aka.ms/new-console-template for more information
//Console.WriteLine("************* Welcome To BST **************");
using BinarysearchTree;
Console.Write("Select Number:\n1)CreateBST");
int option = Convert.ToInt32(Console.ReadLine());

switch (option)
{
    case 1:
        BinaryTree<int> binarySearch = new BinaryTree<int>(56);
        binarySearch.Add(30);
        binarySearch.Add(70);
        binarySearch.Display();
        break;
}