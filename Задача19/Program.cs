//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14531 -> нет
//12821 -> да
//23432 -> да

void Palindrom(int n)
{
    if ((n / 10000 == n % 10) && ((n / 1000) % 10 == (n / 10) % 10))
    {
        Console.Write($"да");
    }
    else
    {
        Console.Write($"нет");
    }
}

Console.Clear();
Console.WriteLine("Введите пятизначное число");
int N = int.Parse(Console.ReadLine()!);
Palindrom(N);
