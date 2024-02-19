using System;
using System.Collections.Generic;

public class ProblemALG007a
{
    public static void Main(string[] args)
    {
        // Prompt for user to enter text
        Console.Write("Please enter text: ");
        string text = Console.ReadLine();

        // Gets unique words
        List<string> uniqueWords = GetUniqueWords(text);

        // Display pair details
        FindPairs(uniqueWords, text);
    }

    // Function to return unique words list from the passed string
    public static List<string> GetUniqueWords(string text)
    {
        List<string> uniqueWords = new List<string>(text.Split(' '));
        for (int i = 1; i < uniqueWords.Count; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (uniqueWords[i].Equals(uniqueWords[j]))
                {
                    uniqueWords.RemoveAt(i);
                    i--;
                    break;
                }
            }
        }
        return uniqueWords;
    }

    // Display pair details function
    public static void FindPairs(List<string> uniqueWords, string text)
    {
        // Words array from text
        string[] words = text.Split(' ');

        // Loop through unique words list
        for (int i = 0; i < uniqueWords.Count; i++)
        {
            Console.Write(uniqueWords[i] + ": ");
            List<int> indexes = new List<int>();

            // Find indexes from words array
            for (int j = 0; j < words.Length; j++)
            {
                if (string.Compare(uniqueWords[i], words[j], true) == 0)
                {
                    indexes.Add(j);
                }
            }

            // Get count of combo pairs
            int cnt = GetCntComboPair(indexes);

            // Display combo pairs
            if (cnt != 0)
            {
                Console.Write(cnt + " combo-pairs ");
                DisplayComboPair(indexes);
            }
            else
            {
                Console.Write(cnt + " combo-pairs ");
            }
            Console.Write("AND ");

            // Get count of next-to pairs
            cnt = GetCntNextPair(indexes);

            // Display next-to pairs
            if (cnt != 0)
            {
                Console.Write(cnt + " next-to-pairs ");
                DisplayNextPair(indexes);
            }
            else
            {
                Console.Write(cnt + " next-to-pairs ");
            }
            Console.WriteLine();
        }
    }

    // Return count of combo pairs
    public static int GetCntComboPair(List<int> indexes)
    {
        int cnt = 0;
        for (int i = 0; i < indexes.Count; i++)
        {
            for (int j = i + 1; j < indexes.Count; j++)
            {
                cnt++;
            }
        }
        return cnt;
    }

    // Display combo pairs
    public static void DisplayComboPair(List<int> indexes)
    {
        for (int i = 0; i < indexes.Count; i++)
        {
            for (int j = i + 1; j < indexes.Count; j++)
            {
                Console.Write("(" + indexes[i] + "," + indexes[j] + ") ");
            }
        }
    }

    // Return count of next-to pairs
    public static int GetCntNextPair(List<int> indexes)
    {
        int cnt = 0;
        for (int i = 0; i < indexes.Count; i++)
        {
            for (int j = i + 1; j < indexes.Count; j++)
            {
                if (indexes[i] + 1 == indexes[j])
                {
                    cnt++;
                }
            }
        }
        return cnt;
    }

    // Display next-to pairs
    public static void DisplayNextPair(List<int> indexes)
    {
        for (int i = 0; i < indexes.Count; i++)
        {
            for (int j = i + 1; j < indexes.Count; j++)
            {
                if (indexes[i] + 1 == indexes[j])
                {
                    Console.Write("(" + indexes[i] + "," + indexes[j] + ") ");
                }
            }
        }
    }
}
