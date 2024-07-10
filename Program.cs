// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// void Main()
// {
//     Console.WriteLine("type number M");
//     int numberM = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("type number N");
//     int numberN = Convert.ToInt32(Console.ReadLine());

//     if (numberM < numberN - 1)
//     {
//         NatNumbers(numberM, numberN);
//     }
//     else
//     {
//         Console.WriteLine("There are no nat numbers between M and N");
//     }

// }
// int NatNumbers(int M, int N)
// {
//     int nextNumber = M + 1;
//     if (nextNumber + 1 > N)
//     {
//         return nextNumber;
//     }
//     System.Console.WriteLine(nextNumber + " ");
//     return NatNumbers(nextNumber, N);
// }
// Main();

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// void Main()
// {
//     Console.WriteLine("type number m");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("type number n");
//     int n = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine($"Akerman number for {m} and {n} is {Akerman(m, n)})");
// }

// int Akerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (m > 0 && n == 0)
//     {
//         return Akerman(m - 1, 1);
//     }
//     else
//     {
//         return Akerman(m - 1, Akerman(m, n - 1));
//     }
// }

// Main();

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void Main()
{
    Console.WriteLine("type size of array");
    int arraySize = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("type min for random numbers");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("type max for random numbers");
    int max = Convert.ToInt32(Console.ReadLine());
    int[] array = CreateArray(arraySize, min, max);
    PrintArray(array);
    System.Console.WriteLine();
    ReverseArray(array);
}

Random rand = new Random();
int randomNumber(int min, int max)
{
    return rand.Next(min, max);
}

int[] CreateArray(int arraySize, int min, int max)
{
    int[] array = new int[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        array[i] = randomNumber(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    int arrLength = array.Length;
    if (arrLength < 1)
    {
        return;
    }
    System.Console.Write(array[0] + " ");
    PrintArray(array[1..]);
}

void ReverseArray(int[] array)
{
    int arrLength = array.Length;
    if (arrLength < 1)
    {
        return;
    }
    System.Console.Write(array[arrLength - 1] + " ");
    ReverseArray(array[..(arrLength - 1)]);
}

Main();