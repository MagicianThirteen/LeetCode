using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class L_70
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            L_70 l_70 = new L_70();
            Console.WriteLine($"当前有3个楼梯时，总共有{l_70.ClimbStairs(3)}种解法");
        }
        private  Dictionary<int, int> saveResult = new Dictionary<int, int>();
        public  int ClimbStairs(int n)
        {
            if (n == 1) return 1;
            if(n == 2) return 2;
            if (saveResult.ContainsKey(n))
            {
                return saveResult[n];
            }
            else
            {
                int result = ClimbStairs(n - 1) + ClimbStairs(n - 2);
                saveResult.Add(n, result);
                return result;
            }

        }
    }
}