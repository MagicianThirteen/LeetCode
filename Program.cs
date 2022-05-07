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
            MoveZeroes moveZeroes = new MoveZeroes();
            int[] nums = { 1, 0, 0, 3, 12 };
            moveZeroes.Move(nums);

        }
        private  Dictionary<int, int> saveResult = new Dictionary<int, int>();
        public  int ClimbStairs(int n)
        {
            if (n == 1) return 1;
            if (n == 2) return 2;
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
            /*if (n == 1) return 1;
            if(n == 2) return 2;
            int pre = 2;
            int prePre = 1;
            int result=0;
            for(int i = 3; i <= n; i++)
            {
                result = pre + prePre;
                prePre = pre;
                pre = result;
            }
            return result;*/
        }
    }
}