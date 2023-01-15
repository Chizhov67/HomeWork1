# Задача 2

 int a, b;
Console.Write("Введите a: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите b: ");
b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
				Console.WriteLine("max " + a + " min " + b);
			}
 else if (a < b)
 {
				Console.WriteLine("max " + b + " min " + a);
			}

 Console.ReadLine();   

 # Задача 4

 int a, b, c, max;
 Console.Write("Введите число 1: ");
 a = Convert.ToInt32(Console.ReadLine());

 Console.Write("Введите число 2: ");
 b = Convert.ToInt32(Console.ReadLine());

 Console.Write("Введите число 3: ");
 c = Convert.ToInt32(Console.ReadLine());

max = a;

if	(max < b)
{
				max = b;
			}

if (max < c)
{
				max = c;
			}

Console.WriteLine(max);
Console.ReadLine();

# Задача 6

int a;
a = Convert.ToInt32(Console.ReadLine());

if (a / 2 == 0)
{
				Console.WriteLine("да");
			}

else
{
				Console.WriteLine("нет");
			}

Console.ReadLine();

# Задача 8

int N;
N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < N + 1; i++)

if (i / 2 == 0)
{
					Console.Write(i + " ");
				}
Console.ReadKey();

