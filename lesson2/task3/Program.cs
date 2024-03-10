//int n = 10;
int[] array = [5, 6, 9, 12, 45, 5, 8, 7, 6, 3];
int i = 0;

while(i < array.Length) {
    if(array[i] % 2 == 0) {
        Console.Write($"{array[i]} ");
    }
    i++;
}