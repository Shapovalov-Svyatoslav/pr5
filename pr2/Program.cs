internal class Program
{
	private static void Main(string[] args)
	{
		Console.Write("Введіть число: ");
		int limit = int.Parse(Console.ReadLine());

		Console.WriteLine($"Числа Армстронга до {limit}:");

		for (int i = 1; i <= limit; i++)
		{
			if (IsArmstrongNumber(i))
			{
				Console.WriteLine(i);
			}
		}
	}

	static bool IsArmstrongNumber(int number)
	{
		int sum = 0;
		int temp = number;
		int digits = number.ToString().Length;

		while (temp > 0)
		{
			int digit = temp % 10;
			sum += (int)Math.Pow(digit, digits);
			temp /= 10;
		}

		return sum == number;
	}
}