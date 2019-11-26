<Query Kind="Program" />

void Main()
{
	Console.WriteLine(FrogJump(30, 130, 20));
}

public int FrogJump(int x, int y, int d)
{
	return (int)Math.Ceiling((decimal)(y - x) / d);
}

// Define other methods and classes here
