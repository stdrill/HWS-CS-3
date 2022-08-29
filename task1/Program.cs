// Найти кубы чисел от 1 до N

Console.WriteLine("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (count <= n){
    Console.Write($"{count * count * count} ");
    count ++;
}
