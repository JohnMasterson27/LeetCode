using System;

namespace ValidSudoku
{
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

        public static void Main(String[] args)
        {
            return;
        }
    }


}


