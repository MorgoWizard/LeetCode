using LeetCode.Problems;

public class Problem1342Tests
{
    private Problem1342NumberOfStepsToReduceNumberToZero _problem1342NumberOfStepsToReduceNumberToZero;

    [SetUp]
    public void Setup()
    {
        _problem1342NumberOfStepsToReduceNumberToZero = new Problem1342NumberOfStepsToReduceNumberToZero();
    }
    
    [Test]
    public void Example1()
    {
        int input = 14;
        int expected = 6;
        Assert.That(_problem1342NumberOfStepsToReduceNumberToZero.NumberOfSteps(input), Is.EqualTo(expected));
    }
    
    [Test]
    public void Example2()
    {
        int input = 8;
        int expected = 4;
        Assert.That(_problem1342NumberOfStepsToReduceNumberToZero.NumberOfSteps(input), Is.EqualTo(expected));
    }
    
    [Test]
    public void Example3()
    {
        int input = 123;
        int expected = 12;
        Assert.That(_problem1342NumberOfStepsToReduceNumberToZero.NumberOfSteps(input), Is.EqualTo(expected));
    }
}