using System;
using System.Collections.Generic;

namespace LeetCodeSolutions
{
    public class LeetCodeSOlutions
    {
        static void Main(string[] args)
        {
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x)
        {
            val = x;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
        }
    }


    public class ValidSudoku
    {
        public bool IsValidSudoku(char[,] board)
        {
            bool[] seenX;
            int valX;
            for (int i = 0; i < 9; i++)
            {
                seenX = new bool[9];
                for (int j = 0; j < 9; j++)
                {
                    valX = (int)board[i, j] - '1';
                    if (valX >= 0 && valX <= 9)
                    {
                        if (seenX[valX]) { return false; }
                        seenX[valX] = true;
                    }
                }
            }

            for (int i = 0; i < 9; i++)
            {
                seenX = new bool[9];
                for (int j = 0; j < 9; j++)
                {
                    valX = (int)board[j, i] - '1';
                    if (valX >= 0 && valX <= 9)
                    {
                        if (seenX[valX]) { return false; }
                        seenX[valX] = true;
                    }
                }
            }

            for (int offX = 0; offX < 3; offX++)
            {
                for (int offY = 0; offY < 3; offY++)
                {
                    seenX = new bool[9];
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            valX = (int)board[offX * 3 + i, offY * 3 + j] - '1';
                            if (valX >= 0 && valX <= 9)
                            {
                                if (seenX[valX]) { return false; }
                                seenX[valX] = true;
                            }
                        }
                    }
                }
            }


            return true;
        }
    }

    public class FirstMissingPositive
    {

        public int FirstMssing(int[] nums)
        {
            int val;

            for(int i=0; i<nums.Length; i++)
            {
                val = nums[i];
                if(val>0 && val<=nums.Length)
                {
                    nums[i] = nums[val - 1];
                    nums[val - 1] = val;
                }
            }
            for(int i=0; i<nums.Length; i++)
            {
                if(nums[i] != i+1)
                {
                    return i + 1;
                }
            }

            return -1;
        }
    }

    public class TrappingWater
    {
        public int Trap(int[] height)
        {
            int left, right, leftMax, rightMax, waterTrapped;

            left = 0;
            right = height.Length - 1;
            leftMax = 0;
            rightMax = 0;
            waterTrapped = 0;

            while (left < right)
            {
                if(height[left] <= height[right])
                {
                    leftMax = Math.Max(leftMax, height[left]);
                    waterTrapped = waterTrapped + leftMax - height[left];
                    left++;
                }
                else
                {
                    rightMax = Math.Max(rightMax, height[right]);
                    waterTrapped = waterTrapped + rightMax - height[right];
                    right--;
                }
            }

            return waterTrapped;
        }
    }

    public class ValidBinarySearchTree
    {
        public bool IsValidBST(TreeNode node)
        {
            int min, max;
            return IsValidBSTHelper(node, out min, out max );
        }

        private bool IsValidBSTHelper(TreeNode node, out int min, out int max)
        {
            int minChild, maxChild;

            min = node.val;
            max = node.val;

            if(node.left!=null) 
            {
                if(!IsValidBSTHelper(node.left, out minChild, out maxChild))
                {
                    return false;
                }
                if(maxChild >= node.val)
                {
                    return false;
                }
                min = minChild;
            }

            if(node.right != null)
            {
                if (!IsValidBSTHelper(node.right, out minChild, out maxChild))
                {
                    return false;
                }
                if (minChild <= node.val)
                {
                    return false;
                }
                max = maxChild;
            }
            return true;

        }
    }

    public class RandomizedSet
    {
        int[] vals;
        int nextIndex;
        Dictionary<int, int> valMap;

        public RandomizedSet()
        {
            valMap = new Dictionary<int, int>();
            vals = new int[4];
            nextIndex = 0;
        }

        public void Insert(int val)
        {
            int[] oldVals;
            if (!valMap.ContainsKey(val))
            {
                valMap.Add(val, nextIndex);
                if(nextIndex >= vals.Length)
                {
                    oldVals = vals;
                    vals = new int[oldVals.Length * 2];
                    for(int i=0; i<oldVals.Length; i++)
                    {
                        vals[i] = oldVals[i];
                    }
                }
                vals[nextIndex] = val;
                nextIndex++;
            }
        }

        public void Remove(int val)
        {
            int index;
            if(valMap.ContainsKey(val))
            {
                index = valMap[val];
                valMap.Remove(val);
                nextIndex--;
                vals[index] = vals[nextIndex];
            }
        }

        public int GetRandon()
        {
            int randomNum;
            Random rand = new Random();

            if(nextIndex<=0)
            {
                return -1;
            }


            randomNum = rand.Next(nextIndex-1);
            return vals[randomNum];

        }

        public int[] GetListOfVals()
        {
            int minIndex,swap;
            int[] ret;

            ret = new int[nextIndex];
            for(int i=0; i< nextIndex; i++)
            {
                ret[i] = vals[i];
            }

            for(int i=0; i< nextIndex; i++)
            {
                minIndex = i;
                for(int j=i; j< nextIndex; j++)
                {
                    if(ret[j] < ret[minIndex])
                    {
                        minIndex = j;
                    }
                }
                swap = ret[i];
                ret[i] = ret[minIndex];
                ret[minIndex] = swap;
            }
            return ret;
        }
    }

    public class AddTwoNums
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode retHead, nextNode;

            int carry,val;

            carry = 0;
            retHead = new ListNode(0);
            nextNode = retHead;

            while (l2 != null || l1 != null || carry>0)
            {
                val = carry;
                if(l2 != null)
                {
                    val = val + l2.val;
                    l2 = l2.next;
                } 

                if(l1!= null)
                {
                    val = val + l1.val;
                    l1 = l1.next;
                }
                carry = val / 10;
                nextNode.next = new ListNode(val % 10);
                nextNode = nextNode.next;
            }
            return retHead.next;
        }
    }
}


