/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
// Console.WriteLine("Введите первое число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("\nПервое число: " + a + " Второе число:" + b + "\n");
// int max;
// if (a>b){
//     max = a;
// }
// else{
//     max = b;
// }
// Console.WriteLine("Наибольшее число " + max);

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("a = " + a + ", b = " + b);
int Max = 0;
if (a > b) {
    Max=a;
}
else {
    Max = b;
}
Console.WriteLine("Максимальное число " + Max);
