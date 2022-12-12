/*// Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом.
int NumberLength(int number)
{
    int count = 0;

    while (number > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}

int[] ArrayFilling(int[] array, int size, int number)
{
    int index = 0;
    while(index < size)
    {
        array[index] = number % 10;
        number = number / 10;
        index++;
    }
    return array;
}

bool PalindromeCheck(int[] array,int size)
{
    int left = 0;
    int right = size - 1;
    while (left < right)
    {
        if(array[left] == array[right])
        {
            left++;
            right--;
        }
        else
        {
            break;
            
        }
    }
    return(left >= right);
    
    
}

Console.WriteLine("Input a number ");
int num = Convert.ToInt32(Console.ReadLine());
int length = NumberLength(num);
if (length == 1)
{
    Console.WriteLine("true");
}

else
{
    int[] array = new int[length];
    array = ArrayFilling(array, length, num);
    Console.WriteLine(PalindromeCheck(array, length));
}
*/






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



/*// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int[] Cubes(int number)
{
    int[] cubesArray = new int[number];
    int index = 0;
    int current = 1;
    
    while (index < number)
    {
        cubesArray[index] = (int)Math.Pow(current, 3);
        index++;
        current++;
    }
    return cubesArray;
}

void ReturnCubes(int[] array)
{
    int index = 0;
    while(index < array.Length - 1)
    {
        Console.Write($"{array[index]}, ");
        index++;
    }
    Console.Write($"{array[index]}.");
}

Console.WriteLine("Input a number ");
int num = Convert.ToInt32(Console.ReadLine());
int [] array = Cubes(num);
ReturnCubes(array);
*/