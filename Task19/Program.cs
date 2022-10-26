// Задача 19:
// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом

Console.WriteLine("Введите целое пятизначное число:");
int n = Convert.ToInt32(Console.ReadLine());
void Palindrom(int num)
{
    if (num > 9999 && num < 100000)
    {
        int Dig_1 = num / 10000;
        int Dig_2 = num / 1000 % 10;
        int Dig_4 = num / 10 % 10;
        int Dig_5 = num % 10;

        if (Dig_1 == Dig_5 && Dig_2 == Dig_4)
        {
            Console.WriteLine($"ПАЛИНДРОМ");
        }
        else
        {
            Console.WriteLine($"НЕ ПАЛИНДРОМ");
        }
    }
    else
        Console.WriteLine("Некорректный ввод. Попробуйте ещё раз");
}
Palindrom(n);

// Console.WriteLine("Введите целое число:");
// int N = Convert.ToInt32(Console.ReadLine());

// // int Palindrom(int N)

// if (N > 0)
// {

//     string str = N.ToString();
//     int[] array = new int[str.Length];
//     for (int u = 0; u < str.Length; u++)
//     {
//         array[u] = int.Parse(str[u].ToString());
//     }

//     int len = array.Length;
//     int i = 0;
//     if (i < len)
//     {
//         int t = array[i];
//         array[i] = array[len - i - 1];
//         array[len - i - 1] = t;
//         i++;

//     }
//     else
//     {
//         Console.WriteLine($"{array}");
//     }


// }
// else
//     Console.WriteLine("Некорректный ввод. Попробуйте ещё раз");

