//Arrays
//Arrays Deletions

int[] intArray = new int[9];

int length = 0;

for(int i = 0; i < 6; i++){
    intArray[length] = i;
    length++;
}

//length--;

// Deleting from the Start
// for (int i = 1; i < length; i++){
//     intArray[i - 1] = intArray[i];
// }

// length--;

for (int i = 3; i < length; i++){
    intArray[i - 1] = intArray[i];
}

length--;

for(int i = 0; i < length; i++){
    Console.WriteLine(intArray[i]);
}


