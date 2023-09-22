//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


void FillArray(int n)
{
    if(n > 0)
    {
        System.Console.Write($"{n} ");
        FillArray(n -1);
    }
}

 System.Console.WriteLine("Введите натуральное число "); 
int n = Convert.ToInt32(Console.ReadLine()); 
FillArray(n);
