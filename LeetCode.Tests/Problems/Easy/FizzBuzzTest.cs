using LeetCode.Problems.Easy;
using Shouldly;

namespace LeetCode.Tests.Problems.Easy;

public class FizzBuzzTest
{
    [Fact]
    public void FizzBuzz_Should_FizzBuzz()
    {
        // Arrange
        const int numberToTest = 15;
        var expectedResult = new List<string>
        {
            "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz",
            "11", "Fizz", "13", "14", "FizzBuzz"
        };
        
        // Act
        var result = FizzBuzz.Run(numberToTest);
        
        // Assert
        result.ShouldBe(expectedResult);
    }
}