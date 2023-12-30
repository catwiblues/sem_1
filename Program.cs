// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// тип_данных имя_переменной = значение;
// camelCase: firstNumber, secondNumber
// int number = 9; // number = 9
// int result = number * number; //81

// Console.ReadLine() - получить информацию из строчки
Console.Write("Введите первое число: "); // a
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: "); // b
int secondNumber = Convert.ToInt32(Console.ReadLine());
// firstNumber = secondNumber * secondNumber
if (firstNumber == secondNumber * secondNumber) // true
// a = 5; a == 5? (true, false)
{
    Console.WriteLine("Да, " + firstNumber + " является квадратом от числа " + secondNumber);
}
else // a не является кв от чилса b
{
    Console.WriteLine("Нет, " + firstNumber + " не является квадратом числа " + secondNumber);
}

