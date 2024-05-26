// Задание 3. Совместная работа

// 1. Считать строку с консоли, состоящую из латинских букв в нижнем регистре. 
// 2. Выяснить, сколько среди введённых букв гласных.

// Пример:
// “hello” => 2
// “world” => 1

int CountVowelsLetters(string str)
{
    string vowels = "aeiouy";
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        for (int j = 0; j < vowels.Length; j++)
        {
            if (str[i] == vowels[j])
            {
                count++;
            }
        }
    }
    return count;
}

Console.WriteLine("Напишите слово на латинице");
string start = Console.ReadLine();
Console.WriteLine($"В введённом слове {CountVowelsLetters(start)} глассных");
