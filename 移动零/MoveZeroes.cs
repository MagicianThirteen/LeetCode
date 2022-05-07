using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	internal class MoveZeroes
	{
		public void Move(int[] nums)
		{
			int j = 0;
			int length = nums.Length;
			for (int i = 0; i < length; i++)
			{
				if (nums[i] != 0)
				{
					nums[j++] = nums[i];
				}
			}

			for (int i = j; i < nums.Length; i++)
			{
				nums[i] = 0;
			}

			for (int i = 0; i < nums.Length; i++)
			{
				Console.WriteLine(nums[i]);
			}

			/*if (nums == null)
			{
				return;
			}
			//第一次遍历的时候，j指针记录非0的个数，只要是非0的统统都赋给nums[j]
			int j = 0;
			for (int i = 0; i < nums.Length; ++i)
			{
				if (nums[i] != 0)
				{
					nums[j++] = nums[i];
				}
			}
			//非0元素统计完了，剩下的都是0了
			//所以第二次遍历把末尾的元素都赋为0即可
			for (int i = j; i < nums.Length; i++)
			{
				nums[i] = 0;
			}
			for (int i = 0; i < nums.Length; i++)
			{
				Console.WriteLine(nums[i]);
			}
		}*/



		}
	}
}

         
 
