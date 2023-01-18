 // Напишите программу которая на вход принимает число  и выдаёт, является ли число чётным (делится ли оно на два без остатка)
 
 Console.Clear();
 Console.Write("Введите число  ");
 int number = int.Parse(Console.ReadLine());
 int result = number % 2;
 if(result == 0)
 {
     Console.WriteLine("Число является чётным");
 }

 else
 {
     Console.WriteLine("Число не является чётным");
 }

