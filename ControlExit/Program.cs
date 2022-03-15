class program
{
    static void Main(string[] args)
    {
        string exitCommand;
        
        Console.Write("Добро пожаловать в наш бар!");
        exitCommand = Console.ReadLine();

        while (exitCommand != "exit")
        {
           Console.WriteLine("Бухаем!");
           exitCommand = Console.ReadLine();
            if (exitCommand == "exit")
            {
                Console.WriteLine("Заходите еще!");
            }
        }
    }
}