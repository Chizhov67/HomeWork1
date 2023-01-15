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
