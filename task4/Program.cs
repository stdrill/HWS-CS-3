// Написать программу вычисления произведения чисел от 1 до N

int NumProduct (int num){
    int prod = 1;
    for(int i = 1; i < num; i++){
        prod = prod * (i + 1);
    }
    return prod;
}
Console.WriteLine("Enter number N: ");
int num = Convert.ToInt32(Console.ReadLine());
int prod = NumProduct(num);
Console.WriteLine(prod);
