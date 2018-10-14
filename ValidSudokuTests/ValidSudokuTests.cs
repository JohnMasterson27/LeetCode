using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValidSudoku;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidSudoku.Tests
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

            if(output==false)
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
}