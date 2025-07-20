using LeetCode.Problems.Easy;
using Shouldly;

namespace LeetCode.Tests.Problems.Easy;

public class RunningSumTest
{
    [Fact]
    public void Should_Return_Running_Sum()
    {
        // Arrange
        int[] nums = [1, 2, 3, 4, 5];
        int[] expectedResult = [1, 3, 6, 10, 15];

        // Act
        var result = RunningSum.Run(nums);

        // Assert
        result.ShouldBe(expectedResult);
    }
}