// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());
int a1 = number / 10000;
int a2 = number / 1000 - a1*10;
int a4 = number / 10 - number / 100*10;
int a5 = number % 10;
if (number > 9999 && number < 100000)
{
    if (a1 == a5 && a2 == a4)
    {
        Console.WriteLine($"Число {number} является палиндромом.");
    }
    else
    {
        Console.WriteLine($"Число {number} не является палиндромом");
    }
}
else
{
    Console.WriteLine("Введите именно пятизначное число ");
}