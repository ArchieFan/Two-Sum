using System.Diagnostics;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        //Stopwatch c = new Stopwatch();
        //c.Start();
        if (nums == null) return new int[0];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    //c.Stop();
                    //Console.WriteLine(c.Elapsed);
                    return new int[] { i, j };
                }
            }

        }
        return new int[0];
    }

    public int[] TwoSum2(int[] nums, int target)
    {
        //Stopwatch c = new Stopwatch();
        //c.Start();
        if (nums == null) return new int[0];
        Dictionary<int, int> dp = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int reminder = target - nums[i];
            if (dp.ContainsValue(reminder))
            {
                //c.Stop();
                //Console.WriteLine(c.Elapsed);
                return new int[] { dp.FirstOrDefault(x => x.Value == reminder).Key, i };
            }
            else
            {
                dp.Add(i, nums[i]);
            }
        }

        return new int[0];
    }

    public int[] TwoSum3(int[] nums, int target)
    {
        //Stopwatch c = new Stopwatch();
        //c.Start();
        if (nums == null) return new int[] { };
        for (int i = 0; i < nums.Length; i++)
        {
            int remainder = target - nums[i];
            int remainder_index = Array.IndexOf(nums, remainder);
            if (remainder_index != -1 && remainder_index < i)
            {
                //c.Stop();
                //Console.WriteLine(c.Elapsed);
                return new int[] { remainder_index, i };
            }
        }
        return new int[] { };
    }

        static void Main()
    {
        //int[] nums = { 2, 7, 11, 15 };
        //int target = 9;

        int[] nums = { 1, 1, 1, 1, 3, 2, 4 };
        int target = 6;

        //int[] nums = { 3, 3 };
        //int target = 6;

        //int[] nums = { 8, 9, 2, 7, 11, 15 };
        //int target = 9;

        Solution s = new Solution();
        int[] result = s.TwoSum(nums, target);
        Console.WriteLine(String.Join(",", result));

        result = s.TwoSum2(nums, target);

        result = s.TwoSum3(nums, target);

    }
}




