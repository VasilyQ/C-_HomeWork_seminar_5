// Задача 34: Задайте массив заполненный случайными положительными
//  трёхзначными числами. Напишите программу,
//   которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] ArrayRandom(int Lenght, int MinNumber, int MaxNumber)
{
    int[] array = new int[Lenght];
    for(int i = 0; i < Lenght; i++)
    {
        array[i] = Random.Shared.Next(MinNumber, MaxNumber);
    }
    
    return array;
}

int EvenNumbers(int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            result = result + 1;
        } 
    }
    return result;
}

int[] ResultArray = ArrayRandom(4, 100, 1000);
int ResultSum = EvenNumbers(ResultArray);
Console.WriteLine($"{string.Join(',', ResultArray)} -> {ResultSum}");





