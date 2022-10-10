// Найти кубы чисел от 1 до N
Console.WriteLine("Введите число N: ");
int N=Convert.ToInt32(Console.ReadLine());
int cube=1;
int count=1;
while (count<=N)
{
    cube=count*count*count;
    Console.WriteLine($"Куб от числа {count} равен {cube}");
    count=count+1;
}