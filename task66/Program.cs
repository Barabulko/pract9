// See https://aka.ms/new-console-template for more information
Console.WriteLine("task66");

/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int summNatural(int M, int N){
    if (M<N) {
        return M+summNatural(M+1, N);
    } else {
        return N;
    }
}

// Console.WriteLine(summNatural(1, 15));
// Console.WriteLine(summNatural(4, 8));

Console.Write("enter M = ");
int M = int.Parse(Console.ReadLine());
Console.Write("enter N = ");
int N = int.Parse(Console.ReadLine());

Console.WriteLine($"M={M}, N={N}. -> {summNatural(M, N)}");