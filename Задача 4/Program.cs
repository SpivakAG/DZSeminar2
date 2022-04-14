//Доп. задача: Игра угадайка. Программа загадывает случайное число. Пользователь его угадывает. Если пользователь дает неправильный ответ, то программа сообщает, больше загаданное число или меньше
//Доп. задача с усложнением: на отгадывание дается 3 попытки.

int number = new Random().Next(1,10);
Console.WriteLine(number);

int n1 = 0; //нужен для работы метода, формально, без введения аргумента почему то не работает

int userNumber = Input(number);
int wrongAnswers = 0;

if (userNumber == number)
{
    Console.WriteLine("Вы угадали!!!");
}
else
{
while (wrongAnswers <2)
{
    {
    if (userNumber > number)
    {
        Console.WriteLine("Загаданое число меньше вашего :'(");
        userNumber = Input(n1);
        wrongAnswers +=1;
    }
    else 
    {
        Console.WriteLine("Загаданое число больше вашего :'(");
        userNumber = Input(n1);
        wrongAnswers +=1;
    }
    }
}
Console.WriteLine("Вы проиграли:'(");
}
    


int Input (int n1)
{
Console.WriteLine("Введите число от 1 до 10:");
int InputUserNumber = Convert.ToInt32(Console.ReadLine());
return InputUserNumber;
}
