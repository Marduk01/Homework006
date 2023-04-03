// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите числа через пробел : ");
int k = Convert.ToInt32(Console.ReadLine());
int[] massiveChisel = new int[k];

void inputNumbers(int k)
{
    for (int i = 0; i < k; i++)
    {
        Console.Write($"  ");
        massiveChisel[i] = Convert.ToInt32(Console.ReadLine());
    }
}

