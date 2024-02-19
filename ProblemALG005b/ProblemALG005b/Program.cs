using System;

class ProblemALG005b
{
    //Checks the co-ordinates are valid or not
    public static bool IsValid(int row, int col)
    {
        return row >= 1 && col >= 1 && row <= 25 && col <= 79;
    }

    static void Main(string[] args)
    {
        int sizeOfShape, xCentre, yCentre;

        // Validates if user enters the number withn the required range
        // if not the user has to re-enter a different value.
        do
        {
            Console.Write("Enter size of shape (2 to 9): ");
        } while (!int.TryParse(Console.ReadLine(), out sizeOfShape) || sizeOfShape < 2 || sizeOfShape > 9);

        do
        {
            Console.Write("Enter x-coordinate of center (1 to 79): ");
        } while (!int.TryParse(Console.ReadLine(), out xCentre) || xCentre < 1 || xCentre > 79);

        do
        {
            Console.Write("Enter y-coordinate of center (1 to 25): ");
        } while (!int.TryParse(Console.ReadLine(), out yCentre) || yCentre < 1 || yCentre > 25);

        char[][] c = new char[26][];
        for (int i = 0; i < 26; i++)
        {
            c[i] = new char[80];
            for (int j = 0; j < 80; j++)
            {
                if ((j + 1) % 10 == 0)
                {
                    c[i][j] = (char)((j + 1) / 10 + '0');
                }
                else if ((i + 1) % 10 == 0 && j == 0)
                {
                    c[i][j] = (char)((i + 1) / 10 + '0');
                }
                else
                {
                    c[i][j] = '=';
                }
            }
        }

        c[yCentre][xCentre] = '$';

        int leftCol = xCentre - (sizeOfShape - 1);
        int rightCol = xCentre + (sizeOfShape - 1);

        for (int row = 0; row < sizeOfShape; row++)
        {
            int upperRow = yCentre - row;
            int lowerRow = yCentre + row;

            if (IsValid(upperRow, leftCol))
                c[upperRow][leftCol] = '$';

            if (IsValid(lowerRow, leftCol))
                c[lowerRow][leftCol] = '$';

            if (IsValid(upperRow, rightCol))
                c[upperRow][rightCol] = '$';

            if (IsValid(lowerRow, rightCol))
                c[lowerRow][rightCol] = '$';

            leftCol++;
            rightCol--;
        }

        // Printing the diamond
        for (int i = 0; i < 26; i++)
        {
            for (int j = 0; j < 80; j++)
            {
                Console.Write(c[i][j]);
            }
            Console.WriteLine();
        }
    }
}
