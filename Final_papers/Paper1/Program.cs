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

void ShowArray(string[] array) // Метод вывода массива в консоль.
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.WriteLine("Enter the size of the array.");
int size = Convert.ToInt32(Console.ReadLine()); // Переменная размера массива вводных данных.
Console.WriteLine($"Enter the any {size} words or symbols:");
string[] someArray = CreateStringArr(size); // Дополнительный массив упрощающий визуальное восприятие, и упрощающее написание кода.
Console.WriteLine($"It is the entered array:");
ShowArray(someArray); // Вывод в консоль массива введённых данных с клавиатуры.
threeLetter(someArray); // Вызов метода, выводящего в консоль изменённый массив, удовлетворяющий условие задачи.

//__________________________________________________________________________________________________________________________________