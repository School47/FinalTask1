//  Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] CreateMyArray()
{
    string[] arr = new string[] {"Hello", "2", "world", ":-)"};
    return arr;
}


void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)  Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
    Console.WriteLine();
}

string[] MakeResultArray(string[] arr)
{
    string[] resArray = new string[arr.Length];
    int counter = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) { resArray[counter++] = arr[i]; }
    }
    Array.Resize(ref resArray, counter); // убрать пустые элементы в конце массива
    return resArray;
}

string[] myArray = CreateMyArray();
Console.WriteLine("Исходный массив:");
PrintArray(myArray);
string[] resultArray = MakeResultArray(myArray);
Console.WriteLine("Новый массив массив:");
PrintArray(resultArray);
