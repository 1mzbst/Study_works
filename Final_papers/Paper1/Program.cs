// Условие задачи:
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше или равна 3 символа. 

//Решение:

string[] CreateStringArr(int size) // Метод создание массива состоящего из строк.
{
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine(); // Ввод осуществляется через консоль, вручную.
        if (array[i] == "") // Условие, если пользователь пропустил ввод слова.
        {
            array[i] = "empty_index";
        }
    }
    return array;
}

void threeLetter(string[] array) // Метод вывода нового массива, состоящего из алгоритма выполняющего условие задачи.
{
    Console.Write("This is the new array from three or less letters in a word: [ ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) Console.Write($"{array[i]} ");
    }
    Console.Write("]");
}