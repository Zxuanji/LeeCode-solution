using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace leecode_solutions.problem_1_10
{
    /* Problem 1: Two Sum
     
     * Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

     * You may assume that each input would have exactly one solution, and you may not use the same element twice.

     * You can return the answer in any order.
     
     */


    // solution 1
    internal class _1_TwoSum_solution1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return [i, j];
                    }
                }
            }
            return [];
        }
    }

    // solution2
    internal class _1_TwoSum_solution2
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numIndexMap = new Dictionary<int, int>();

            for(int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (numIndexMap.ContainsKey(complement))
                {
                    return [numIndexMap[complement], i];
                }
                numIndexMap[nums[i]] = i;
            }

            return [];
        }
    }
}
