namespace Two_Sum.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        [InlineData(new int[] { 8, 9, 2, 7, 11, 15 }, 9, new int[] { 2, 3 })]

        public void Test1(int[] nums, int target, int[] expected)
        {
            Solution s = new Solution();
            int[] result = s.TwoSum(nums, target);
            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData(new int[] { 1, 1, 1, 1, 3, 2, 4 }, 6, new int[] { 5, 6 })]

        public void Test2(int[] nums, int target, int[] expected)
        {
            Solution s = new Solution();
            int[] result = s.TwoSum2(nums, target);
            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
        [InlineData(new int[] { 8, 9, 2, 7, 11, 15 }, 9, new int[] { 2, 3 })]

        public void Test3(int[] nums, int target, int[] expected)
        {
            Solution s = new Solution();
            int[] result = s.TwoSum3(nums, target);
            Assert.Equal(expected, result);

        }
    }
}