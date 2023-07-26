// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При 
// решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] GenerateArray(int lenghtSource)
{
    string[] array = new string[lenghtSource];
    
    for (int i = 0; i < lenghtSource; i++)
    {
        Console.Write($"Введите строку №{i + 1}: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

int Prompt (string message)
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int GetArrayLenght (string[] array) 
{
    int lenght = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            ++lenght;
        }
    }
    return lenght;
}

string[] GetSortArray(string[] sourceArray, int lenghtSort)
{
    string[] array = new string[lenghtSort];
    int indexArr = 0;
    
    for (int i = 0; i < sourceArray.Length; i++)
    {
        if (sourceArray[i].Length <= 3)
        {
            array[indexArr] = sourceArray[i];
            Console.WriteLine(array[indexArr]);
            indexArr++;
        }
        
    }
    return array;
}

void PrintArray (string[] array)
{
    if (array.Length == 0)
    {
        System.Console.WriteLine("[]");
        return;
    }
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write('\u0022' + $"{array[i]}" + '\u0022' + ", ");
    }
    Console.Write('\u0022' + $"{array[array.Length - 1]}" + '\u0022');
    Console.WriteLine("]");
}

int lenghtSourceArray = Prompt("Введите длинну массива строк: ");
string[] sourceArray = GenerateArray(lenghtSourceArray);


int lenghtSortArray = GetArrayLenght(sourceArray);
string[] sortArray = GetSortArray(sourceArray, lenghtSortArray);

System.Console.WriteLine("Вот наш новый отсортированный массив строк: ");
PrintArray(sortArray);

Console.Write("\n ...Нажмите Enter для выхода...");
Console.ReadKey();
