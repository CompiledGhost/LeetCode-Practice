namespace LeetCode.Problems.Easy;

// LC # 1480
public static class RunningSum
{
    public static readonly int[] Nums = [1, 2, 3, 4, 5];
    
    public static int[] Run(int[] nums) {
        var totals = new int[nums.Length];
        var total = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            total += nums[i];
            totals[i] = total;
        }
        return totals;
    }
}