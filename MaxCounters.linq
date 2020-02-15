<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here
class Solution 
{
    public int[] solution(int N, int[] A) 
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        var arr = new int[N];
        int max = 0;
        int lastMax = 0;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] == N + 1) 
            {
                lastMax = max;
            }
            else 
            {
                int index = A[i] - 1;
                arr[index] = arr[index] < lastMax ? lastMax : arr[index];
                arr[index]++;
                max = max > arr[index] ? max : arr[index];
            }
        }
        
        if (lastMax > 0)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                arr[j] = lastMax > arr[j] ? lastMax : arr[j];    
            }    
        }
        
        return arr;
    }
}