//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
int N = 10, a = 0;
Console.Write($"{N} -> ");
while (a < N)
{
    Console.Write($"{a * a * a}, ");
    a++;
}
Console.Write($"{a * a * a}.");