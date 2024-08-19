//Arrays
//Array Insertiom

//Inserting at the End of an Array

int[] intArray = new int[6];

//Make a variable to keep the length because .Length is based off capacity and does track the actual index
int length = 0;

//This adds data for us
for (int i = 0; i < 3; i++){
    intArray[length]= i;
    length++;
}

intArray[length] = 8;
//int value0 = 0;

// Insert at the star of an Array

for (int i = 3; i>=0; i--){
    //this is moving over all the values
    intArray[i + 1]= intArray[i];
}

intArray[0] = 8;
//int value = 0;


// Insert anywhere in Array

for (int i = 4; i >= 2; i--){
    //Shift each element one position to the right
    intArray[i+1] = intArray[i];
}

intArray[2] = 8;