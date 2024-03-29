﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class L_70
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FindDisappearedNumbers findDisappeared = new FindDisappearedNumbers();
            int[] nums = {4,3,2,7,8,2,3,1};
            findDisappeared.Find(nums);

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