using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine("Это палиндром!");
        }
        else
        {
            Console.WriteLine("Это не палиндром.");
        }
    }

    static bool IsPalindrome(string str)
    {
        // Удаляем пробелы и делаем все буквы строчными
        string cleanedStr = str.Replace(" ", "").ToLower();

        // Создаем массив символов из строки
        char[] charArray = cleanedStr.ToCharArray();

        // Переворачиваем массив символов
        Array.Reverse(charArray);

        // Сравниваем перевернутую строку с оригинальной
        string reversedStr = new string(charArray);

        return cleanedStr == reversedStr;
    }
}
