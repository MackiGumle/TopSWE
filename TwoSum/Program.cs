using System.Text;
using System.Collections.Generic;

namespace TopSWE;
class Program
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, List<int>> dict = new();
            int[] indices = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                    dict[nums[i]].Add(i);
                else
                    dict.Add(nums[i], new List<int>() { i });
            }

            for (int i = 0; i < nums.Length; i++)
                if (dict.ContainsKey(target - nums[i]))
                {
                    indices[0] = dict[target - nums[i]].FirstOrDefault();
                    indices[1] = i;
                }

            return indices;
        }
    }

    static void Main(string[] args)
    {
        int[] arr = { 3, 3 };
        Solution solution = new();

        foreach (var item in solution.TwoSum(arr, 6))
            Console.WriteLine(item);
    }
}
