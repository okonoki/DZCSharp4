// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int SumFigure(int N)
{
    int sum = 0;
    while (N > 0)
    {
        sum += N % 10;
        N = N / 10;
    }
    return sum;
}

int N = Prompt("Введите число: ");
Console.Write($"Сумма всех цифр в числе {N} равна {SumFigure(N)}");