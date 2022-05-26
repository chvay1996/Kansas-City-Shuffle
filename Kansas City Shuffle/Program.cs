using System;

namespace Kansas_City_Shuffle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите длину массива: ");
            int lengthArray = int.Parse(Console.ReadLine());
            int[] arrayShuffle = new int[lengthArray];
            Random rand = new Random();
            Console.WriteLine("Массив");
            int maxNamberRand = 10;

            for (int i = 0; i < lengthArray; i++)
            {
                arrayShuffle[i] = rand.Next(maxNamberRand);
                Console.Write($"{arrayShuffle[i]} ");
            }

            Console.WriteLine("\nНовый массив");

            Shuffle(arrayShuffle, lengthArray);

            for (int i = 0; i < lengthArray; i++)
            {
                Console.Write($"{arrayShuffle[i]} ");
            }
        }

        static void Shuffle(int[] array, int length)
        {
            int maxNamberRand = 7;
            Random rand = new Random();

            for (int i = rand.Next(maxNamberRand); i < length; i++)
            {
                int intRand = rand.Next(length);
                int intRand2 = rand.Next(length);
                int namber = array[intRand];
                array[intRand] = array[intRand2];
                array[intRand2] = namber;
            }
        }
    }
}
/*Задача:
Реализуйте метод Shuffle, который перемешивает элементы массива в случайном порядке.*/