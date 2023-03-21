﻿/*
 Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше
 либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
 Примеры:
 ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
 ["1234", "1567", "-2", "computer science"] -> ["-2"]
 ["Russia", "Denmark", "Kazan"] -> []
 */


//Задаем масив строк

string[] myArray = { "Delta", "35", " main", "set", "141", "no" };

int elimentLength = 3;

string[] FinalArray(string[] str, int elimentLength)
{
    string newString = string.Empty;
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= elimentLength)
        {
            newString = newString + str[i] + " ";
        }

    }
    return newString.Split(" ");
}