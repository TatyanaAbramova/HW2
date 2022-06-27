// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("ВВедите число: ");
string number = Console.ReadLine();

if (int.Parse (number) >= 100)
{
    Console.WriteLine(number [2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}