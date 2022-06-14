using DesignPatterns._1_Singleton;
using DesignPatterns._2_Prototype;

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
            case "2": RunPrototype();
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
    private static void RunPrototype()
    {
        var concretePrototype1 = new ConcretePrototype{ field1 = "Test" };
        var concretePrototype2 = concretePrototype1.Clone();
        var concretePrototype3 = concretePrototype1;
        Console.WriteLine(
            "First one: "+concretePrototype1.GetHashCode()
            + "\nCopy of first one:" + concretePrototype2.GetHashCode()
            + "\nReference to first one: " + concretePrototype3.GetHashCode());
    }
}