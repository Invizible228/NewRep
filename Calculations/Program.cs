// See https://aka.ms/new-console-template for more information
Console.Write("Введите A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите B:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите цифру, что хотите сделать: 1 - '-', 2 - '+', 3 - '*', 4 - '/'");
int sw = Convert.ToInt32(Console.ReadLine());
switch (sw)
{
    //case 1:
    //    Console.WriteLine(a - b);
    //    break;
    //case 2: Console.WriteLine(a + b);
    //    break;
    case 3:
        Console.WriteLine(a * b);
        break;
        //case 4: Console.WriteLine(a / b);
        //    break;
}
