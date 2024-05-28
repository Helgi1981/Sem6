// Необходимо разделить логику алгоритмов на функции.

// 1. Задайте строку, состоящую из любых символов, разделенных пробелами. 
// 2. Сформировать строку, в которой символы расположены в обратном порядке. 
// 3. В полученной строке символы должны быть также разделены пробелами.

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

string input = "Hello my world";
string reversed = ReverseWords(input);
Console.WriteLine(reversed);