// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 -> 1, 8, 27, 64, 125


int getnum(string text)
{
    Console.Write(text);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void OutNumbers(int num)
{
int i = 1;
while(i < num)
{
Console.Write(Math.Pow(i,3)+", ");
i++;
}
Console.Write (Math.Pow(i,3));
}

int number = getnum("введите число ");
OutNumbers(number);
