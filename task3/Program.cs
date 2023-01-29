//Задача 29 Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

//5 -> [1, 2, 5, 7, 19]; 3 -> [6, 1, 33]

Console.WriteLine("Введите число длинны массива: ");
int LenNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива: ");
int MaxNumber = Convert.ToInt32(Console.ReadLine());
Console.Write($"{LenNumber} -> ");

int[] randomArray = new int[LenNumber];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,MaxNumber);
    Console.Write(randomArray[i] + " ");
}
