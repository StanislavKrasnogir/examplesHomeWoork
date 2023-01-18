// Напишите програму которая на вход принимает число от 10 до 99 и выдаёт наибольшую цифру из этого числа

int num = new Random().Next(10, 100);
int numA = num / 10;
int numB = num % 10;
int max = numA;
if(max < numB)
{
    max = numB;
    Console.WriteLine("Наибольшее второе число " + numB);
    
}
else{
    Console.WriteLine("Наибольшее первое число " + numA);
}
Console.WriteLine(num);