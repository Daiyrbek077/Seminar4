int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size]; // Массив array на size элементов
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

// Перевернить массив:
int[] GetReverseReading(int[] arr)
{
    int[] array = new int[arr.Length];
    for (int i = 0, j = arr.Length-1; i < arr.Length; i++, j--)
    {
        array[i] = arr[j];
    }
    return array;
}

// Получить массив случайными числами от 0 до 100:
int[] result = CreateArray(10, 0, 100);

// перевернить массив
int[] revers = GetReverseReading(result);


Console.WriteLine($"Массив ДО: [ {string.Join(", ", result)} ]  => ");
Console.WriteLine($"Массив ПОСЛЕ: [ {string.Join(", ", revers)} ]");