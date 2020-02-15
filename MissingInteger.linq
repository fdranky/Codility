<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
public int solution(int[] A) 
{
    // write your code in C# 6.0 with .NET 4.5 (Mono)
    var set = new HashSet<int>();
    for (int i = 0; i < A.Length; i++)
    {
        if (A[i] > 0)
        {
            set.Add(A[i]);    
        }   
    }
    
    for (int j = 1; j <= A.Length + 1; j++) 
    {
        if (!set.Contains(j))
        {
            return j;
        }
    }
    
    return 1;
}