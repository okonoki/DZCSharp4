// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double Power(int powerBase, int exponent)
{
    return Math.Pow(powerBase, exponent);
}

// int Power(int powerBase, int exponent)
// {
//     int power = 1;
//     for (int i = 0; i < exponent; i++)
//     {
//         power *= powerBase;
//     }
//     return power;
// }

bool ValidateExponent(int exponent)
{
    if (exponent < 0)
    {
        Console.WriteLine("Показатель степени не должен быть меньше нуля!");
        return false;
    }
    return true;
}


int powerBase = Prompt("Введите основание: ");
int exponent = Prompt("Введите показатель степени: ");

if (ValidateExponent (exponent))
{
 Console.Write($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
}