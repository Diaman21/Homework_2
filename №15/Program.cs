
        //Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.Write("Введите число от 1 до 7: ");
int a = int.Parse(Console.ReadLine()!);
if (a <= 5)
{    
    Console.WriteLine("Будний день");
}
else
    Console.WriteLine("Выходной");