using System;

class Program
{
    static void Main()
    {
        string str1 = "Hello";
        string str2 = "hello";
        string str3 = "Hello, World!";
        string str4 = "Hello";

        // оператор ==
        Console.WriteLine("Сравнение с помощью оператора ==:");
        Console.WriteLine(str1 == str4); // true
        Console.WriteLine(str1 == str2); // false

        // оператор !=
        Console.WriteLine("\nСравнение с помощью оператора !=:");
        Console.WriteLine(str1 != str2); // true
        Console.WriteLine(str1 != str4); // false

        // Метод Equals()
        Console.WriteLine("\nСравнение с помощью метода Equals():");
        Console.WriteLine(str1.Equals(str4)); // true
        Console.WriteLine(str1.Equals(str2)); // false

        // Метод Compare()
        Console.WriteLine("\nСравнение с помощью метода Compare():");
        int resultCompare = String.Compare(str1, str2);
        Console.WriteLine($"Результат сравнения (str1 vs str2): {resultCompare}"); // < 0 (str1 меньше str2)

        // Метод CompareOrdinal()
        Console.WriteLine("\nСравнение с помощью метода CompareOrdinal():");
        int resultCompareOrdinal = String.CompareOrdinal(str1, str2);
        Console.WriteLine($"Результат CompareOrdinal (str1 vs str2): {resultCompareOrdinal}"); // < 0

        // Метод IndexOf()
        Console.WriteLine("\nИспользуем метод IndexOf():");
        int index = str3.IndexOf("World");
        Console.WriteLine($"Индекс слова 'World' в строке: {index}"); // Индекс вхождения

        // Метод Contains()
        Console.WriteLine("\nИспользуем метод Contains():");
        bool contains = str3.Contains("Hello");
        Console.WriteLine($"Содержит 'Hello'? {contains}"); // true

       
    }
}