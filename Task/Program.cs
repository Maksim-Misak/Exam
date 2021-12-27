int[] CreateArray()
{
    int[] array = new int[10];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    return array;
}

int EvenNumberCount(int[] coll)
{
    int evenNumberCount = 0;
    for (int i = 0; i < coll.Length; i++)
    {
        if (coll[i] % 2 == 0)
        {
            evenNumberCount++;
        }
    }
    return evenNumberCount;
}