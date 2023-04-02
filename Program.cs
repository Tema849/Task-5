// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// Пример:
// [345, 897, 568, 234] -> 2.

// Task:

//Console.WriteLine("Введите длинну массива: ");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] numbers = new int[size];
//RandomNumbers(numbers);
//Console.WriteLine("В этом массиве: ");
//PrintArray(numbers);
//
//void RandomNumbers(int[] numbers)
//{
//    for(int i = 0; i < size; i++)
//    {
//        numbers[i] = new Random().Next(100, 1000);
//    }
//}
//
//int count =0;
//for (int x = 0; x < numbers.Length; x++)
//{
//    if (numbers[x] % 2 == 0)
//    count++;
//}    
//Console.WriteLine($"из {numbers.Length} чисел, {count} чётных");
//
//void PrintArray(int[] numbers)
//{
//    Console.Write("[ ");
//    for(int i = 0; i < numbers.Length; i++)
//    {
//        Console.Write(numbers[i] + " ");
//    }
//    Console.Write("]");
//    Console.WriteLine();
//}
    

// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// Пример:
// [3, 7, 23, 12] -> 19.
// [-4, -6, 89, 6] -> 0.

// Task:

Console.WriteLine($"Введите длинну массива: ");
int ElementNumbers = Convert.ToInt32(Console.ReadLine());
int randomNumber = RandomNumbers(ElementNumbers, 1, 10);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {randomNumber}");

int RandomNumbers(int ElementNumbers, int min, int max)
{
    int[] randomNumber = new int[ElementNumbers];
    int sumElements = 0;
    Console.Write("Получившийся массив: ");
    for (int i = 0; i < randomNumber.Length; i++)
    {
        randomNumber[i] = new Random().Next(min, max);
        Console.Write(randomNumber[i] + " ");
        if (i % 2 != 0)
        {
            sumElements = sumElements + randomNumber[i];
        }
    }
    return sumElements;
}



// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// Пример:
// [3 7 22 2 78] -> 76.

// Task:



