namespace LeetCode.Problems.Easy;

public static class MaximumWealth
{
    public static int[][] CustomerBalances =
    [
        new int[] {1, 2, 3},
        new int[] {3, 2, 1},
        new int[] {2, 3, 4}
    ];
    
    // LC # 1672
    public static int Run(int[][] accounts)
    {
        var highestBalance = 0;
        for (var i = 0; i < accounts.Length; i++)
        {
            var totalBalance = 0;
            for (var j = 0; j < accounts[i].Length; j++)
            {
                totalBalance += accounts[i][j];
            }

            if (totalBalance > highestBalance)
                highestBalance = totalBalance;
        }

        return highestBalance;
    }
}