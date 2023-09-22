//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

string PrintNumbers(int m, int n) 
{ 
    if (n < m) 
        return ""; 
    return PrintNumbers(m, n - 1) + $"{n} "; 
} 
 



 
System.Console.WriteLine("Введите нижнюю границу M"); 
int min = Convert.ToInt32(Console.ReadLine()); 
System.Console.WriteLine("Введите верхнюю границу N"); 
int max = Convert.ToInt32(Console.ReadLine()); 
PrintNumbers(min, max);
