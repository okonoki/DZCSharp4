// // Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// // 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int Prompt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[] Input(int size)
{
    int[] array = new int[size];
    Console.Write("Введите через пробел числа, которые будут добавлены в массив: ");
    string[] input = Console.ReadLine()!.Split(' ');
    for (int i = 0; i < size; i++)
    {
        array[i] = int.Parse(input[i]);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

int sizeArray = Prompt("Введите длину массива: ");
int[] array = Input(sizeArray);
PrintArray(array);