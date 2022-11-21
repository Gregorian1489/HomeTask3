Console.WriteLine("Введите число");
string number = Console.ReadLine();
int [] array = new int[number.Length];
int count = 0;
int count1= 0;
int x = 0;


while(count<number.Length)
{
    array[count] = Convert.ToInt32(number[count]);
    count++;
}

while(count1 < array.Length/2)
    {
       if (array[count1] == array[array.Length-(count1+1)])
       {
        x = x + 1;
       } 
       else x = x-1;
       count1++;
    }
      
if ((x == array.Length/2) && (array.Length > 1)) Console.WriteLine("Палиндром");
else Console.WriteLine("Не палиндром");