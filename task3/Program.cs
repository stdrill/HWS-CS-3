// Подсчитать сумму цифр в числе

int SumDig(int num){
    int sum = 0;
    while(num > 0){
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}
Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = SumDig(number);
Console.WriteLine(sum);