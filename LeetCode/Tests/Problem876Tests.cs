using LeetCode.Problems.Problem876;

public class Problem876Tests
{
    private Problem876MiddleOfTheLinkedList _problem876MiddleOfTheLinkedList;
    
    [SetUp]
    public void Setup()
    {
        _problem876MiddleOfTheLinkedList = new Problem876MiddleOfTheLinkedList();
    }

    [Test]
    public void TestListNode()
    {
        // Array
        int[] input = [1, 2, 3];
        int[] expected = [1, 2, 3];
        ListNode newListNode = new ListNode(input);
        
        //Act
        int[] result = newListNode.ReturnAllValues();
        
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void Test1()
    {
        // Array
        int[] input = [1,2,3,4,5];
        int[] expected = [3,4,5];
        ListNode newListNode = new ListNode(input);
        
        //Act
        int[] result = _problem876MiddleOfTheLinkedList.MiddleNode(newListNode).ReturnAllValues();
        
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void Test2()
    {
        // Array
        int[] input = [1,2,3,4,5,6];
        int[] expected = [4,5,6];
        ListNode newListNode = new ListNode(input);
        
        //Act
        int[] result = _problem876MiddleOfTheLinkedList.MiddleNode(newListNode).ReturnAllValues();
        
        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}