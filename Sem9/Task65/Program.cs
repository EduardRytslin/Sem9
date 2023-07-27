// Задача 65: Задайте значения M и N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от M до N.
//     M = 1; N = 5 —> "1, 2, 3, 4, 5"
//     M = 4; N = 8 —> "4, 5, 6, 7, 8"

Console.WriteLine("Введите 1-е натуральное число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е натуральное число");
int number2 = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number1, number2);

void NaturalNumbers(int num1, int num2) // 5
{
    if (num1 < num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbers(num1 + 1, num2);
    }
    else if (num1 > num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbers(num1 - 1, num2);
    }
    else
    {
        Console.Write($"{num1} ");
    }
}

void NaturalNumbers2(int num1, int num2) // 5
{
    if (num1 < num2)
    {
        NaturalNumbers2(num1, num2 - 1);
        Console.Write($"{num2} ");
    }
    else if (num1 > num2)
    {
        NaturalNumbers2(num1, num2 + 1);
        Console.Write($"{num2} ");
    }
    else
    {
        Console.Write($"{num2} ");
    }
}