//Доп. задача: Игра угадайка. Программа загадывает случайное число. Пользователь его угадывает. Если пользователь дает неправильный ответ, то программа сообщает, больше загаданное число или меньше
//Доп. задача с усложнением: на отгадывание дается 3 попытки.

int number = new Random().Next(1,10);
Console.WriteLine(number);

int wrongAnswers = 0; 

int userNumber = Input();

while (userNumber != number)  
{
    if (wrongAnswers <2)  //проверяет кол-во неверных ответов
    {
        if (userNumber > number)
        {
            Console.WriteLine("Загаданое число меньше вашего :'(");
            wrongAnswers +=1;
            userNumber = Input();
        }
        else 
        {
            Console.WriteLine("Загаданое число больше вашего :'(");
            wrongAnswers +=1;
            userNumber = Input();
        }
    }
    else break;  // в случае если попыток нет, цикл прекращается
   

}
if (userNumber == number)  Console.WriteLine("Вы угадали!!!");
else Console.WriteLine("Вы проиграли");
    

int Input () // функция ввода данных пользователем
{
Console.WriteLine("Введите число от 1 до 10:");
return Convert.ToInt32(Console.ReadLine());
}
