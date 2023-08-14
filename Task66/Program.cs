// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое натуральное число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число");
int number2 = Convert.ToInt32(Console.ReadLine());


int sumNaturalNumbersRange = SumNaturalNumbersRange(number1, number2);
Console.WriteLine($"{sumNaturalNumbersRange}");


int SumNaturalNumbersRange(int n1, int n2, int sum = 0)
{
    if (n1 < 1 || n2 < 1)
    {
        Console.WriteLine("Одно или оба числа не натуральные");
    }

    else
    {
        if (n1 > n2)
        {
            while (n2 <= n1)
            {
                sum = sum + n2;
                n2++;
            }
        }

        else if (n1 < n2)
        {
            while (n1 <= n2)
            {
                sum = sum + n1;
                n1++;
            }
        }

        else 
        {
            sum = sum + n1;
        }
    }

    return sum;
}