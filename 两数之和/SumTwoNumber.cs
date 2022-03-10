using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SumTwoNumber
    {
        int[] result=new int[2];
        public int[] SumTwoNumbers(int[] numbs,int target)
        {
            /*暴力穷举法
             * for(int i = 0; i < numbs.Length; i++)
            {
                for(int j = i + 1; j < numbs.Length - i; j++)
                {
                    if (numbs[i] + numbs[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }
            }
            return result;*/
            Dictionary<int,int> storeNums=new Dictionary<int,int>();
            for(int i = 0; i < numbs.Length; i++)
            {
                int tmp = target - numbs[i];
                if (storeNums.ContainsKey(tmp))
                {
                    result[0] = i;
                    result[1] = storeNums[tmp];
                    break;
                }
                else
                {
                    if (!storeNums.ContainsKey(numbs[i]))
                    {
                        storeNums.Add(numbs[i], i);
                    }
                    
                }
            }
            return result;
        }
    }
}
