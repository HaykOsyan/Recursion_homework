// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void Main()
{
    Console.WriteLine("type number M");
    int numberM = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("type number N");
    int numberN = Convert.ToInt32(Console.ReadLine());

    if (numberM < numberN - 1)
    {
        NatNumbers(numberM, numberN);
    }
    else
    {
        Console.WriteLine("There are no nat numbers between M and N");
    }

}
int NatNumbers(int M, int N)
{
    int nextNumber = M + 1;
    if (nextNumber + 1 > N)
    {
        return nextNumber;
    }
    System.Console.WriteLine(nextNumber + " ");
    return NatNumbers(nextNumber, N);
}
Main();