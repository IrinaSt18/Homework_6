/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/ 
int getUserData (string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}
string getIntersectionPoint(double k1,double b1,double k2,double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    string IntersectionPoint = $"{x} ; {y}";
    return IntersectionPoint;
}
double k1 = getUserData ("Введите значение k1: ");
double b1 = getUserData ("Введите значение b1: ");
double k2 = getUserData ("Введите значение k2: ");
double b2 = getUserData ("Введите значение b2: ");
string IntersectionPoint = getIntersectionPoint(k1,b1,k2,b2);
Console.WriteLine($"Точка пересечения прямых ({IntersectionPoint})");
