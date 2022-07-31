/*
Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8""

*/

string AllNaturalNumbersFromMtoN(int m, int n)
{
    if (n == m)
        return $"{m}";
    else
        return $"{AllNaturalNumbersFromMtoN(m, (n - 1))}, {n} ";
}

Console.WriteLine("Enter number m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("And enter number n");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(AllNaturalNumbersFromMtoN(m, n));
