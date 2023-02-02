// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] InputСoef(string str)
{
    double[] number = new double[4];
    string text;
    newTry:
    Console.Write(str);
    text = Console.ReadLine();
    string[] split = text.Split(' ');
    for (int i = 0; i <= 3; i++)
    {
        if (!(double.TryParse(split[i], out number[i])) || split.Length != 4)
        {
            System.Console.WriteLine("Введены некорректные данные , повторите ввод");
            goto newTry;
        }
    }
     return number;
}

int Intersection(double[] coef, out double x, out double y)
{
    x = 0;
    y = 0;

    if ((coef[0] == coef[2]) && (coef[1] == coef[3])) //если k1=k2, b1=b2, прямые совпадают
    {
        return -1;
    }
    else if ((coef[0] == coef[2])) //если k1=k2, прямые параллельны
    {
        return 0;
    }
    else
    {
        x = (coef[3] - coef[1]) / (coef[0] - coef[2]);
        y = (coef[0] * (coef[3] - coef[1])) / (coef[0] - coef[2]) + coef[1];
        return 1;
    }
}

double[] array = InputСoef("Введи коэффициенты k1 b1 k2 b2 через пробел: ");

int IsIntersect = Intersection(array, out double x, out double y);

if (IsIntersect == 1)   //пересекаются
{
    System.Console.WriteLine($"Прямые y={array[0]}x+{array[1]}, y={array[2]}x+{array[3]} пересекаются в точке [{x}:{y}]");
}
else if (IsIntersect == -1)  //совпадают
{
    System.Console.WriteLine($"Прямые y={array[0]}x+{array[1]}, y={array[2]}x+{array[3]} совпадают");
}
else if (IsIntersect == 0) //параллельны
{
    System.Console.WriteLine($"Прямые y={array[0]}x+{array[1]}, y={array[2]}x+{array[3]} параллельны, не пересакаются");
}