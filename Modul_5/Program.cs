class MainClass
{
    public static void Main(string[] args)
    {
        (string Name, string[] Dishes) User;
        Console.Write("Введите имя пользователя: ");
        User.Name = Console.ReadLine();
        User.Dishes = new string[5];
        Console.WriteLine("Введите 5 любимых блюд:");
        foreach (string x in User.Dishes)
        {
            Console.ReadLine();
        }


    }
}