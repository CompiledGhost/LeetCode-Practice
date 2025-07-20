using LeetCode.Problems.Easy;
using Shouldly;

namespace LeetCode.Tests.Problems.Easy;

public class MiddleOfTheLinkedListTest
{
    [Fact]
    public void Evens_Should_Return_Second_Middle()
    {
        // Arrange
        const int expectedResult = 4;

        // Act
        var result = MiddleOfTheLinkedList.Run(EvenHead).Val;

        // Assert
        result.ShouldBe(expectedResult);
    }
    
    [Fact]
    public void Odds_Should_Return_Middle()
    {
        // Arrange
        const int expectedResult = 3;

        // Act
        var result = MiddleOfTheLinkedList.Run(OddHead).Val;

        // Assert
        result.ShouldBe(expectedResult);
    }
    
    private static ListNode EvenHead => new(1,
        new ListNode(2,
            new ListNode(3,
                new ListNode(4,
                    new ListNode(5,
                        new ListNode(6))))));
    
    private static ListNode OddHead => new(1,
        new ListNode(2,
            new ListNode(3,
                new ListNode(4,
                    new ListNode(5)))));
}