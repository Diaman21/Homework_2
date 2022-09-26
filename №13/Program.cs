        //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
     Console.Clear();
Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberstr = Convert.ToString(number);
if (numberstr.Length > 2)
{
  Console.WriteLine("третья цифра  " + numberstr[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}