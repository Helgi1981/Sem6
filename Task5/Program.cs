// Необходимо разделить логику алгоритмов на функции

// 1. Задайте строку, содержащую латинские буквы в обоих регистрах. 
// 2. Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// Пример:
// “aBcD1ef!-” 
// => “abcd1ef!-”

// Функция для чтения строки из консоли
string ReadInputString()
{
    Console.WriteLine("Напишите слово на латинице");
    return Console.ReadLine();
}

// Функция для преобразования всех заглавных букв в строчные
string ConvertToLowerCase(string input)
{
    return input.ToLower();
}

// Вызов функции для чтения строки
string start = ReadInputString();

// Вызов функции для преобразования строки
string result = ConvertToLowerCase(start);

// Вывод результата
Console.WriteLine(result);