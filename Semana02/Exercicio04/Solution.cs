using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionay<int, int> dict = new();
            for(int i = 0; i < nums.Length; i++);
            {
                int complement = target - nums[i]
                if(dict.ContainsKey(complement))
                {
                    return new int[] { dict[complement], i };
                }
                if(!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
            }
            throw new ArgumentException("No solution");
        }
    }
}