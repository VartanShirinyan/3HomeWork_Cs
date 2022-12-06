/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 

l = √ (x 2 - x 1) 2+ (y 2 - y 1) 2+ (z 2 - z 1) 2
*/

Console.WriteLine("Enter the coordinates X (Введите координаты X) ");
int x1 = int.Parse(Console.ReadLine());
int x2 = int.Parse(Console.ReadLine());
int x3 = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the coordinates Y (Введите координаты Y) ");
int y1 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int y3 = int.Parse(Console.ReadLine());

double result = Math.Round(Math.Sqrt(Math.Pow((x1 - y1), 2) + Math.Pow((x2 - y2), 2) + Math.Pow((x3 - y3), 2)), 2);

Console.WriteLine($"{result}");