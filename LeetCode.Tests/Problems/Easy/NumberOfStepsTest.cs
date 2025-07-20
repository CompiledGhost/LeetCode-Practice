using LeetCode.Problems.Easy;
using Shouldly;

namespace LeetCode.Tests.Problems.Easy;

public class NumberOfStepsTest
{
    [Fact]
    public void NumberOfSteps_Should_Return_NumberOfSteps()
    {
        // Arrange
        const int expectedResult = 17;
        
        // Act
        var result = NumberOfSteps.Run(1438);
        
        // Assert
        result.ShouldBe(expectedResult);
    }
}