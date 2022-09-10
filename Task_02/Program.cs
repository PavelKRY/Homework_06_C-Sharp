// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// Рекомендую учесть три возможных случая расположения двух прямых.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Введите коэфициент b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэфициент k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэфициент b2");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэфициент k2");
int k2 = Convert.ToInt32(Console.ReadLine());

if(k1%k2==0)
{
double deltak1k2 = k1/k2;
    if(b1%b2==0)
    {
    double deltab1b2=b1/b2;
        if(deltab1b2==deltak1k2)
        {
        Console.WriteLine("Прямые совпадают, все точки лежат на 1 прямой");
        }
    }
    else
    {
        Console.WriteLine("Прямые парралельны, точек пересечения нет");
    }
}

else if (k2%k1==0)
{
double deltak2k1 = k2/k1;
    if(b2%b1==0)
    {
    double deltab2b1=b2/b1;
        if(deltab2b1==deltak2k1)
        {
        Console.WriteLine("Прямые совпадают, все точки лежат на 1 прямой");
        }
    }
    else
    {
        Console.WriteLine("Прямые парралельны, точек пересечения нет");
    }
}

else
{
    // k1x + b1 = k2x + b2
    // k1x-k2x = -b1 + b2
    // x(k1-k2) = b2 - b1
    // x = (b2-b1)/(k1-k2)
    // y = k1*x + b1
    double l1 = b1;
    double l2 = b2;
    double i1 = k1;
    double i2 = k2;

    double x = (l1-l2)/(i2-i1);
    double y = i1 * x + l1;
    Console.WriteLine("Точка пересечения прямых: (" + x + " , " + y + ")");
}
