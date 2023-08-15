// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите первое неотрицательное число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе неотрицательное число");
int number2 = Convert.ToInt32(Console.ReadLine());

int ack = Ack(number1, number2);
Console.WriteLine(ack);

int Ack(int n1, int n2)
{
    if (n1 < 0 || n2 < 0)
    {
        Console.WriteLine("Одно или оба числа отрицательные");
        return 0;
    }

    if (n1 == 0) return (n2 + 1);
    if (n2 == 0) return Ack(n1 - 1, 1);
    return Ack(n1 - 1, Ack(n1, n2 - 1));
}
