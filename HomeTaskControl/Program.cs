// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] currentArray = { "hello", "25", "-2", "Hi", "computer science", ":-)" };
void changedArray(string[] currentArray)
{
    string[] newArray = new string[currentArray.Length];
    int count = 0;
    Console.Write("Новый массив: [");
    for (int i = 0; i < currentArray.Length; i++)
    {
        if (currentArray[i].Length <= 3)
            newArray[i] = currentArray[i];
        Console.Write($"{newArray[i]} ");
        count++;
    }
    Console.Write($"]");
    Console.WriteLine();
}


void Print(string[] Array)
{
    Console.Write("Исходный массив: [ ");
    for (int i = 0; i < Array.Length - 1; i++)
    {
        Console.Write($"{Array[i]}, ");
    }
    Console.Write($"{Array[Array.Length - 1]}] ");
    Console.WriteLine();
}

changedArray(currentArray);
Print(currentArray);