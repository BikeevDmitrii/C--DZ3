//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double xa = 34;
double ya = 87;
double za = -15;
double xb = 18;
double yb = 125;
double zb = 47;
double A = Math.Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya)+(zb-za)*(zb-za));
Console.Write($"Расстояние между точками А и B = {Math.Round(A, 2)}");