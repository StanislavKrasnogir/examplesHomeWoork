// Напишите программу котороя выводит случайное трёхзначное число и удаляет вторую цифру этого числа 456 -> 46

int num = new Random().Next(100, 999);
int numA = num / 100;
int numB = num % 10;
int numC = numA * 10 + numB;

Console.WriteLine(num);
Console.WriteLine("число " + numC);