using LeetCode.Problems.Problem412FizzBuzz;

public class Problem412Tests
{
    private Problem412FizzBuzz _problem412FizzBuzz;
    
    [SetUp]
    public void Setup()
    {
        _problem412FizzBuzz = new Problem412FizzBuzz();
    }

    [Test]
    public void Example1()
    {
        // Array
        int input = 3;
        IList<string> expected = ["1","2","Fizz"];
        
        //Act
        IList<string> result = _problem412FizzBuzz.FizzBuzz(input);
        
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void Example2()
    {
        // Array
        int input = 5;
        IList<string> expected = ["1","2","Fizz","4","Buzz"];
        
        //Act
        IList<string> result = _problem412FizzBuzz.FizzBuzz(input);
        
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void Example3()
    {
        // Array
        int input = 15;
        IList<string> expected = ["1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"];
        
        //Act
        IList<string> result = _problem412FizzBuzz.FizzBuzz(input);
        
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}