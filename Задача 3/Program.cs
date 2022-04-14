// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите номер дня недели:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 8)
{
    if (number >5 ) Console.WriteLine("Выходной");
    else Console.WriteLine("Будний");
}
else Console.WriteLine("Такого дня недели не существует");