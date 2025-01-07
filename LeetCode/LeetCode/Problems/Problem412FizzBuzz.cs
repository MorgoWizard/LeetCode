﻿namespace LeetCode.Problems.Problem412FizzBuzz;

public class Problem412FizzBuzz
{
    public IList<string> FizzBuzz(int n) {
        IList<string> result = new List<string>();
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                result.Add("FizzBuzz");
                continue;
            }

            if (i % 5 == 0)
            {
                result.Add("Buzz");
                continue;
            }
            
            if (i % 3 == 0)
            {
                result.Add("Fizz");
                continue;
            }
            
            result.Add(i.ToString());
        }

        return result;
    }
}