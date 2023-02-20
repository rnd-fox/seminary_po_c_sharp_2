
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1

System.Console.WriteLine(System.Console.WriteLine("Введите трехзначное N:");
int number = Convert.ToInt32(Console.ReadLine()););

if (number > 99 && number < 1000)
{
    number = ((number % 100) / 10);
    System.Console.WriteLine(number);
}
else
{
    System.Console.WriteLine("введенное число не трехзначное");
}





// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Введите число N:");
int number = Convert.ToInt32(Console.ReadLine());


string numberText = Convert.ToString(number);
if (numberText.Length > 2)
{
    Console.WriteLine("Третья цифра " + numberText[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}



// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.Write("Введите цифру, обозначающую день недели ");
int day = Convert.ToInt32(Console.ReadLine());
if (day >= 1 && day <= 7)
{
    if (day >= 6)
    {
        Console.Write("Да, это выходной день");
    }
    else
    {
        Console.Write("Нет, это рабочий день");
    }
}
else
{
    Console.Write("Введите цифру от 1 до 7, соответствующую дню недели");
}