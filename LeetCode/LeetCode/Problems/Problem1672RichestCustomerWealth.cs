namespace LeetCode.Problems.Problem1672RichestCustomerWealth;

public class Problem1672RichestCustomerWealth
{
    public int MaximumWealth(int[][] accounts) {
        int richestCustomerWealth = 0;
        foreach (var account in accounts)
        {
            int currentAmountOfMoney = 0;
            foreach (var amountOfMoney in account)
            {
                currentAmountOfMoney += amountOfMoney;
            }
            if(currentAmountOfMoney > richestCustomerWealth)
                richestCustomerWealth = currentAmountOfMoney;
        }
        return richestCustomerWealth;
    }
}