// Задача 69: Напишите программу, которая на вход принимает 2 числа A и B, и
// возводит число A в целую степень B с помощью рекурсии.
//     A = 3; B = 5 —> 243 (3^5)
//     A = 2; B = 3 —> 8   (2^3)

Console.WriteLine("Введите натуральное число A: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int PowDigits(int num1, int num2)
{
    if (num2 == 0) return 1;
    return num1 * PowDigits(num1, num2 - 1);
}

Console.WriteLine($"A = {number1}; B = {number2} —> {PowDigits(number1, number2)}");