﻿// Необходимо разделить логику алгоритмов на функции.

// 1. Задайте строку, состоящую из слов, разделенных пробелами. 
// 2. Сформировать строку, в которой слова расположены в обратном порядке. 
// 3. В полученной строке слова должны быть также разделены пробелами.

// Пример:
// “Hello my world” => “world my Hello”


// Функция для реверса слов в строке
string ReverseWords(string input)
{
    string[] words = SplitIntoWords(input);
    Array.Reverse(words);
    return JoinWords(words);
}

// Функция для разделения строки на слова
string[] SplitIntoWords(string input)
{
    return input.Split(' ');
}

// Функция для объединения слов в строку
string JoinWords(string[] words)
{
    return string.Join(" ", words);
}

Console.WriteLine("Введите строку:");
string input = Console.ReadLine();
string reversed = ReverseWords(input);
Console.WriteLine("Реверсированная строка: " + reversed);


// Пояснение кода:

// ReverseWords: Принимает строку, разделяет ее на слова, реверсирует порядок слов 
// и объединяет их обратно в строку.

// SplitIntoWords: Разделяет строку на массив слов, используя пробел в качестве разделителя.

// JoinWords: Объединяет массив слов в строку с пробелами между словами.

// Main: В основной функции программы сначала выводится приглашение для ввода строки пользователем 
// (Console.WriteLine("Введите строку:")), затем считывается введенная строка (Console.ReadLine()). 
// После этого вызывается функция для реверса слов и результат выводится на консоль.


// Функция ReverseWords

// Эта функция выполняет реверсирование слов в строке. Она состоит из трех основных шагов:

// SplitIntoWords: Вызывает функцию SplitIntoWords, чтобы разбить входную строку на массив слов.

// Array.Reverse: Использует встроенный метод Array.Reverse, чтобы изменить порядок элементов 
// в массиве слов на обратный.

// JoinWords: Вызывает функцию JoinWords, чтобы объединить реверсированный массив слов обратно 
// в строку, разделяя слова пробелами.


// Функция SplitIntoWords

// Эта функция разбивает входную строку на массив слов, используя пробел в качестве разделителя. 
// Вот как она работает:

// input.Split(' '): Использует метод Split для разделения строки на массив строк (слов). 
// В качестве разделителя используется пробел (' ').

// Возвращает массив слов: Строка разделяется на подстроки (слова) по пробелам, и возвращается
// массив этих подстрок.


// Функция JoinWords

// Эта функция объединяет массив слов в одну строку, разделяя их пробелами. 
// Вот как она работает:

// string.Join: Использует метод string.Join, чтобы объединить элементы массива words в одну строку. 
// Первый параметр метода (" ") указывает, что элементы массива должны быть разделены пробелами.

// Возвращает строку: Объединенные элементы массива возвращаются в виде одной строки,
// где слова разделены пробелами.


// Пример работы кода

// Для наглядности, рассмотрим пример:

// Входная строка: "Hello my world"

// SplitIntoWords:
// Входная строка разбивается на массив слов: ["Hello", "my", "world"]

// Array.Reverse:
// Массив слов реверсируется: ["world", "my", "Hello"]

// JoinWords:
// Реверсированный массив слов объединяется в строку: "world my Hello"

// Выводим результат: world my Hello