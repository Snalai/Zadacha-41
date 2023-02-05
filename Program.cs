// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine("Сколько желаете ввести чисел?");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ваши числа: ");
int[] mas = new int[M];
int chot = 0;
for (int i = 0; i < mas.Length; i++)
{
    int num = Convert.ToInt32(Console.ReadLine());
    mas[i] = num;
    if (mas[i] > 0)
    {
        chot++;
    }
}
Console.Write($"Чисел больше нуля: {chot}");

