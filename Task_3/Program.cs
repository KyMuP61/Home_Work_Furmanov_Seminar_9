/*
 Напишите программу вычисления функции Аккермана 
 с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29
*/


int AccermanMethod(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if ((n > 0) && (m == 0))
    {
        return AccermanMethod(n - 1, 1);
    }
    else if ((n > 0) && (m > 0))
    {
        return AccermanMethod(n - 1, AccermanMethod(n, m - 1));
    }
    else
        return m + 1;
}


Console.WriteLine(AccermanMethod(3, 2));


