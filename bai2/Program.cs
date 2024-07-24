

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a String:");
        string inputString = Console.ReadLine();
        
        Console.WriteLine("Enter a word to search:");
        string searchWord = Console.ReadLine();
        
        int count = CountWordOccurrences(inputString, searchWord);
        
        Console.WriteLine($"Word found {count} times in the string");
    }

    static int CountWordOccurrences(string str, string word)
    {
        int count = 0;
        int position = 0;
        
        while ((position = str.IndexOf(word, position)) != -1)
        {
            count++;
            position += word.Length;
        }

        return count;
    }
}