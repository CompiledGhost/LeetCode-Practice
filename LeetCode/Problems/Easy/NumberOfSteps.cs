namespace LeetCode.Problems.Easy;

public static class NumberOfSteps
{
    // LC # 1342
    public static int Run(int num) {
        var steps = 0;
        while (num > 0)
        {
            if (num % 2 == 0)
            {
                num /= 2;
            }
            else
            {
                num -= 1;
            }
            steps++;
        }

        return steps;
    }
}