// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.Write("Введите значения k1, b1, k2 и b2 через пробел: ");
string[] strInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int k1 = int.Parse(strInput[0]), b1 = int.Parse(strInput[1]),
    k2 = int.Parse(strInput[2]), b2 = int.Parse(strInput[3]);

if (IfLinesIsParallel(k1, b1, k2, b2))
{
    if (b1 != b2) Console.Write("Система не имеет решения, линии параллельны.");
    else Console.Write("Система имеет бесконечное множество решений, прямые совпадают.");
}
else
{
    double[] coordArray = GetIntersectionPointStraightLines(k1, b1, k2, b2);
    Console.Write($"({String.Join("; ", coordArray)})");
}


bool IfLinesIsParallel(double k1, double b1, double k2, double b2)
{
    return (k1 - k2 == 0);
}

double[] GetIntersectionPointStraightLines(double k1, double b1, double k2, double b2)
{
    double[] result = new double[2];
    result[0] = (-b1 + b2) / (k1 - k2);
    result[1] = (k2 * result[0] + b2);
    return result;
}