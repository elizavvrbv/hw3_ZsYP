// Задача 23. 
System.Console.WriteLine("Задание 23");
double GetDouble(int N){
    return (Math.Pow(N, 3));
}
System.Console.WriteLine("Ведите число N");
int N = int.Parse(Console.ReadLine());
for (int i = 1; i < (N +1); i++)
{
    System.Console.WriteLine(GetDouble(i));

}

// Задача 21.
double GetDist(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Round((Math.Sqrt(Math.Pow((x2 - x1),2 )) + (Math.Sqrt(Math.Pow((y2 - y1),2)) + ((Math.Pow((z2 - z1), 2))))), 3);
}
System.Console.WriteLine("ВВедите координаты первой точки построчно x1, y1, z1 соответственно");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("ВВедите координаты второй точки построчно x2, y2, z2 соответственно");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());
System.Console.WriteLine($"Расстояние между точками {GetDist(x1, y1, x2, y2, z1, z2)}");


// Задача 19.
System.Console.WriteLine("Задача 19");
string GetPali(int N)
{
    if ((N / 10000) == (N % 10))
    {
        if (((N / 1000) % 10) == ((N % 100) / 10))
        {
        return "Число является палиндромом";
        }
        else
        {
        return "Число не явялется палиндромом";
        }
}
else
{
    return "Число не является палиндромом";
}
}
System.Console.WriteLine($"Введите пятизначное число");
int N1 = int.Parse(Console.ReadLine());
System.Console.WriteLine(GetPali(N1));