// ввод данных от пользователя x, y

// void CheckQuarter(int x, int y)
// {
//     if (x > 0 & y > 0)
//     {
//         Console.WriteLine(1);
//     }

//     if (x < 0 & y > 0)
//     {
//         Console.WriteLine(2);
//     }

//     if (x < 0 & y < 0)
//     {
//         Console.WriteLine(3);
//     }

//     if (x > 0 & y < 0)
//     {
//         Console.WriteLine(4);
//     }
// }

// int GetNum(string text)
// {
//     Console.WriteLine(text);
//   int num = int.Parse(Console.ReadLine()); 
//   return num;
// }

// int  x = GetNum("Введите значение x ");
// int  y = GetNum("Введите значение y ");
// Console.Write("четверть ");
// // определить четверть
// CheckQuarter(x ,y);


int GetQuarter(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num; 
}
void Checkxy(int quot)
{
if (quot == 1) Console.WriteLine("x > 0 Y > 0");
if (quot == 2) Console.WriteLine("x < 0 Y > 0");
if (quot == 3) Console.WriteLine("x < 0 Y < 0");
if (quot == 4) Console.WriteLine("x > 0 Y < 0");
}

int quorter = GetQuarter ("введите четверть ");

Checkxy(quorter);