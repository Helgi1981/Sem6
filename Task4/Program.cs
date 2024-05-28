// Необходимо разделить логику алгоритмов на функции

// 1. Задайте двумерный массив символов (тип char [,]). 
// 2. Создать строку из символов этого массива.

// Пример:
// a b c 
// d e f 
// => “abcdef”

string CharMatrixToString(char[,] array2d)
{
    string res = string.Empty;
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            res += array2d[i, j];
        }
    }
    return res;
}

char[,] matrix = new char[2, 3]
{
{'a', 'b', 'c'},
{'d', 'e', 'f'}
};

string result = CharMatrixToString(matrix);
Console.WriteLine(result);
