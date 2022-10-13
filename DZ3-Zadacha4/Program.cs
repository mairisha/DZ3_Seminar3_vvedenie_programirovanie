// Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("Введите число N");
int N=Convert.ToInt32(Console.ReadLine());
int a=1;
int cube=1;
while (a<=N)
{
   if (a%2==0)
{
  cube=a*a*a;
  Console.WriteLine($"Куб от числа {a} = {cube}");
}
a=a+1;
}