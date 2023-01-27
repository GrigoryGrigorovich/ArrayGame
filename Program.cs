using System;

public class Program
{
    public static void Main()
    {
        int[] array1 = new int[10]; 
        int[] array2 = new int[10];

        // Заполняем первый массив.
        for (int i = 0; i < array1.Length; i++)
            array1[i] = i + 1;

        // Заполняем второй массив.
        for (int i = 0; i < array2.Length; i++)
            array2[i] = (i + 1) * 2;

        // Выводим элементы суммы элементов двух массивов.
        for (int i = 0; i < 10; i++)
            Console.WriteLine(array1[i] + array2[i]);
        Console.ReadKey();
    }
}