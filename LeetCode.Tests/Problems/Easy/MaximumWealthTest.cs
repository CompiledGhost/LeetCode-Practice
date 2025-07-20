using LeetCode.Problems.Easy;
using Shouldly;

namespace LeetCode.Tests.Problems.Easy;

public class MaximumWealthTest
{
    [Fact]
    public void MaximumWealth_Should_Return_MaximumWealth()
    {
        // Arrange
        int[][] accounts =
        [
            [1, 2, 3],
            [3, 2, 1],
            [2, 3, 4],
            [7, 3, 2] // Highest balance
        ];
        const int expectedResult = 12; // 7 + 3 + 2 = 12
        
        // Act
        var result = MaximumWealth.Run(accounts);

        // Assert
        result.ShouldBe(expectedResult);
    }
}