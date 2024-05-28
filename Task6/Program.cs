// Необходимо разделить логику алгоритмов на функции.

// 1. Задайте произвольную строку. 
// 2. Выясните, является ли она палиндромом.

// Пример:
// “aBcD1ef!-” => Нет
// “шалаш” => Да
// “55655” => Да

string IsPalindrome(string input)
{
    string cleanedInput = CleanString(input);
    bool isPalindrome = CheckPalindrome(cleanedInput);
    return isPalindrome ? "Да" : "Нет";
}

string CleanString(string input)
{
    // Удаление всех символов, кроме букв и цифр, и приведение к нижнему регистру
    return new string(input.Where(char.IsLetterOrDigit).Select(char.ToLower).ToArray());
}

bool CheckPalindrome(string input)
{
    int left = 0;
    int right = input.Length - 1;

    while (left < right)
    {
        if (input[left] != input[right])
        {
            return false;
        }
        left++;
        right--;
    }

    return true;
}

string input1 = "aBcD1ef!-";
string input2 = "шалаш";
string input3 = "55655";
string input4 = "недотрога";

Console.WriteLine($"{input1} => {IsPalindrome(input1)}");
Console.WriteLine($"{input2} => {IsPalindrome(input2)}");
Console.WriteLine($"{input3} => {IsPalindrome(input3)}");
Console.WriteLine($"{input4} => {IsPalindrome(input4)}");