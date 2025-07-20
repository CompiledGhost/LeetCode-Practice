namespace LeetCode.Problems.Easy;

public static class FizzBuzz
{
    // LC # 412
    public static IList<string> Run(int n) {
        var output = new List<string>();
        for (var i = 1; i <= n; i++)
        {
            var divisibleByThree = i % 3 == 0;
            var divisibleByFive = i % 5 == 0;

            if (divisibleByThree && divisibleByFive)
            {
                output.Add("FizzBuzz");
            }
            else if (divisibleByThree)
            {
                output.Add("Fizz");
            }
            else if (divisibleByFive)
            {
                output.Add("Buzz");
            }
            else
            {
                output.Add(i.ToString());
            }
        }

        return output;
    }
}