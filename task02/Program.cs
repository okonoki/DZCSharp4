// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int N = Prompt("Введите число: ");

void SumFigure(int N)
{
    int n = 0;
    int sum = 0;
    while (N > 0)
    {
        n = N % 10;
        sum = sum + n;
        N = N / 10;
    }
    Console.Write(sum);
}

SumFigure(N);