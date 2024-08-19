//Bubble Sort

int[] intArray = new int[] {6, 4, 1, 7, 5, 2, 3 };
int[] value = new int[intArray.Length];

value = BubbleSort(intArray);

for (int i = 0; i < 7; i++){
    Console.WriteLine(value[i]);
}

int[] BubbleSort(int[] array)
{
    // temporary
    int temp;

    for (int pointer = 0; pointer < array.Length; pointer++)
    {
        for (int sort = 0; sort < array.Length - 1; sort++)
        {
            if(array[sort] > array[sort + 1])
            {
                temp = array[sort + 1];  
                array[sort + 1] = array[sort];
                array[sort] = temp;
            }
        }
    }
    return array;
}