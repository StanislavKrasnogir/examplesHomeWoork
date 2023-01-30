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
