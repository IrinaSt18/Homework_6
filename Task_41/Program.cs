/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/ 
int getUserData (string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}
int getPositiveNumbers (int M)
{
    int count = 0;
    for(int i = 0; i< M;i++)
    {
      Console.WriteLine("Введите число: ");
      int Number = int.Parse(Console.ReadLine()!);
    if (Number > 0) 
    {
      count++;
    }
     
    }
    return count; 
}
int M = getUserData("Введите количество чисел: ");
int PositiveNumbers = getPositiveNumbers(M);
Console.WriteLine ($"Пользователь ввел {PositiveNumbers} чисел > 0");
