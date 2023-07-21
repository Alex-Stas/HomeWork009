/*
* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
* Выполнить с помощью рекурсии.
* N = 5 -> "5, 4, 3, 2, 1"
* N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"string NumbersRec(int a, int b)
*/

// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }

// string NumbersRec(int n)
// {
//     if (n >= 1) return $"{n} " + NumbersRec(n - 1);
//     else return String.Empty;
// }

// int start = InputNum("Введите начальное число последовательности: ");
// Console.WriteLine(NumbersRec(start));

// ***********************************************************************************************
/*
* Задача 66: Задайте значения M и N. 
* Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
* M = 1; N = 15 -> 120
* M = 4; N = 8. -> 30
*/

// int InputNum(string message)
// {
//     Console.Write(message);
//     return int.Parse(Console.ReadLine()!);
// }


// int SumRec(int start, int finish)
// {

//     if (start == finish) return start;
//     else return start + SumRec(start + 1, finish);
// }

// int start = InputNum("Введите начальное число последовательности: ");
// int finish = InputNum("Введите конечное число последовательности: ");

// if (start > finish)
// {
//     int temp = start;
//     start = finish;
//     finish = temp;
// }

// Console.WriteLine(SumRec(start, finish));

// ***********************************************************************************************

/*
* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
* Даны два неотрицательных числа m и n.
* m = 2, n = 3 -> A(m,n) = 9
* m = 3, n = 2 -> A(m,n) = 29
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akkerman(m - 1, 1);
    return Akkerman(m - 1, Akkerman(m, n - 1));
}

int m = InputNum("Введите число N функции Аккермана: ");
int n = InputNum("Введите число M функции Аккермана: ");
Console.WriteLine($"Функция Аккермана для m = {m} и n = {n} равна: {Akkerman(m, n)} ");
