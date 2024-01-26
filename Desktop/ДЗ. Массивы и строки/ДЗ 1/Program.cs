using System;

class Program
{
    static void Main()
    {
        // Задаем двумерный массив символов
        char[,] charArray = 
        {
            {'H', 'e', 'l', 'l', 'o'},
            {'W', 'o', 'r', 'l', 'd'}
        };

        // Создаем строку из символов массива
        string resultString = GetStringFromCharArray(charArray);

        // Выводим результат
        Console.WriteLine("Результирующая строка: " + resultString);
    }

    // Метод для создания строки из символов массива
    static string GetStringFromCharArray(char[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        // Используем StringBuilder для эффективной конкатенации символов
        System.Text.StringBuilder result = new System.Text.StringBuilder();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                // Добавляем каждый символ к строке
                result.Append(array[i, j]);
            }
        }

        // Возвращаем строку
        return result.ToString();
    }
}

