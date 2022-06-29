/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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
            if (number <= 0)
                Console.WriteLine("Задайте число больше 0");
            else
                return number;
        }
    }
}

int SumElements(int m, int n)
{
    if (n == m) return m;
    else return n + SumElements(m, n - 1);
}


int m = GetNumber("Введите натуральное число M");
int n = GetNumber("Введите натуральное число N");
if (n > m)
{
    Console.WriteLine($"Cумма натуральных элементов в промежутке от {m} до {n} равна:{SumElements(m, n)}");
}
else
{
    Console.WriteLine($"Cумма натуральных элементов в промежутке от {n} до {m} равна:{SumElements(n, m)}");
}


