  void Distance(double x, double y, double x2, double y2)
 {
    double dis = Math.Pow(Math.Pow (x-x2 ,2) + Math.Pow(y-y2, 2), 0.5);
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
double  x2 = GetNum("Введите значение x2 ");
double  y2 = GetNum("Введите значение y2 ");

Console.Write("Dist is ");

Distance(x, y, x2, y2);