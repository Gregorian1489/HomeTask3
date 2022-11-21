Console.WriteLine("Введите координату x первой точки:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки:");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки:");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x второй точки:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z третьей точки:");
int z1 = Convert.ToInt32(Console.ReadLine());
double result;

result =Math.Round(Math.Sqrt(Math.Pow(x1-x, 2) + Math.Pow(y1 - y, 2)+Math.Pow(z1 - z, 2)),2);

Console.WriteLine($"Длина отрезка = {result}");