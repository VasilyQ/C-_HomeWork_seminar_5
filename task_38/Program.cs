// Задача 38: Задайте массив вещественных чисел. Найдите 
// разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int[] ArrayRandom(int Length, int MinNumber, int MaxNumber)
{
    int[] array = new int[Length];
    for(int i = 0; i < Length; i++)
    {
        array[i] = Random.Shared.Next(MinNumber, MaxNumber);
    }
    
    return array;
}


int DifferenceNumbers(int[] array)
{
    int max = array[0];
    int min = array[0];

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];
        else if(array[i] < min) min = array[i];
    }
    Console.WriteLine($"min = {min}, max = {max}");
    int DifNumbers = max - min;

    return DifNumbers;
}

int[] ArrayNumbers =  ArrayRandom(5, -5, 5);
int Result = DifferenceNumbers(ArrayNumbers);

Console.WriteLine($"{string.Join(',', ArrayNumbers)} -> {Result}");