/*Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int Min=1;
int max=N;
int count = 0;
int n=0;
while (count<max-1)
{
    n=n+2;
Console.WriteLine(n);
count+=2;
}
