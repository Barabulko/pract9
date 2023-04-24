// See https://aka.ms/new-console-template for more information
Console.WriteLine("task68");

/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int Ackerman(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    } 
    else if (N == 0)
    {
        return Ackerman(M - 1, 1);
    } 
    else
    {
        return Ackerman(M - 1, Ackerman(M, N - 1));
    }
}

Console.Write("enter M = ");
int M = int.Parse(Console.ReadLine());
Console.Write("enter N = ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine($"M={M}, N={N}. -> {Ackerman(M, N)}");