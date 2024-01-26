using System;

class Program
{
    static void Main()
    {
        // Исходная строка с латинскими буквами в обоих регистрах
        string originalString = "HeLLoWorLD";

        // Преобразование всех заглавных букв в строчные
        string resultString = originalString.ToLower();

        // Вывод результата
        Console.WriteLine("Исходная строка: " + originalString);
        Console.WriteLine("Результат: " + resultString);
    }
}
