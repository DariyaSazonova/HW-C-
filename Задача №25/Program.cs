/* Задача 25:
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵);   2, 4 -> 16   */

// функция ввода

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int numberA = ReadNumber("Введите число: ");
int numberB = ReadNumber("Введите степень: ");

ToDegree(numberA, numberB);

// Функция возведения в степень
void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine($"{a} в степени {b} = {result}");
}
