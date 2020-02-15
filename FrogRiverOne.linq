<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public int solution(int X, int[] A) 
{
    // write your code in C# 6.0 with .NET 4.5 (Mono)
    var bridge = new HashSet<int>();
    for (int i = 0; i < A.Length; i++) 
    {
        if (A[i] <= X)
        {
            bridge.Add(A[i]);
            if (bridge.Count == X) return i;
        }   
    }
    
    return -1;
}