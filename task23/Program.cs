Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int z;
if (number>0)
{
for (int x = 1; x<=number;x++)
{
    Console.Write(z = x*x*x);
    Console.Write(" ");
}
}
else if (number<0)
for (int x = -1; x>=number;x--)
{
    Console.Write(z = x*x*x);
    Console.Write(" ");
}
else if (number==0) Console.WriteLine("Введите число отличное от нуля");



