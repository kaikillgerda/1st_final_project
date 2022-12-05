/* Написать программу, которая из имеющегося массива строк формирует
массив из строк длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Например:
[hello, 2, world, :-)] -> [2, :-)]
["1234","1567","-2","computer science"] -> ["-2"]
["Russia","Denmark","Kazan"] -> [] */

void CreateSecondaryArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    array = array.Where(i => i != null).ToArray();
    Console.Write("Сфромированный массив: [" + $"{array[0]}");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($", {array[i]}");
    }
    Console.WriteLine("]");
}

void Main()
{
    string[] previousArray = { "hello", "2", "world", ":-)", "при", "привет", "222", "1234" };
    string[] secondaryArray = new string[previousArray.Length];
    CreateSecondaryArray(previousArray, secondaryArray);
    PrintArray(secondaryArray);
}
Main();