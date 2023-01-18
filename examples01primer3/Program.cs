// Напишите программу которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.Если число 2 
// не кратно числу 1 то программа выводит остаток от деления

// Console.Write("Введите превое число ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число ");
// int numberB = Convert.ToInt32(Console.ReadLine());
// int result = numberA % numberB;
// if(result == 0)
// {
//     Console.WriteLine("Число кратное первому " );
// }

// else 
// {
//     Console.WriteLine("число не кратное первому " + result);
// }


Console.WriteLine($"Введите два числа");
int num1, num2, rem;
num1 = Convert.ToInt32(Console.ReadLine());
num2 = Convert.ToInt32(Console.ReadLine());
rem = num1 % num2;
if(rem == 0) {
    Console.WriteLine($"не кратно, остаток {rem}");
} 

else {
    Console.WriteLine($"{num1} кратно {num2}");
}
  

