<Query Kind="Program" />

void Main()
{
	// sum might cause overflow
	int[] arr = new int[]{1,2,3,4,6};
	Console.WriteLine(MissingElement(arr));
}

public int MissingElement(int[] arr)
{
	long n = arr.Length + 1;
	var val = n * (n + 1) / 2;
	for (int i = 0; i < arr.Length; i++) 
	{
		val -= arr[i];
	}
	return (int)val;
}

// Define other methods and classes here
