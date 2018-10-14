using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeSolutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Tests
{
    [TestClass()]
    public class ValidSudokuTests
    {
        [TestMethod()]
        public void TestValidSudoku()
        {

            ValidSudoku solution = new ValidSudoku();
            bool output;

            char[,] input =
{
                {'5','3','.','.','7','.','.','.','.'},
                {'6','.','.','1','9','5','.','.','.'},
                {'.','9','8','.','.','.','.','6','.'},
                {'8','.','.','.','6','.','.','.','3'},
                {'4','.','.','8','.','3','.','.','1'},
                {'7','.','.','.','2','.','.','.','6'},
                {'.','6','.','.','.','.','2','8','.'},
                {'.','.','.','4','1','9','.','.','5'},
                {'.','.','.','.','8','.','.','7','9'}
            };

            output = solution.IsValidSudoku(input);

            if (output == false)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void TestTwoInABox()
        {

            ValidSudoku solution = new ValidSudoku();
            bool output;

            char[,] input =
{
                {'5','3','.','.','7','.','.','.','.'},
                {'6','.','.','1','9','5','.','.','.'},
                {'.','9','8','.','.','.','.','6','.'},
                {'8','.','.','.','6','6','.','.','3'},
                {'4','.','.','8','.','3','.','.','1'},
                {'7','.','.','.','2','.','.','.','6'},
                {'.','6','.','.','.','.','2','8','.'},
                {'.','.','.','4','1','9','.','.','5'},
                {'.','.','.','.','8','.','.','7','9'}
            };

            output = solution.IsValidSudoku(input);

            if (output == true)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void TestTwoInAColumn()
        {

            ValidSudoku solution = new ValidSudoku();
            bool output;

            char[,] input =
{
                {'5','3','.','.','7','.','.','.','.'},
                {'6','.','.','1','9','5','.','.','.'},
                {'.','9','8','.','.','.','.','6','.'},
                {'8','.','.','.','6','.','.','.','3'},
                {'4','.','.','8','.','3','.','.','1'},
                {'7','.','.','.','2','.','.','.','6'},
                {'.','6','.','.','.','.','2','8','1'},
                {'.','.','.','4','1','9','.','.','5'},
                {'.','.','.','.','8','.','.','7','9'}
            };

            output = solution.IsValidSudoku(input);

            if (output == true)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void TestTwoInARow()
        {

            ValidSudoku solution = new ValidSudoku();
            bool output;

            char[,] input =
{
                {'5','3','.','.','7','.','.','.','.'},
                {'6','.','.','1','9','5','.','.','.'},
                {'.','9','8','.','.','.','.','6','.'},
                {'8','.','.','.','6','.','.','.','3'},
                {'4','.','.','8','.','3','.','.','1'},
                {'7','.','.','.','2','.','.','.','6'},
                {'2','6','.','.','.','.','2','8','3'},
                {'.','.','.','4','1','9','.','.','5'},
                {'.','.','.','.','8','.','.','7','9'}
            };

            output = solution.IsValidSudoku(input);

            if (output == true)
            {
                Assert.Fail();
            }
        }
    }

    [TestClass()]
    public class FirstMissingPositiveTests
    {

        [TestMethod()]
        public void TestNoMissing()
        {
            int output;
            FirstMissingPositive solution = new FirstMissingPositive();
            int[] input = { 3, 1, 2, 5, 4, 6 };

            output = solution.FirstMssing(input);

            if (output != -1)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void TestSingleMissing()
        {
            int output;
            FirstMissingPositive solution = new FirstMissingPositive();
            int[] input = { 3, 1, -3, 5, 4, 6 };

            output = solution.FirstMssing(input);

            if (output != 2)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void TestMultipleMissing()
        {
            int output;
            FirstMissingPositive solution = new FirstMissingPositive();
            int[] input = { 3, 1, -3, 5, -4, 6 };

            output = solution.FirstMssing(input);

            if (output != 2)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void TestMissingWithDups()
        {
            int output;
            FirstMissingPositive solution = new FirstMissingPositive();
            int[] input = { 3, 1, 1, 5, 4, 6 };

            output = solution.FirstMssing(input);

            if (output != 2)
            {
                Assert.Fail();
            }
        }
    }

    [TestClass()]
    public class TrappingWaterTests
    {

        [TestMethod()]
        public void TestCaseExample()
        {
            int output;
            TrappingWater solution = new TrappingWater();
            int[] input = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };

            output = solution.Trap(input);

            if (output != 6)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void TestNoHeights()
        {
            int output;
            TrappingWater solution = new TrappingWater();
            int[] input = { 0, 0, 0, 0 };

            output = solution.Trap(input);

            if (output != 0)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void TestOneWall()
        {
            int output;
            TrappingWater solution = new TrappingWater();
            int[] input = { 0, 0, 5, 0 };

            output = solution.Trap(input);

            if (output != 0)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void TestRightHighest()
        {
            int output;
            TrappingWater solution = new TrappingWater();
            int[] input = { 1, 0, 1, 0, 2, 0, 0, 1, 3 };

            output = solution.Trap(input);

            if (output != 7)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void TestMiddleHighest()
        {
            int output;
            TrappingWater solution = new TrappingWater();
            int[] input = { 1, 0, 1, 0, 2, 0, 0, 1, 3, 0, 3, 1, 2, 0 };

            output = solution.Trap(input);

            if (output != 11)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void TestLeftHighest()
        {
            int output;
            TrappingWater solution = new TrappingWater();
            int[] input = { 4, 1, 0, 1, 0, 2, 0, 0, 1, 3, 0, 3, 1, 2, 0 };

            output = solution.Trap(input);

            if (output != 23)
            {
                Assert.Fail();
            }
        }
    }

    [TestClass()]
    public class ValidBinarySearchTreeTests
    {

        [TestMethod()]
        public void TestCaseExample()
        {
            bool output;
            ValidBinarySearchTree solution = new ValidBinarySearchTree();
            TreeNode input;

            input = new TreeNode(2);
            input.left = new TreeNode(1);
            input.right = new TreeNode(3);

            output = solution.IsValidBST(input);

            if (output != true)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void TestCaseExample2()
        {
            bool output;
            ValidBinarySearchTree solution = new ValidBinarySearchTree();
            TreeNode input;

            input = new TreeNode(5);
            input.left = new TreeNode(1);
            input.right = new TreeNode(4);
            input.right.left = new TreeNode(3);
            input.right.right = new TreeNode(6);

            output = solution.IsValidBST(input);

            if (output != false)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void TestCaseLargeTree()
        {
            bool output;
            ValidBinarySearchTree solution = new ValidBinarySearchTree();
            TreeNode input;

            input = new TreeNode(5);
            input.left = new TreeNode(1);
            input.left.right = new TreeNode(4);
            input.right = new TreeNode(8);
            input.right.left = new TreeNode(6);
            input.right.right = new TreeNode(10);

            output = solution.IsValidBST(input);

            if (output != true)
            {
                Assert.Fail();
            }
        }
    }

    [TestClass()]
    public class RandomizedSetTests
    {

        [TestMethod()]
        public void TestCaseInsertRandomRemove()
        {
            int random;
            int[] vals;
            RandomizedSet solution = new RandomizedSet();

            solution.Insert(1);
            vals = solution.GetListOfVals();
            if (vals.Length != 1 || vals[0] != 1)
            {
                Assert.Fail("Insert Fail");
            }

            random = solution.GetRandon();
            if (random != 1)
            {
                Assert.Fail("Random Fail");
            }

            solution.Remove(1);
            vals = solution.GetListOfVals();
            if (vals.Length != 0)
            {
                Assert.Fail("remove Fail");
            }
        }

        [TestMethod()]
        public void TestMultipleInsertAndRemove()
        {
            int[] vals;
            RandomizedSet solution = new RandomizedSet();

            solution.Insert(1);
            solution.Insert(1);
            solution.Insert(1);
            solution.Insert(5);
            solution.Insert(2);
            solution.Insert(5);
            vals = solution.GetListOfVals();
            if (vals.Length != 3 || vals[0] != 1 || vals[1] != 2 || vals[2] != 5)
            {
                Assert.Fail("Insert Fail");
            }

            solution.Remove(2);
            solution.Remove(2);
            vals = solution.GetListOfVals();
            if (vals.Length != 2 || vals[0] != 1 || vals[1] != 5)
            {
                Assert.Fail("remove Fail");
            }
        }
    }

    [TestClass()]
    public class AddTwoNumsTests
    {

        [TestMethod()]
        public void TestCaseNoLists()
        {
            ListNode ret;
            AddTwoNums twoNums = new AddTwoNums();

            ret = twoNums.AddTwoNumbers(null, null);

            if (ret != null)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void TestListOne()
        {
            ListNode ret,l1,l2;
            AddTwoNums twoNums = new AddTwoNums();
            l1 = new ListNode(1);

            ret = twoNums.AddTwoNumbers(l1, null);

            if (ret == null || ret.val != 1 || ret.next != null)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void TestListTwo()
        {
            ListNode ret, l1, l2;
            AddTwoNums twoNums = new AddTwoNums();
            l2 = new ListNode(1);

            ret = twoNums.AddTwoNumbers(null, l2);

            if (ret == null || ret.val != 1 || ret.next != null)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void TestMultipleWithCary()
        {
            ListNode ret, l1, l2;
            AddTwoNums twoNums = new AddTwoNums();
            l1 = new ListNode(8);
            l1.next = new ListNode(6);
            l2 = new ListNode(7);
            l2.next = new ListNode(9);

            ret = twoNums.AddTwoNumbers(l1, l2);


            if ( ret.val != 5 || ret.next.val != 6 || ret.next.next.val != 1 || ret.next.next.next != null )
            {
                Assert.Fail();
            }
        }
    }
}