using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ex21
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSer<int> set = new();
            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i]))
                {
                    return true;
                }
                ser.Add(nums[i]);
            }
            return false;
        }
    }
}