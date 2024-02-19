<h1>Find Word Pairs</h1>

This C# code prompts the user to enter a text, then it analyzes the entered text to find and display certain patterns of word pairs within it.

Here's a breakdown of what the code does:

<b>The Main method:</b>

Prompts the user to enter text.
Reads the input text from the console.
Calls the GetUniqueWords method to get a list of unique words from the entered text.
Calls the FindPairs method to find and display pairs of words in the text.

<b>The GetUniqueWords method:</b>

Takes a string input (text) and splits it into words based on spaces.
Iterates through the list of words and removes duplicates, keeping only the unique words.
Returns a list of unique words.

<b>The FindPairs method:</b>

Takes a list of unique words (uniqueWords) and the original text (text) as inputs.
Splits the original text into an array of words.
Iterates through each unique word.
For each unique word, it finds the indices where that word occurs in the array of words.
Calculates and displays the count and indices of "combo pairs" (pairs of the same word occurring at different positions) and "next-to pairs" (pairs of the same word occurring consecutively).

<b>The GetCntComboPair method:</b>

Calculates the count of "combo pairs" based on the indices of occurrences of a word.

<b>The DisplayComboPair method:</b>

Displays the indices of "combo pairs" found for a specific word.

<b>The GetCntNextPair method:</b>

Calculates the count of "next-to pairs" based on the indices of occurrences of a word.

<b>The DisplayNextPair method:</b>

Displays the indices of "next-to pairs" found for a specific word.

Overall, the code analyzes the input text to find and display information about pairs of words, specifically identifying pairs where one word follows another directly (next-to pairs) and pairs where the same word appears at different positions (combo pairs).
