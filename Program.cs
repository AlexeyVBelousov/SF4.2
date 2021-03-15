using System;

namespace SF4._2
{
    class Program
    {
		static void Main(string[] args)
		{
			int t = 0;
			do
			{
				Console.WriteLine("Итерация {0}.", t);
				Console.WriteLine("Введите цвет: ");
				var color = Console.ReadLine();

				switch (color)
				{
					case "red":
						Console.BackgroundColor = ConsoleColor.Red;
						Console.ForegroundColor = ConsoleColor.Black;

						Console.WriteLine("Your color is red!");
						break;

					case "green":
						Console.BackgroundColor = ConsoleColor.Green;
						Console.ForegroundColor = ConsoleColor.Black;

						Console.WriteLine("Your color is green!");
						break;

					case "cyan":
						Console.BackgroundColor = ConsoleColor.Cyan;
						Console.ForegroundColor = ConsoleColor.Black;

						Console.WriteLine("Your color is cyan!");
						break;

					case "yellow":
						Console.BackgroundColor = ConsoleColor.Yellow;
						Console.ForegroundColor = ConsoleColor.Red;

						Console.WriteLine("Your color is yellow!");
						break;
					default:
						continue;
				}
				t++;
			} while (t <= 2);
			Console.WriteLine("Конец цикла, счетчик = {0}.", t);
		}
	}
}
