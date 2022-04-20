double xa = 34;
double ya = 87;
double za = 15;
double xb = 48;
double yb = 12;
double zb = -79;
double A = Math.Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya)+(zb-za)*(zb-za));
Console.Write($"Расстояние между точками А и B = {Math.Round(A, 2)}");