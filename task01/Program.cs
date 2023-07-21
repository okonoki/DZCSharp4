// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int A = Prompt("Введите число A: ");
int B = Prompt("Введите число B: ");

double ToThePowerOfB(int A, int B)
{
    double result = Math.Pow(A, B);
    return result;
}

double result = ToThePowerOfB(A, B);
Console.Write($"{A}, {B} -> {result}");