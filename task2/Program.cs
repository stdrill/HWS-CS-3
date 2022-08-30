// Возведите число А в натуральную степень B используя цикл

Console.Write("Enter number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number B: ");
int b = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int a, int b) {
    int result = a;
    if (b != 0){
    for(int i = 1; i < b; i++) {
        result = result * a;
    }
    return result;
    } else {
        return 0;
        }
}
int res = Exponentiation(a, b);
Console.WriteLine(res);
