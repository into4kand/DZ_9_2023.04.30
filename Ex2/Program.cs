// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int[] FirstDot = new int [3];
Console.WriteLine("Введите коррдинаты X, Y, Z первой точки ");
for (int i = 0; i < FirstDot.Length; i++)
{
    FirstDot[i] = Convert.ToInt32(Console.ReadLine());
}
int[] SecondDot = new int [3];
Console.WriteLine("Введите коррдинаты  X, Y, Z второй точки ");
for (int i = 0; i < SecondDot.Length; i++)
{
    SecondDot[i] = Convert.ToInt32(Console.ReadLine());
}
int a = 0;
for (int i = 0; i < SecondDot.Length; i++)
{
    a = a + (SecondDot[i] - FirstDot[i])*(SecondDot[i] - FirstDot[i]);
}
double S = Math.Sqrt(a);
Console.WriteLine($"Расстояние между двумя точками равно {S}");
