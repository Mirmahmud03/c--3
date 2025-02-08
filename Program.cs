// //1-chi amaliy vazifa
Console.Write("doirani radiusini kiriting:");
double radius = Convert.ToDouble(Console.ReadLine());

double p = 3.14159265358979;
double s = p * radius * radius;
double l = 2 * p * radius;

Console.WriteLine($" S = {s}");
Console.WriteLine($" L = {l}");


// // 2-amaliy vazifa 
Console.Write("summani kiritng:");
double qiymat = Convert.ToDouble(Console.ReadLine());
double kurs = 12400;
double convert = qiymat * kurs;
Console.WriteLine($"{convert} so'm");

//3-amaliy vazifa
Console.Write("yoshingizni kiriting:");
int x = int.Parse(Console.ReadLine());
int kunlar = (2025 - x) * 365;
Console.WriteLine($"siz shu vaqtgacha {kunlar} kun yahsagan ekansiz.");