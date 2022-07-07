// подсчитать сумму цифр в числе
Console.WriteLine("введите число ");
int a = int.Parse(Console.ReadLine());


int s=0;
while(a>0)
{
    s=s+a%10;
    a=a/10;
    
}
Console.WriteLine($" сумма цифр числа = {s} ");