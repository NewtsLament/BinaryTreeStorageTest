// See https://aka.ms/new-console-template for more information
using BinaryTreeStorageTest;
using GeneralizedBinaryTree;

Console.WriteLine("Enter a newline separated list of strings.");

//bool running = true;
//List<string> list = new List<string>();
//while (running)
//{
//    string input = Console.ReadLine();
//    if (input == "")
//        running = false;
//    list.Add(input);
//}

List<string> list = new List<string>();
list.Add("arount");
list.Add("flornt");
list.Add("tromptont");
list.Add("entorumfff");
list.Add("ipnist");


IBinaryNode<uint> tree = new BuildIntegerIndexedStringTree().SetArray(list.ToArray()).Build();

Console.WriteLine("HALT");
Console.ReadLine();