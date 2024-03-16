int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size]; // Массив array на size элементов
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}


int GetEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++; // count = count + 1
        }
    }
    return count;
}


// Вызов функции
Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] res = CreateArray(N, 100, 999);
// CreateArray(N, 10, 99) => массив, размер: N
// каждый элемент: число от 100 до 999 вкл-но
Console.WriteLine($"Массив: [ {string.Join("; ", res)} ]");
Console.WriteLine($"Even numbers: {GetEvenNumbers(res)}");
