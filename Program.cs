// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


int[] ParArray(int numb)
{
    int[] array = {1,5,6,9,1,4,2,3};
    for (int i = 0; i < array.Length; i++)
    {
        // array[i] = new Random().Next(min, max);
        Console.Write($"{array[i] } ");
    }
    return array;
}


int [] FindPar(int[] array)
{
    // int numb = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        // numb = array[i] * array[(array.Length / 2 - 1) - i];
        Console.Write($"{array[i] * array[(array.Length / 2 - 1) - i]}");
    }
    return array;
}
// int size = 10;
// int min = -5;
// int max = 12;
// int[] array = ParArray(numb);
FindPar(array);
ParArray(numb);


// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76


// int[] DouArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max);

//         Console.Write($"{array[i]}, ");
//     }
//     return array;
// }

// int FindMmax(int[] array)
// {
//     Console.WriteLine("Укажите максимальное число массива: ");
//     int max = Convert.ToInt32(Console.ReadLine());
//     int mmax = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > mmax)
//         {
//             mmax = array[i];
//         }
//     }
//     return mmax;
// }

// int FindMmin(int[] array)
// {
//     Console.WriteLine("Укажите минимальное число массива: ");
//     int min = Convert.ToInt32(Console.ReadLine());
//     int mmin = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < mmin)
//         {
//             mmin = array[i];
//         }
//     }
//     return mmin;
// }

// int size = 5;
// int min = -1;
// int max = -100;
// int[] array = DouArray(size, min, max);
// int mmax = FindMmax(array);
// int mmin = FindMmin(array);
// Console.WriteLine($"Разница между максимальным {mmax} и минимальным {mmin} элементами массива составляет {mmax-mmin}   ");
