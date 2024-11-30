using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string text = "Это пример текста. Текст должен быть проанализирован. Это важно.";
        Dictionary<string, int> wordCounts = WordFrequency(text);

        foreach (var item in wordCounts)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
    }

    static Dictionary<string, int> WordFrequency(string text)
    {
        // Используем LINQ для группировки слов и подсчета их количества. 
        return text.Split(new char[] { ' ', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries) // Разделяем строку на слова, удаляя пустые элементы
                   .GroupBy(word => word.ToLower()) // Группируем слова без учёта регистра
                   .ToDictionary(g => g.Key, g => g.Count()); // Создаём словарь: слово - количество
    }
}

