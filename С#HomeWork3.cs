// Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом.
int NumberLenght(int number)
{
int count = 0;

    while (number > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}

int[] ArrayFilling(int[] Array, int size)
{

}

int Num = Convert.ToInt32(Console.ReadLine());
int lenght = NumberLenght(Num);





/* //Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// void Distance(double xA, double yA, double zA, double xB, double yB, double zB)
// {
//  double length = Math.Sqrt((Math.Pow((xA - xB),2) + Math.Pow((yA - yB),2)) + Math.Pow((zA - zB),2));
//  Console.WriteLine($"distance between points is {Math.Round(length, 3)}");
// }

// Console.WriteLine("input coordinates in the following order: xA, yA, zA, xB, yB, zB");
// double xA = Convert.ToDouble(Console.ReadLine());
// double yA = Convert.ToDouble(Console.ReadLine());
// double zA = Convert.ToDouble(Console.ReadLine());
// double xB = Convert.ToDouble(Console.ReadLine());
// double yB = Convert.ToDouble(Console.ReadLine());
// double zB = Convert.ToDouble(Console.ReadLine());

// Distance(xA, yA, zA, xB, yB, zB);
*/