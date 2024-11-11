using System;
using System.Collections.Generic;

namespace TwoSumApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] result = solution.TwoSum(nums, target);

            Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
        }
    }


    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numIndices = new Dictionary<int, int>();
            
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                
                if (numIndices.ContainsKey(complement))
                {
                    return new int[] { numIndices[complement], i };
                }
                
                numIndices[nums[i]] = i;
            }
            
            throw new ArgumentException("No two sum solution");
        }
    }
}
