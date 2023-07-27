// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//     m = 2, n = 3 -> A(m,n) = 9
//     m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите 1-е число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"A({num1},{num2}) = {Ack(num1, num2)}");

int Ack(int m, int n)
{
    if (m == 0) return n+1;
    else if (n == 0) return Ack(m-1, 1);
    else return Ack(m-1, Ack(m, n-1));
}