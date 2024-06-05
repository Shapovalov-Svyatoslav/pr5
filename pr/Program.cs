internal class Program
{
	private static void Main(string[] args)
	{
		var number = Convert.ToDouble(Console.ReadLine());

		if (IsTwoPow(number))
		{
			Console.WriteLine($"{number} є степем двійки");
		}
		else
		{
			Console.WriteLine($"{number} не є степенем двійки");
		}
	}

	private static bool IsTwoPow(double number)
	{
		while (number >= 2)
		{
			if (number == 2)
			{
				return true;
			}
			number /= 2;
		}
		return false;
	}
}