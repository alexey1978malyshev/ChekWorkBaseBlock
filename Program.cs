
/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
 длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
 либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
 лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

string[] createArrayWithControlElementsLength(string[] Array, int lengthElem)
{
    string[] newArray = new string[Array.Length];//задаем массив для вывода результата
    int j = 0;                               // задаем переменную для записи нужных элементов в новый массив
    for (int i = 0; i < Array.Length; i++)  //проходим по исходному массиву
    {
        if (Array[i].Length <= lengthElem)  //выбираем нужные элементы
        {
            newArray[j] = Array[i];
            j++;
        }

    }
    return newArray;
}

string[] inputArray = { "Hello", "2", "world", ":-)" };

string[] newStringArray = createArrayWithControlElementsLength(inputArray, 3);

for (int i = 0; i < newStringArray.Length; i++) //вывод результрующего массива в консоль
{
    Console.Write(newStringArray[i] + " ");
}

