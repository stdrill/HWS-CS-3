// Показать кубы чисел, заканчивающихся на четную цифру

void FillArray(int[] arr){
    for(int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(10,50);
}
void PrintArray(int[] arr){
    for (int i = 0; i < arr.Length; i++) Console.Write(arr[i]+" ");
}
int[] Exponentiation(int[] arr){
    for(int i = 0; i < arr.Length; i++){
        if (arr[i] %2 ==0 ) arr[i] = arr[i] * arr[i] * arr[i];
    } 
    return arr;
}
int[] arr = new int[5];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();
int[] expon = Exponentiation(arr);
PrintArray(expon);