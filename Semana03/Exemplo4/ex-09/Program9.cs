//Binary Searc

int[] intArray = { -4, 2, 6, 8, 12, 16};

Console.WriteLine(BinarySearch(intArray, 2));

int BinarySearch(int[] intArray, int i){
    int start = 0;
    int end = intArray.Length;
    while (start < end)
    {
        int midpoint = (start + end) / 2;

        if(intArray[midpoint] == i)
        {
            return midpoint;
        }
        else if (intArray[midpoint + 1] < i)
        {
            start = midpoint + 1;
        }
        else
        {
            end = midpoint;
        }
    }
    return -1;
}