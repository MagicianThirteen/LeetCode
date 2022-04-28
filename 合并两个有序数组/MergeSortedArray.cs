using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MergeSortedArray
    {
        /*public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            *//*用自带的这个效率不高
             * for(int i = 0; i < n; i++)
            {
                nums1[m+i]=nums2[i];
            }
            Array.Sort(nums1);*//*

            //利用多余的空间temp,双指针n1Index,n2Index比较
            //因为两个数组本身有序，所以比较会出现这几种情况
            //n1中指向的比n2小，n2中指向的比n1小，n1比完了n2还有，n2比完了n1还有
            int k = m + n;
            int[] tmp = new int[m + n];
            for (int index = 0, n1Index=0, n2Index=0; index < k; index++)
            {
                //边界条件，两边都还有,且两边数组不为0
                if( n != 0 && m != 0)
                {
                    if (nums1[n1Index] < nums2[n2Index] && n1Index < m && n2Index < n)
                    {
                        tmp[index] = nums1[n1Index++];
                        //边界条件：两边都还有，且两边数组不为0
                    }
                    else if (nums1[n1Index] >= nums2[n2Index] && n1Index < m && n2Index < n)
                    {
                        tmp[index] = nums2[n2Index++];
                        //边界条件：一边有一边没有，且两边数组不为0
                    }
                    else if (n1Index >= m && n2Index < n )
                    {
                        tmp[index] = nums2[n2Index++];
                    }
                    //边界条件：一边有一边没有，且两边数组不为0
                    else if (n2Index >= n && n1Index < m )
                    {
                        tmp[index] = nums1[n1Index++];
                        //边界条件：有一边的数组是0，比如n1
                    }
                }
                else//一遍数组有一边数组没有的情况
                {
                    if (n > 0 && m == 0)
                    {
                        tmp[index]=nums2[n2Index++];
                    }
                    //边界条件：有一边的数组是0，比如n2
                    else if (n == 0 && m > 0)
                    {
                        tmp[index]= nums1[n1Index++];
                    }
                }
                  
            }
            nums1 = new int[k];//利用完了nums1，就可以给它重新清空了装tmp
            Array.Copy(tmp, 0, nums1, 0, tmp.Length);
            for (int i = 0; i < nums1.Length; i++)
            {
                Console.WriteLine(nums1[i]);
            }
        }*/

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int k = m + n - 1;
            for(int index = k, nums1Index = m - 1, nums2Index = n - 1; index >= 0; index--)
            {
                if (m != 0 && n != 0)
                {
                    if (nums1Index >= 0&&nums2Index>=0&&nums1[nums1Index] > nums2[nums2Index])
                    {
                        nums1[index] = nums1[nums1Index--];
                    }
                    else if(nums1Index >= 0 && nums2Index >= 0 && nums1[nums1Index] <= nums2[nums2Index])
                    {
                        nums1[index] = nums2[nums2Index--];
                    }
                    else if (nums1Index < 0 && nums2Index >= 0)
                    {
                        nums1[index] = nums2[nums2Index--];
                    }
                    else if (nums2Index < 0 && nums1Index >= 0)
                    {
                        break;
                    }

                }
                else if (m == 0 && n>0)
                {
                    nums1 = new int[n];
                    if (nums2Index >= 0)
                    {
                        
                        nums1[index] = nums2[nums2Index--];
                    }
                }else if (m>0 && n == 0)
                {
                    break;
                }
            }

            for (int i = 0; i < nums1.Length; i++)
            {
                Console.WriteLine(nums1.Length);
                Console.WriteLine(nums1[i]);
            }
        }

    }
}
