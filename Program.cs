/*Написать программу, которая из имеющегося массива строк формирует массив из строк,
длинна которых меньше или равна трем символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнение алгоритма. При решении нужно обойтись исключительно массивам.
["hello","2","world",":-)"] => ["2",":-)"]
["1234","1567","-2","computer science"] => ["-2"]
["Russia","Denmark","Kazan"] => []*/


using static System.Console;
Clear();


string[] array1 = new string[4] { "1234","1567","-2","computer science" };
string[] array2 = new string[array1.Length];
SecondArray(array1, array2);
PrintArray(array2);



void SecondArray(string[] array1, string[] array2)
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
     WriteLine();  
    Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]} ");
    }
    Write("] ");
    WriteLine();
}
 WriteLine();