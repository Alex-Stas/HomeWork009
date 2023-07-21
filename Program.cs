/*
* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
* Выполнить с помощью рекурсии.
* N = 5 -> "5, 4, 3, 2, 1"
* N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"string NumbersRec(int a, int b)
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

string NumbersRec(int n)
{
    if (n >= 1) return $"{n} " + NumbersRec(n - 1);
    else return String.Empty;
}

int start = InputNum("Введите начальное число последовательности: ");
Console.WriteLine(NumbersRec(start));
