using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        
        Console.OutputEncoding = UTF8Encoding.UTF8;
        string word = "Predator";
        int uniqueLetters = CountUniqueLetters(word);
        Console.WriteLine("У слові \"" + word + "\" є " + uniqueLetters + " різних літер.");
    }

    static int CountUniqueLetters(string word)
    {
        int count = 0;
        bool[] seen = new bool[26];  

        
        foreach (char c in word.ToLower())
        {
            

            int index = c - 'a';  
            if (index >= 0 && index < 26 && !seen[index])
            {
                
                seen[index] = true;
                count++;
            }
        }

        return count;
    }
}

