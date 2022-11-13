// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

// Console.WriteLine("Введите количество элементов массива : ");

int num = 8;
int[] NewArray(int num)
{
    int[] array = new int[num];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 99); //ограничил длину элементов массива от 0 до 99
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", "); // как убрать последнюю запятую не придумал
    }
    Console.Write("]");
}

int[] nameArray = NewArray(num);
PrintArray(nameArray);