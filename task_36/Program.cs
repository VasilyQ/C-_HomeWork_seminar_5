// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] ArrayRandom(int Lenght, int MinNumber, int MaxNumber)
{
    int[] array = new int[Lenght];
    for(int i = 0; i < Lenght; i++)
    {
        array[i] = Random.Shared.Next(MinNumber, MaxNumber);
    }
    
    return array;
}


int ArraySum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

int[] ArrayResult = ArrayRandom(4, -100, 101);
int Sum = ArraySum(ArrayResult);

Console.WriteLine($"{string.Join(',', ArrayResult)} -> {Sum}");