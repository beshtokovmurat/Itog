//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Console.Clear();
Console.Write("Введите количество элементов массива N: ");
int N = Convert.ToInt32(Console.ReadLine());
string[] A = new string[N];
Console.WriteLine("Введите элементы массива: ");
for (int i = 0; i < N; i++)
{
    Console.Write($"A[{i}] = ");
    A[i] = Convert.ToString(Console.ReadLine());
}

void Printmassiv(string[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.WriteLine($"A[{i}] = {a[i]}");
    }
}
