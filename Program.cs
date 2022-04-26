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
            /*L_70 l_70 = new L_70(); 
            Console.WriteLine($"当前有6个楼梯时，总共有{l_70.ClimbStairs(6)}种解法");*/
            MergeSortedArray mergeSortedArray = new MergeSortedArray();
            /*int[] num1 = new int[] { 1, 2, 3 ,0,0,0};
            int[] num2 = new int[] { 2, 5, 6 };*/
            /*int[] num1 = new int[] { 1 };
            int[] num2 = new int[] { };*/
            int[] num1 = new int[] { };
            int[] num2 = new int[] {1};
            mergeSortedArray.Merge(num1, 0, num2, 1);
            
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