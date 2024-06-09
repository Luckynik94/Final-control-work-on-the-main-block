// ### Этап 4: Написание программы
// Создайте новый проект в Visual Studio и добавьте файл `Program.cs` с следующим содержанием:

// ```csharp
// using System;
// using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Пример массива
        string[] array = { "11", "33232", "llsllsl", "0" };

        // Фильтрация массива
        string[] filteredArray = FilterStrings(array);

        // Вывод результата
        foreach (var str in filteredArray)
        {
            Console.WriteLine(str);
        }
    }

    static string[] FilterStrings(string[] array)
    {
        List<string> result = new List<string>();
        foreach (var str in array)
        {
            if (str.Length <= 3)
            {
                result.Add(str);
            }
        }
        return result.ToArray();
    }
}