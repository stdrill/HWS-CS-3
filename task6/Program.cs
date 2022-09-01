// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

void FillArray(int[] arr){
    for(int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(0,2);
}
void PrintArray(int[] arr){
    for (int i = 0; i < arr.Length; i++) Console.Write(arr[i]+" ");
}
int[] arr = new int[8];
FillArray(arr);
PrintArray(arr);