int n = 5;
int[] array = {2, 8, 9, 7, 6};
int i = 0;
int max = array[0];

while(i < array.Length) {
    if(array[i] > max) {
        max = array[i];
    }
    i++;
    }
Console.WriteLine(max);

