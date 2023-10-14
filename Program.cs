// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.Write("введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


if(number > 999)
{
    while (number > 999) 
    {
number /=10; // number = number / 10
    }
{
    System.Console.WriteLine((number % 10));
}

// 925 % 10- >5
// 24589 % 10 ->9
//надо из числа сделать трехзначное число
//23852 / 10 ->2385 / 10 ->238
}
else
{
    System.Console.WriteLine("в введенном числе нет третьей цифры");
}