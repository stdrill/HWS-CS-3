// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

void FillArray(int[] arr){
    for(int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(-9,10);
}
void PrintArray(int[] arr){
    for (int i = 0; i < arr.Length; i++) Console.Write(arr[i]+" ");
}
int CountArray(int[] arr){
    int count = 0;
    for(int i = 0; i < arr.Length; i++){
        if(arr[i] > 0) count = count + arr[i]; 
    }
    return count;
}

int[] arr = new int[12];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();
int count = CountArray(arr);
Console.WriteLine($"Сумма положительных элементов: {count}");