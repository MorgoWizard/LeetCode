namespace LeetCode.Problems;

public class Problem1342NumberOfStepsToReduceNumberToZero
{
    public int NumberOfSteps(int num) {
        int steps = 0;
        
        while (num > 0)
        {
            steps++;
            if (num % 2 == 0)
            {
                num /= 2;
            }
            else
            {
                num -= 1;
            }
        }

        return steps;
    }
}