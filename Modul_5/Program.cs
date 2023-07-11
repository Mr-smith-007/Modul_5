using Microsoft.VisualBasic;
using System;
using System.Reflection;

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
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }

    static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc)
    {
        sorteddesc = SortArrayDesc(in array);
        sortedasc = SortArrayAsc(in array);
    }


    static int[] SortArrayDesc(in int[] array)
    {
        int[] array1 = new int[array.Length];
        Array.Copy(array, 0, array1, 0, array.Length);
        int t;
        for (int i = 0; i < array1.Length; i++)
        {
            for (int j = i + 1; j < array1.Length; j++)
            {
                if ((array1[i] < array1[j]))
                {
                    t = array1[i];
                    array1[i] = array1[j];
                    array1[j] = t;
                }
            }
        }
        return array1;
    }



    static int[] SortArrayAsc(in int[] array)
    {
        int[] array2 = new int[array.Length];
        Array.Copy(array, 0, array2, 0, array.Length);
        int t;
        for (int i = 0; i < array2.Length; i++)
        {
            for (int j = i + 1; j < array2.Length; j++)
            {
                if (array2[i] > array2[j])
                {
                    t = array2[i];
                    array2[i] = array2[j];
                    array2[j] = t;
                }
            }
        }
        return array2;
    }



    //static void ShowArray(int[] array, bool sort = false)
    //{
    //    if (sort)
    //    {
    //        SortArray(array);
    //    }
    //    foreach (int x in array)
    //    {
    //        Console.Write(x + " ");
    //    }
    //}

    //static void ChangeName(ref string name)
    //{
    //    Console.WriteLine("Введите имя");
    //    name = Console.ReadLine();

    //}


    static void Echo(string phrase, int deep)
    {
        var modif = phrase;
        if (modif.Length > 2)
        {
            modif = modif.Remove(0, 2);
        }
        Console.WriteLine("... " + modif);
        if (deep > 1)
        {
            Echo(modif, deep - 1);
        }
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



        //string somename = "Алексей";
        //ChangeName(ref somename);
        //Console.WriteLine(somename);



        //int[] array = GetArrayFromConsole(10);
        //SortArray(in array, out var sorteddesc, out var sortedask);

        //ShowArray(array, true);

        //int[] sortedarray = SortArray(array);
        //foreach (int x in sortedarray)
        //    Console.Write(x + " ");


        Console.WriteLine("Напишите что-то");
        var str = Console.ReadLine();
        Console.WriteLine("Укажите глубину эха");
        var deep = int.Parse(Console.ReadLine());
        Echo(str, deep);
        Console.ReadKey();
    }


}