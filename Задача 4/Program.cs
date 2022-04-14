//Доп. задача: Игра угадайка. Программа загадывает случайное число. Пользователь его угадывает. Если пользователь дает неправильный ответ, то программа сообщает, больше загаданное число или меньше
//Доп. задача с усложнением: на отгадывание дается 3 попытки.

int number = new Random().Next(1,10);
Console.WriteLine(number);

int userNumber = Input(number);

while (userNumber != number)
{
    if (userNumber > number)
    {
        Console.WriteLine("Загаданое число меньше вашего :'(");
        userNumber = Input(number);
    }
    else 
    {
        Console.WriteLine("Загаданое число больше вашего :'(");
        userNumber = Input(number);
    }
}
    Console.WriteLine("Вы угадали!!!");
    

int Input (int n1)
{
Console.WriteLine("Введите число от 1 до 10:");
int InputUserNumber = Convert.ToInt32(Console.ReadLine());
return InputUserNumber;
}
