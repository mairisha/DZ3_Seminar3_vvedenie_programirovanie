// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число ");
int N=Convert.ToInt32(Console.ReadLine());
int comp=1;
int count=1;
while (count<N)
{
    comp=comp*count;
    count=count++;
} 
    count=count*N;
    Console.WriteLine(count);
