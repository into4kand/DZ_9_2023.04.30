// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
// Console.WriteLine("Введите число ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N > 0)
// {
//     Console.WriteLine("Квадраты всех чисел от 1 до N");
// }
// else
// {
//     Console.WriteLine("Введите число больше 0");
// }
// for (int i = 1; i <= N; i++)
// {
//     int Q = i*i;
//     Console.Write($"{Q} ");
// }
void Poisk(int number)
{
    int count = number;
    int position = 1;
    while (position <= count)
    {
        int Q = position*position*position;
        Console.Write($"{Q} ");
        position++;
    }
}
Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
if (N > 0)
{
    Console.WriteLine("Кубы всех чисел от 1 до N");
    Poisk(N);
}
else
{
    Console.WriteLine("Введите число больше 0");
}