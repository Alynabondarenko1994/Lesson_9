/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29
*/


int GetNumber(string message)
{
    while (true)
    {
        Console.WriteLine(message);
        string num = Console.ReadLine();
        if (int.TryParse(num, out int number) == false)
            Console.WriteLine("Введено ненатуральное число");
        else
        {
            if (number < 0)
                Console.WriteLine("Задайте число больше 0");
            else
                return number;
        }
    }
}

int FunctionAckerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return FunctionAckerman(m - 1, 1);
    else return FunctionAckerman(m - 1, FunctionAckerman(m, n - 1));
}

int m = GetNumber("Введите неотрицательное число m");
int n = GetNumber("Введите неотрицательное число n");
Console.WriteLine($"Функции Аккермана А({m},{n})={FunctionAckerman(m, n)}");


