<Query Kind="Program" />

void Main()
{
	int input = 32;
	Console.WriteLine(Convert.ToString(input, 2));
	Console.WriteLine(BinaryGap(input));
}

public int BinaryGap(int input)
{
	int count = 0;
	int max = 0;
	while(input > 0)
	{
		if ((input & 1) == 1)
		{
			count = 0;
			input = input >> 1;
			while ((input & 1) == 0 && input > 0) 
			{
				count++;
				if (count > max) 
				{
					max = count;
				}
				input = input >> 1;
			}
		} 
		else
		{
			input = input >> 1;
		}
	}
	
	return max;
}

// Define other methods and classes here
