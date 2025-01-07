namespace LeetCode.Problems._1480_Running_Sum_Of_1d_Array;

public class Problem1480RunningSumOf1DArray {
    public int[] RunningSum(int[] nums) {
        int[] result = new int[nums.Length];
        for (int currentNum = 0; currentNum < nums.Length; currentNum++)
        {
            if (currentNum - 1 < 0)
            {
                result[currentNum] = nums[currentNum];
            }
            else
            {
                result[currentNum] = result[currentNum - 1] + nums[currentNum];
            }
        }
        return result;
    }
}