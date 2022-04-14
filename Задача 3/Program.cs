// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
 {
     Console.WriteLine("Третьей цифры нет");
}
else
{
    int reversenumber = ReverseNumber(number);
    int result = ThirdNumber(reversenumber);
    Console.WriteLine(result);
}
int ReverseNumber (int n1)
{
    int result = 0;
    while (n1 > 0)
    {
    result *= 10;
    result += n1 % 10;
    n1 /= 10;
    }
    return result;
}

int ThirdNumber (int number)
{
    number %= 1000;
    number /= 100;
    return number;
}
