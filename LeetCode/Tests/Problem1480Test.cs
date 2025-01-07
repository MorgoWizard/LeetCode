using LeetCode.Problem1480RunningSumOf1DArray;


public class Problem1480Tests
{
    private Problem1480RunningSumOf1DArray _problem1480RunningSumOf1DArray;
    
    [SetUp]
    public void Setup()
    {
        _problem1480RunningSumOf1DArray = new Problem1480RunningSumOf1DArray();
    }

    [Test]
    public void Example1()
    {
        int[] input = [1, 2, 3, 4];
        int[] expected = [1,3,6,10];
        Assert.That(_problem1480RunningSumOf1DArray.RunningSum(input), Is.EqualTo(expected));
    }
    
    [Test]
    public void Example2()
    {
        int[] input = [1,1,1,1,1];
        int[] expected = [1,2,3,4,5];
        Assert.That(_problem1480RunningSumOf1DArray.RunningSum(input), Is.EqualTo(expected));
    }
    
    [Test]
    public void Example3()
    {
        int[] input = [3,1,2,10,1];
        int[] expected = [3,4,6,16,17];
        Assert.That(_problem1480RunningSumOf1DArray.RunningSum(input), Is.EqualTo(expected));
    }
}