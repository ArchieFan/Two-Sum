public class Solution
{
    public int[] TwoSum(int[]? nums, int target)
    {
        if (nums == null) return new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i+1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[2] { i, j};
                }
            }
  
        }
        return new int[2];
    }


    static void Main()
    {
        //int[] nums = { 2, 7, 11, 15 };
        //int target = 9;

        int[] nums = { 3, 2, 4 };
        int target = 6;

        //int[] nums = { 3, 3 };
        //int target = 6;

        //int[] nums = { 8, 9, 2, 7, 11, 15 };
        //int target = 9;

        Solution s = new Solution();
        int[] result = s.TwoSum(nums, target);
        Console.WriteLine(String.Join(",", result));

    }
}




