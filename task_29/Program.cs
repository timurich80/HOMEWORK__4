/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */


int[] arr = new int[8];
FillArray(arr);
PrintArray(arr);



int [] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       System.Console.Write($"{array[i]} ");
    }
}
System.Console.WriteLine();
System.Console.Write(String.Join(",", arr));