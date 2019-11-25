<Query Kind="Program" />

void Main()
{
	int[] input = new int[] {9, 3, 9, 3, 7, 9, 3, 9, 3};
	Console.WriteLine(Unpaired(input));
}

public int Unpaired(int[] numbers)
{
	int current = 0;
	for(int i = 0; i < numbers.Length; i++)
	{
		current ^= numbers[i];
	}
	
	return current;
}

// Define other methods and classes here
