//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

int number = new Random().Next(100, 1000);

Console.WriteLine(number);

int SecondSymbolEjector(int NumberInput)
{
    int firstAndSecond = NumberInput / 10;
    int result = firstAndSecond % 10;
    return result;
}
int result = SecondSymbolEjector(number);

Console.WriteLine(result);