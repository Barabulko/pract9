// See https://aka.ms/new-console-template for more information
Console.WriteLine("task64");

/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

string printNto1(int N){
    string result = "";
    if (N>1) {
        return ($"{N}, " + printNto1(N-1));
    } else {
        return "1";
    }
}

Console.WriteLine(printNto1(5));
Console.WriteLine(printNto1(8));