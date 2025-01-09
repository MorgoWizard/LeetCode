using LeetCode.Problems;

public class Problem1672Tests
{
    private Problem1672RichestCustomerWealth _problem1672RichestCustomerWealth;
    
    [SetUp]
    public void Setup()
    {
        _problem1672RichestCustomerWealth = new Problem1672RichestCustomerWealth();
    }

    [Test]
    public void Example1()
    {
        int[][] input = [[1,2,3],[3,2,1]];
        int expected = 6;
        Assert.That(_problem1672RichestCustomerWealth.MaximumWealth(input), Is.EqualTo(expected));
    }
    
    [Test]
    public void Example2()
    {
        int[][] input = [[1,5],[7,3],[3,5]];
        int expected = 10;
        Assert.That(_problem1672RichestCustomerWealth.MaximumWealth(input), Is.EqualTo(expected));
    }
    
    [Test]
    public void Example3()
    {
        int[][] input = [[2,8,7],[7,1,3],[1,9,5]];
        int expected = 17;
        Assert.That(_problem1672RichestCustomerWealth.MaximumWealth(input), Is.EqualTo(expected));
    }
}