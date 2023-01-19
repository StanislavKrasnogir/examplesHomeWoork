// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введи цифру, обозначающую день недели: ");
int NumberA = Convert.ToInt32(Console.ReadLine());

void total (int NumberA) {
  if (NumberA == 6 || NumberA == 7) {
  Console.WriteLine("(этот день выходной) -> да");
  }
  else if (NumberA < 1 || NumberA > 7) {
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine("(этот день не выходной) -> нет");
}

total (NumberA);
