namespace starter;

class Program
{
    public static void Main(string[] args)
    {
        // MARK: Setup
        string exampleURL = "www.docs.microsoft.com/dotnet/csharp/whats-new/csharp-version-history";
        Console.WriteLine($"Hit ENTER to break down the URL into its component parts: {exampleURL}");
        Console.ReadKey();

        // MARK: Result
        var components = BreakdownURL(exampleURL);
        for (int i = 0; i < components.Length; i++)
        {
            var indent = new string(' ', i * 2);
            Console.WriteLine($"{indent} -> {components[i]}");
        }
    }

    // MARK: Calculation
    public static string[] BreakdownURL(string urlString)
    {
        // get rid of www. if it is available
        if (urlString.IndexOf("www.") != -1)
        {
            urlString = urlString.Substring(4);
        }
        string[] wordList = urlString.Split('/');
        for (int i = 0; i < wordList.Length; i++)
        {
            //get rid of '-'
            if (wordList[i].IndexOf('-') != -1)
            {
                string newWord = wordList[i].Replace('-', ' ');
                wordList[i] = newWord;
            }

        }
        return wordList;
    }
}
