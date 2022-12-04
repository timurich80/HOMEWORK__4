/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */


Console.Clear();
System.Console.WriteLine("Введите число: ");
string a = Console.ReadLine();
int sum = 0;
// int b = Convert.ToInt32(a);
SumOfNumbers(a);

void SumOfNumbers (string variable)
{
    for (int i = 0; i < variable.Length; i++)
    {
        sum = sum + Convert.ToInt32(variable[i].ToString());
    }
    System.Console.WriteLine(sum);
}
