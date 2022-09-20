/* Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.Clear();

Console.Write ("Введите число: ");

int a = 1;
int b = Convert.ToInt32(Console.ReadLine());

b=Math.Abs(b);

while (a<=b)
{
    if (b%2 == 0)
    {
        Console.WriteLine (b + ",");
    }
    b=b-1;
}
Console.WriteLine();
