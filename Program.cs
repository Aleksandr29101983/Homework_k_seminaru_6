//                               ДОМАШНЕЕ ЗАДАНИЕ К СЕМИНАРУ 6

// ЗАДАЧА 41: Пользователь вводит с клавиатуры М чисел. 
//            Посчитайте, сколько чисел больше 0 ввел пользователь

int count = 0;
int CountingPositiveGiven(int M) // работает как надо 
{
    Console.WriteLine("Enter the numbers: ");
    for(int i = 0; i < M; i++)
    {
        if(Convert.ToInt32(Console.ReadLine()) > 0) count += 1;
    }
    return count;
}

Console.WriteLine("If you want to immediately enter the planned number of numbers, enter 'yes', otherwise, to end the program, enter the symbol '='");
if(Console.ReadLine() == "yes")
{
Console.WriteLine("Enter the values of how many numbers you want to enter: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The number of entered numbers greater than zero is equal to {CountingPositiveGiven(M)}");
}
else
{
    
    Console.WriteLine("Enter the numbers: ");
    while(Console.ReadLine() != "=") // работает некорректно - считает через один, а при вводе нечетного количества символов выдает ошибку. Не успел разобраться, в чем проблема
    {
        if(Convert.ToInt32(Console.ReadLine()) > 0) 
        {
        count += 1;
        }
    }
    Console.WriteLine($"The number of entered numbers greater than zero is equal to {count}");
}


// ЗАДАЧА 43: Напишите программу, которая найдет точку пересечения двух прямых, 
//            заданных уравнениями y = k1*x + b1, y = k2*x + b2, 
//            значения b1, k1, b2 и k2 задаются пользователем

// x = (b2 - b1) / (k1 - k2); y = k1 * x + b1.

// void IntersectionPoint(double b1, double k1, double b2, double k2)
// {
//     Console.WriteLine($"For the entered data, the coordinates of the intersection point are: ({(b2 - b1) / (k1 - k2)}; {(b2 - b1) / (k1 - k2) * k1 + b1})");
// }

// Console.WriteLine("Enter the value of b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Enter the value of k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Enter the value of b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Enter the value of k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// if(k1 == k2) Console.WriteLine("There is intersection point for the entered data, since the lines are parallel");
// else IntersectionPoint(b1, k1, b2, k2);





//                                     ЗАДАЧИ НА СЕМИНАРЕ 6

//ЗАДАЧА 1: Напишите программу, которая выполняет "разворот" массива

// int [] FullArray(int N, int minVal, int maxVal)
// {
//     int [] arr = new int [N];
//     for(int i = 0; i < arr.Length; i++)
//     {
//         arr [i] = new Random().Next(minVal, maxVal);
//     }
//     return arr;
// }

// void PrintArray(int [] arr)
// {
//     Console.Write("[");
//     for(int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr [i] + ", ");
//     }
//     Console.WriteLine("\b\b]");
// }

// int [] ArrayReversal(int [] arr)
// {
//     //int temp = 0;
//     for(int i = 0, j = arr.Length - 1; i < j; i++, j--)
//     {
//         int temp = arr [i];
//         arr [i] = arr [j];
//         arr [j] = temp;
//     }
//     return arr;
// }

// int [] newArray = FullArray(5, 0, 10);
// Console.WriteLine("The original array: ");
// PrintArray(newArray);
// int [] reversal = ArrayReversal(newArray);
// Console.WriteLine("Inverted array: ");
// PrintArray(reversal);

//ЗАДАЧА 2: Напишите программу, которая будет преобразовывать десятичное число в двоичное

// string ConvertToBinary(int number)
// {
//     string stroka = "";
//     while(number > 0)
//     {
//        stroka = stroka + number % 2; // stroka = Convert.ToString(number % 2) + stroka;
//        number /= 2;
//     }
//     string akorts = "";
//     for(int i = 0, j = stroka.Length - 1; i < stroka.Length; i++, j--)
//     {
//         akorts += stroka [j];
//     }
//     return akorts;
// }

// Console.WriteLine("Enter any positive integer: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"The number {number} in binary format will look like: {ConvertToBinary(number)}");

// ЗАДАЧА 3: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//           Первые два числа Фибоначчи: a и b (пользователь)

// void Fibonacci(int a, int b, int N)
// {
//     Console.Write($"{a}, {b}, ");
//     for(int i = 0; i < N; i++)
//     {
//     int result = a + b;
//     a = b;
//     b = result;
//     Console.Write(result + ", ");
//     }
//     Console.WriteLine("\b\b.");
// }

// Console.WriteLine("Enter any two positive integers, first smaller one: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter a larger number: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter how many first number to output: ");
// int N = Convert.ToInt32(Console.ReadLine());

// Fibonacci(a, b, N);

//ЗАДАЧА 3: Напишите программу, которая принимает на вход три числа и проверяет, 
//          может ли существовать треугольник с такими сторонами 
//          (каждая сторона треугольника меньше суммы двух других сторон)

// void CheckTringle(int a, int b, int c)
// {
//     if(a + b > c & a + c > b & b + c > a) Console.WriteLine($"A tringle with sides {a}, {b} and {c} exists.");
//     else Console.WriteLine($"A tringle with sides {a}, {b} and {c} does not exist.");
// }

// Console.WriteLine("Enter first number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter second number: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter third number: ");
// int c = Convert.ToInt32(Console.ReadLine());

// CheckTringle(a, b, c);








