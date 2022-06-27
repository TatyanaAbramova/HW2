// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру от 1 до 7, соответствующую дню недели: ");
int day = Convert.ToInt32(Console.ReadLine());
switch (day)
{
    case 1: Console.WriteLine("Понедельник"); break;
    case 2: Console.WriteLine("Вторник"); break;
    case 3: Console.WriteLine("Среда"); break; 
    case 4: Console.WriteLine("Четверг"); break;
    case 5: Console.WriteLine("Пятница"); break;
    case 6: Console.WriteLine("Суббота"); break;
    default: Console.WriteLine("Неверный ввод дня недели"); break;
}
if (day < 6 && day > 0)
{
    Console.WriteLine($"День недели: {day} - рабочий день");
}

if (day > 5 && day < 8)
{
    Console.WriteLine($"День недели: {day} - выходной");
}
