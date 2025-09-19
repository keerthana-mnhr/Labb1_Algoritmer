Console.WriteLine("Skriv en text");
string inputText = Console.ReadLine();

for (int startIndex = 0; startIndex < inputText.Length; startIndex++)
{
    // if (char.IsDigit(inputText[startIndex]))
    {
        for (int endIndex = startIndex + 1; endIndex < inputText.Length; endIndex++)
        {
            if (!char.IsDigit(inputText[startIndex]) || !char.IsDigit(inputText[endIndex]))
            {
                break;
            }

            if (char.IsDigit(inputText[endIndex]) && inputText[startIndex] == inputText[endIndex])
            {
                int sumOfSubstring = 0;
                for (int i = 0; i < inputText.Length; i++)
                {
                    if (i >= startIndex && i <= endIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    Console.Write(inputText[i]);
                }
                Console.WriteLine();
                Console.ResetColor();
                break;
                // Console.WriteLine(sumOfSubstring);
            }
        }
    }
}