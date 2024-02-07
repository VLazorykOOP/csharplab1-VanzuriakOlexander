static void task1()
{
    Console.WriteLine("Task1");
    Console.Write("p= ");
    string? str = Console.ReadLine();
    float p = 0;
    if (str != null) p = float.Parse(str);
    double s = Math.Pow(p / 3, 2) * Math.Sqrt(3) / 4;
    Console.WriteLine("S=" + s);
}

static void task2()
{
    Console.WriteLine("Task2");
    Console.Write("number= ");
    string? str = Console.ReadLine();
    float number = 0;
    if (str != null) number = int.Parse(str);
    if (number % 2 == 0)
    {
        Console.WriteLine("The number is even");
    }
    else
    {
        Console.WriteLine("The number is odd");
    }
}

static void task3()
{
    Console.WriteLine("Task3");
    Console.Write("Enter x=");
    string? str = Console.ReadLine();
    float x = 0;
    float y = 0;
    int r = 9;
    if (str != null) x = float.Parse(str);
    Console.Write("Enter y=");
    str = Console.ReadLine();
    if (str != null) y = float.Parse(str);
    if (Math.Pow(x, 2) + Math.Pow(y, 2) == Math.Pow(r, 2) && x >= 0)
    {
        Console.WriteLine("Your on line of circle");
    }
    else if (Math.Pow(x, 2) + Math.Pow(y, 2) < Math.Pow(r, 2) && x >= 0)
    {
        Console.WriteLine("Your inside the circle");
    }
    else
    {
        Console.WriteLine("You outside the circle");
    }
}

static void task4()
{
    Console.WriteLine("Task4");
    Console.Write("Enter day=");
    int day = 0;
    string? str = Console.ReadLine();
    if (str != null) day = int.Parse(str);
    int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
    if (daysInMonth-day >= 0) {
        Console.Write(daysInMonth-day + "days" + " to the end of this month ");
    } else {
        Console.Write("You enter the wrong day");
    }
}

Console.WriteLine("Lab 1 !");
task1();
task2();
task3();
task4();