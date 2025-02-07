Console.Write("doirani radiusini kiriting:");
double radius = Convert.ToDouble(Console.ReadLine());

double p = 3.14159265358979;
double s = p * radius * radius;
double l = 2 * p * radius;

Console.WriteLine($" S = {s}");
Console.WriteLine($" L = {l}");