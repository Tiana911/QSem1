// Напишите программу, которая на вход принимает 
// число и выдаёт его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

// Однострочный комментарий
/*
Это
многострочный комментарий
*/

// тип данных имя - значение;
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine()); // в переменной number хранится число 5

// int result = number * number;
// result = number * number; result = 5+5 => res = 25

// Console.WriteLine("Квадра числа " +  number + " равен: " + result); //"1"+"2" ="12" - конкатинация, процесс сложения строк




// 1. Напишите программу, которая на вход принимает два числа и 
// проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

// camelCase 
// Console.Write("Введите первое число: ");
// int firstDigit = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondDigit = Convert.ToInt32(Console.ReadLine());
// "=" - прис-я; "==" - проверка на равенство
// firstDigit == secondDigit * secondDigit
// if (firstDigit == secondDigit * secondDigit) // Точка с запятой НИКОГДА перед "{"
// {
    // Console.WriteLine("Число " + firstDigit + " является квадратом от числа " + secondDigit);
// }
// else // Все остальные случаи
// {
    // Console.WriteLine("Число " + firstDigit + " НЕ ЯВЛЯЕТСЯ квадратом от числа " + secondDigit);
// }





// Напишите программу, которая на вход принимает одно число (N),
//  а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

// Console.Write("Введите число: ");

// int N = Convert.ToInt32(Console.ReadLine()); // Перевод строчки в целое число
// if (N < 0) // Число N - отрц.
// {
    // N = N * -1; // N = -5, N = 5
// }
// int negativeN = N * -1; // -N 

// while (negativeN <= N)
// {
    // Console.WriteLine(negativeN); // -n = -2, то печатаю -2
    // negativeN++; // Инкремент: negativeN = negativeN + 1
    // Декремент: negativeN-- (negativeN = negativeN - 1)
// }
