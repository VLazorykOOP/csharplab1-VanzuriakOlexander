static void task1()
{
    Console.WriteLine("Task1");
    Console.Write("p= ");
    string? str = Console.ReadLine();
    float p = 0;
    if (str != null) p = float.Parse(str);
    double s = Math.Pow(p/3, 2)*Math.Sqrt(3)/4;
    Console.WriteLine("S=" + s);
}

static void task2()
{
    Console.WriteLine("Task2");
    Console.Write("number= ");
    string? str = Console.ReadLine();
    float number = 0;
    if (str != null) number = float.Parse(str);
    if (number % 2 == 0) {
        Console.WriteLine("The number is even");
    } else {
        Console.WriteLine("The number is odd");
    }
}



Console.WriteLine("Lab 1 !");
task1();
task2();