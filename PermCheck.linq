<Query Kind="Program">
  <Namespace>System</Namespace>
  <Namespace>System.Collections.Generic</Namespace>
</Query>

void Main()
{
	
}

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int setSolution(int[] A) 
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        var set = new HashSet<int>();
        for (int i = 0; i < A.Length; i++) 
        {
            if (A[i] <= A.Length)
            {
                set.Add(A[i]);
            }
        }
        
        return A.Length == set.Count ? 1 : 0;
    }
	
	public int solution(int[] A) 
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int count = 0;
        var arr = new int[A.Length];
        for (int i = 0; i < A.Length; i++) 
        {
            if (A[i] <= A.Length)
            {
                if (arr[A[i] - 1] < 1) 
                {
                    arr[A[i] - 1]++;
                    count++;
                } 
                else 
                {
                    return 0;    
                }
            }
			else 
			{
				return 0;
			}
        }
        
        return A.Length == count ? 1 : 0;
    }
}