// Напишите программу которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N


Console.Clear();
Console.Write("Введите число  "); 
int num = Convert.ToInt32(Console.ReadLine()); // выбор числа в терминале
int i = 0; 

while(i <= num)
{
  if(i % 2 == 0)
  {
   Console.WriteLine("число  " + i); 
  }
  i++;
}
