using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class FindDisappearedNumbers
    {
        //返回一个IList，里面是消失的数字
        public IList<int> Find(int[] nums)
        {
            IList<int> result = new List<int>();
            int n = nums.Length;
            for(int i = 0; i < n; i++)
            {
                int k = (nums[i] - 1) % n;
                nums[k] += n;
            }
            for(int i = 0; i < n; i++)
            {
                if (nums[i] <=n)
                {
                    result.Add(i+1);
                    Console.WriteLine($"消失的数字{i+1}");
                }
            }
            return result;
        }
    }
}
