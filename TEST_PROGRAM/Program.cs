//Задача: Написать программу, которая из имеющегося массива строк 
//формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

string stringsSet = GetStringsSet("Введите массив строк через запятую с пробелом: ");
Console.Write($"[{stringsSet}] -> ");
string[] firstArray = GetUserArray(stringsSet);
string[] finalArray = GetResultArray(firstArray);
Console.Write($"[{String.Join(", ", finalArray)}]");


string GetStringsSet(string message)
{
    Console.Write(message);
    return Console.ReadLine()!;
}

string[] GetUserArray(string userText)
{
    string[] userArray = userText.Split(", ");
    return userArray;
}

string[] GetResultArray(string[] arr1)
{
    string[] arr2 = Array.Empty<string>();
    int newIndx = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            Array.Resize(ref arr2, newIndx+1);
            arr2[newIndx] = arr1[i];
            newIndx++;
        }
    }
    return arr2;
}


