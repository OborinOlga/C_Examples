void FillArray(int[] collection)

{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    { 
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] Array = new int[10];

FillArray(Array);
PrintArray(Array);