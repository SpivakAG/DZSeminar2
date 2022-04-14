//Доп. задача: Игра угадайка. Программа загадывает случайное число. Пользователь его угадывает. Если пользователь дает неправильный ответ, то программа сообщает, больше загаданное число или меньше
//Доп. задача с усложнением: на отгадывание дается 3 попытки.

int number = new Random().Next(1,10);
Console.WriteLine(number);

Console.WriteLine("Введите число от 1 до 10:");
int userNumber = Convert.ToInt32(Console.ReadLine());

if (userNumber == number)
{
    Console.WriteLine("Вы угадали!!!");
}
else
{
    if (userNumber > number)
    {
        Console.WriteLine("Загаданое число меньше вашего :'(");
    }
    else Console.WriteLine("Загаданое число больше вашего :'(");
}
