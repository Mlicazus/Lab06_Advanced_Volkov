// System.Console.Write("Введите первое число: ");
// int a = int.Parse(System.Console.ReadLine());
// System.Console.Write("Введите второе число: ");
// int b = int.Parse(System.Console.ReadLine());
// System.Console.Write("Введите третье число: ");
// int c = int.Parse(System.Console.ReadLine());
// System.Console.WriteLine();
// int[] massif = { a, b, c };
// foreach (int number in massif)
// {
//     System.Console.WriteLine($"{number} простое: {IsPrime(number)}");
// }
// System.Console.WriteLine();
// System.Console.WriteLine($"Максимум из трёх: {FindMax(a, b, c)}");
// System.Console.WriteLine($"Максимум из первых двух: {FindMax(a, b, -1)}");
// System.Console.WriteLine($"Среднее арифметическое: {CalculateAverage(a, b, c)}");
// bool IsPrime(int number)
// {
//     bool flag = true;
//     for (int i = 2; i < number - 1; i++)
//     {
//         if (number < 2)
//         {
//             flag = false;
//             break;
//         }
//         if (number % i == 0)
//         {
//             flag = false;
//             break;
//         }
//     }
//     return flag;
// }
// int FindMax(int a, int b, int c)
// {
//     int max = a;
//     int[] massif = { a, b, c };
//     foreach (int number in massif)
//     {
//         if (number > max)
//         {
//             max = number;
//         }
//     }
//     return max;
// }
// double CalculateAverage(int a, int b, int c)
// {
//     return (a + b + c) / 3;
// }