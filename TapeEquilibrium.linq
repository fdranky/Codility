<Query Kind="Program" />

void Main()
{
	
}

// Define other methods and classes here

public int solution(int[] A) 
{
    int sum = 0;
    var sumArr = new int[A.Length];
    // write your code in C# 6.0 with .NET 4.5 (Mono)
    for (int i = 0; i < A.Length; i++) 
    {
        sum += A[i];    
        sumArr[i] = sum;
    }    
    
    int min = Math.Abs(dict[0] - (sum - dict[0]));
    for (int i = 1; i < A.Length - 1; i++)
    {
        int tape = Math.Abs(sumArr[i] - (sum - sumArr[i]));
        min = tape < min ? tape : min;
    }
    
    return min;
}