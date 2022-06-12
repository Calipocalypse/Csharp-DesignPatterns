using DesignPatterns._1_Singleton;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter number which corresponds with design pattern you want to run");
        string number = Console.ReadLine();
        Console.Clear();
        switch (number)
        {
            case "1": RunSingleton();
                break;
            default: Console.WriteLine("Not found");
                break;
        }
        Console.WriteLine("");
        Main();
    }

    private static void RunSingleton()
    {
        Singleton singleton1 = Singleton.GetInstance();
        Singleton singleton2 = Singleton.GetInstance();

        if (singleton1 == singleton2) Console.WriteLine("Singleton runs only one instance");
        else Console.WriteLine("Something gone wrong with singleton code");
    }
}