using System;

/// <summary>
/// Demo chạy chương trình
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        // Chọn Factory tùy theo hệ điều hành
        IGUIFactory factory;

        Console.Write("Chọn OS (win/mac): ");
        string os = Console.ReadLine();

        if (os == "win")
            factory = new WinFactory();
        else
            factory = new MacFactory();

        // Client chỉ làm việc qua Abstract Factory
        Application app = new Application(factory);
        app.RenderUI();

        Console.ReadKey();
    }
}
