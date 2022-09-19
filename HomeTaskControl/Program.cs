// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] currentArray = { "hello", "2", "world", "-2", "computer science" };
void changedArray(string[] array)
{
    string[] newArray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[i] = array[i]; ;
            Console.Write(newArray[i]);
        }
    }
    Console.WriteLine();
}

void Print(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i]);
    }
    Console.WriteLine();
}

changedArray(currentArray);
Print(currentArray);