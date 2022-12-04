/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
 */

Console.Clear();
System.Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
int result = 1;
Exponentiation(a, b);


void Exponentiation(int A, int B)

{
    for (int i = 0; i < B; i++)
    {
        result = result * result;

    }
    System.Console.WriteLine(result);
}
