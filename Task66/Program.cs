// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Введите первое натуральное число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число");
int number2 = Convert.ToInt32(Console.ReadLine());


int sumNaturalNumbersRange = SumNaturalNumbersRange(number1, number2);
Console.WriteLine(sumNaturalNumbersRange);


int SumNaturalNumbersRange(int n1, int n2)
{
    if (n1 < 0 || n2 < 0)
    {
        Console.WriteLine("Одно или оба числа не натуральные");
        return 0;
    }

    else
    {

        if (n1 > n2)
        {
            if (n1 < n2) return 0;
            return n1 + SumNaturalNumbersRange(n1 - 1, n2);
        }



        else
        {
            if (n1 < n2)
            {
                if (n2 < n1) return 0;
                return n2 + SumNaturalNumbersRange(n2 - 1, n1);

            }
        }
    }
    return n1;
}