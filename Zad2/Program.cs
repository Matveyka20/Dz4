//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int FillArray(int M, int N)
{
    int result = 0;
    N = (1 + N) * N / 2;
    M = ((M-1) + 1) * (M-1) / 2;
    result = M - N;
    result= result * -1;
    return result;
}
 
System.Console.WriteLine("Введите нижнюю границу M"); 
int M = Convert.ToInt32(Console.ReadLine()); 
System.Console.WriteLine("Введите верхнюю границу N"); 
int N = Convert.ToInt32(Console.ReadLine()); 
System.Console.WriteLine(FillArray(M,N));

