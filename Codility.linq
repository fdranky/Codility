<Query Kind="Program" />

void Main()
{
	int[] numbers = new int[]{1,2,3};
	CyclicRotation(numbers, 1).Dump();
}

public int[] CyclicRotation(int[] numbers, int k)
{
	int[] copy = new int[numbers.Length];
	for(int i = 0; i < numbers.Length; i++)
	{
		int shift = (k + i) % numbers.Length;
		copy[shift] = numbers[i];
	}
	
	return copy;
}

// Define other methods and classes here
