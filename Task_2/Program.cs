/*
Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

void AllNaturalNumbersFromMtoN(int m, int n, int result)
{
    if (n == m) Console.WriteLine(result + m);
    else
    {
        result = result + n;
        AllNaturalNumbersFromMtoN(m, n - 1, result);
    }
}

int result = 0;
Console.WriteLine("Enter number m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("And enter number n");
int n = int.Parse(Console.ReadLine());

AllNaturalNumbersFromMtoN(m, n, result);