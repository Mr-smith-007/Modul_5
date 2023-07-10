using System;
class Programm
{
    //static string ShowColor(string username, int userage)
    //{
    //    Console.WriteLine($"{username}, {userage} лет \nНапишите свой любимый цвет на английском с маленькой буквы");
    //    var color = Console.ReadLine();

    //    switch (color)
    //    {
    //        case "red":
    //            Console.BackgroundColor = ConsoleColor.Red;
    //            Console.ForegroundColor = ConsoleColor.Black;

    //            Console.WriteLine("Your color is red!");
    //            break;

    //        case "green":
    //            Console.BackgroundColor = ConsoleColor.Green;
    //            Console.ForegroundColor = ConsoleColor.Black;

    //            Console.WriteLine("Your color is green!");
    //            break;
    //        case "cyan":
    //            Console.BackgroundColor = ConsoleColor.Cyan;
    //            Console.ForegroundColor = ConsoleColor.Black;

    //            Console.WriteLine("Your color is cyan!");
    //            break;
    //        default:
    //            Console.BackgroundColor = ConsoleColor.Yellow;
    //            Console.ForegroundColor = ConsoleColor.Red;

    //            Console.WriteLine("Your color is yellow!");
    //            break;
    //    }
    //    return color;
    //}

    static int[] GetArrayFromConsole(int num = 5)
    {
        int[] array = new int[num];
        Console.WriteLine("Введите элементы массива:");
        for(int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }

    static int[] SortArray(int[] array)
    {
        int t;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++ )
            {
                if (array[i] > array[j])
                {
                    t = array[j];
                    array[j] = array[i];
                    array[i] = t;
                }
            }
        }
        return array;
    }
    



    public static void Main(string[] args)
    {
        //var (name, age) = ("Евгения", 27);

        //Console.WriteLine("Мое имя: {0}", name);
        //Console.WriteLine("Мой возраст: {0}", age);

        //Console.Write("Введите имя: ");
        //name = Console.ReadLine();
        //Console.Write("Введите возрас с цифрами:");
        //age = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Ваше имя: {0}", name);
        //Console.WriteLine("Ваш возраст: {0}", age);

        //(string name, int age) anketa;

        //Console.Write("Введите имя: ");
        //anketa.name = Console.ReadLine();
        //Console.Write("Введите возраст с цифрами: ");
        //anketa.age = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Ваше имя: {0}", anketa.name);
        //Console.WriteLine("Ваш возраст: {0}", anketa.age);

        ////Console.ReadKey();

        //var favcolors = new string[3];

        //for (int i = 0; i < favcolors.Length; i++)
        //{
        //    favcolors[i] = ShowColor(anketa.name, anketa.age);
        //}

        int[] array = GetArrayFromConsole();
        SortArray(array);
        foreach (int x in array)
            Console.Write(x + " ");





    }
}