//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akkerman(int M, int N)
{
    if (M ==0)
    {
        return N+1;
    }
    else if( M > 0 && N == 0)
    {
        return Akkerman(M - 1, 1);
    }
    else
    {
        return Akkerman(M-1, Akkerman(M, N-1));
    }
}



Console.WriteLine("Введите число M"); 
int M = Convert.ToInt32(Console.ReadLine()); 
System.Console.WriteLine("Введите число N"); 
int N = Convert.ToInt32(Console.ReadLine()); 
System.Console.WriteLine(Akkerman(M,N));

