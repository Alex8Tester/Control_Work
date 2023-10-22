/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

using System;
using System.Linq;
using static System.Console;
Clear();

// Values

string[] arrayFirst = inputText("Введите строковый массив через пробел:");
string[] arraySecond = new string [arrayFirst.Length];

// Code

arrayLineWriter(arrayFirst, arraySecond);
PrintArray(arraySecond);

// Methods

int inputText(string message);
{
    WriteLine(message);
    string readMessage = ReadLine();
    int result = int.Parse(readMessage);
    return result; 
}

void arrayLineWriter(string[] arrayFirst, string[] arraySecond)
{
    int count = 0;
    for (int i = 0; i < arrayFirst.Length; i++)
    {
        if (arrayFirst[i].Length <= 3)
            {
                arraySecond[count] = arrayFirst[i];
                count++;
            }
    }
}

void PrintArray(string [] array)
{
    Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
       Write($"{array[i]}, "); 
    }
    Write($"{array[array.Length - 1]}");
    WriteLine("]");
}
