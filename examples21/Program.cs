// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53




 void Distance(double x, double y, double z, double x2, double y2, double z2)
 {
    double dis = Math.Pow(Math.Pow (x-x2 ,2) + Math.Pow(y-y2, 2) + Math.Pow(z-2, 2), 0.5);
    Console.Write(dis);
 }
 
 int GetNum(string text)
 {
     Console.WriteLine(text);
   int num = int.Parse(Console.ReadLine()); 
   return num;
 }


double  x = GetNum("Введите значение x ");
double  y = GetNum("Введите значение y ");
double  z = GetNum("Введите значение z ");
double  x2 = GetNum("Введите значение x2 ");
double  y2 = GetNum("Введите значение y2 ");
double  z2 = GetNum("Введите значение z ");


Console.Write("Dist is ");

Distance(x, y, z, x2, y2, z2);