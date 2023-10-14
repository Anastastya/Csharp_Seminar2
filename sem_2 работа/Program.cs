// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// System.Console.Write("введите число: ");
// int number = Math.Abs.Convert.ToInt32(Console.ReadLine());

//Math.Abs(-7) // - 7 ->7 8->8 будет выдавать только абсолютные значения

//if(number > 99)
// {
  //  while (number > 999) 
  //  {
//number /=10; // number = number / 10
   // }
//{
  //  System.Console.WriteLine((number % 10));
//}

// 925 % 10- >5
// 24589 % 10 ->9
//надо из числа сделать трехзначное число
//23852 / 10 ->2385 / 10 ->238
//}
//else
//{
  //  System.Console.WriteLine("в введенном числе нет третьей цифры");
//}

// 1456 % 100 ->56/10->5
// 145789 % 1000 - >145/10 ->14
//System.Console.WriteLine(int.MaxValue); // показывает максимальное значение которое возможно

// int num1 = 5;
// int num2 = 15;
// int num3 = 10;

int[] array = {5, 15, 10}; //задали массив
int[] secondArray = new int[3]; //обьявили массив целых чисел ,назвали его secondArray, и выделили в нем память, new - память, оперативная
secondArray[0] = 5;
secondArray[1] = 15;
secondArray [3] = 10;
System.Console.WriteLine(array[1]);
