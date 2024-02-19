using System;

class ProblemALG004r
{
    private int n;
    private int rotation;
    private int[][] magicSquare;

    public ProblemALG004r(int n, int rotation = 0)
    {
        this.n = n;
        this.rotation = rotation;
        this.magicSquare = new int[n][];
        for (int i = 0; i < n; i++)
        {
            this.magicSquare[i] = new int[n];
        }
        GenerateMagicSquare();
    }

    private void GenerateMagicSquare()
    {
        int row = 0;
        int col = n / 2;
        int num = 1;

        while (num <= n * n)
        {
            magicSquare[row][col] = num;
            num++;

            int newRow = (row - 1 + n) % n;
            int newCol = (col + 1) % n;

            if (magicSquare[newRow][newCol] != 0)
            {
                row = (row + 1) % n;
            }
            else
            {
                row = newRow;
                col = newCol;
            }
        }
    }

    private void Rotate()
    {
        int[][] rotatedSquare = new int[n][];
        for (int i = 0; i < n; i++)
        {
            rotatedSquare[i] = new int[n];
        }

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                if (rotation == 0)
                {
                    rotatedSquare[row][col] = magicSquare[row][col];
                }
                else if (rotation == 1)
                {
                    rotatedSquare[col][n - 1 - row] = magicSquare[row][col];
                }
                else if (rotation == 2)
                {
                    rotatedSquare[n - 1 - row][n - 1 - col] = magicSquare[row][col];
                }
                else if (rotation == 3)
                {
                    rotatedSquare[n - 1 - col][row] = magicSquare[row][col];
                }
            }
        }

        magicSquare = rotatedSquare;
    }

    // Prints out the MagicSquare
    public void PrintMagicSquare()
    {
        for (int row = 0; row < n; row++)
        {
            Console.WriteLine(string.Join(" ", magicSquare[row]));
        }
    }

    // Example usage
    static void Main(string[] args)
    {
        int n = 7;  // Change this to the desired odd dimension
        int rotation = 0;  // Change this to the desired rotation (0, 1, 2, or 3)

        ProblemALG004r magicSquare = new ProblemALG004r(n, rotation);
        magicSquare.PrintMagicSquare();
    }
}
