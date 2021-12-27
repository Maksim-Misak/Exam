int[] CreateArray()
{
    int[] array = new int[10];
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(-100, 100);
    return array;
}

int EvenNumberCount(int[] coll)
{
    int evenNumberCount = 0;
    for (int i = 0; i < coll.Length; i++)
    {
        if (coll[i] % 2 == 0) evenNumberCount++;
    }
    return evenNumberCount;
}

int[] NewArray(int[] coll, int evenNumber)
{
    int[] newArray = new int[evenNumber];
    int i = 0;
    while (i < newArray.Length)
    {
        for (int j = 0; j < coll.Length; j++)
        {
            if (coll[j] % 2 == 0)
            {
                newArray[i] = coll[j];
                i++;
            }
        }
    }
    return newArray;
}

int[] initialArray = CreateArray();
int[] finishedArray = NewArray(initialArray, EvenNumberCount(initialArray));
