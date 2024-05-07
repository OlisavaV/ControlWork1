// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


Console.WriteLine("Введите значения массива через пробел ");
string stroka = Console.ReadLine();
string[] array = stroka.Split();
string[] new_array = new string[array.Length];

for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            new_array[i] = array[i];
        }
    }
    
void PrintArray(string[] chars)
{
    Console.Write("[");
    for (int i = 0; i < chars.Length; i++)
    {
        Console.Write($"{chars[i]} ");
    }
    Console.Write("]");
}

PrintArray(new_array);