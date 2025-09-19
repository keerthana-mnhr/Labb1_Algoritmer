Console.WriteLine("Skriv en text");
string inputText = Console.ReadLine();

long totalSumOfRedValues = 0;
for (int startIndex = 0; startIndex < inputText.Length; startIndex++)
{
    for (int endIndex = startIndex + 1; endIndex < inputText.Length; endIndex++)
    {
        if (!char.IsDigit(inputText[startIndex]) || !char.IsDigit(inputText[endIndex]))
        {
            break;
        }

        if (char.IsDigit(inputText[endIndex]) && inputText[startIndex] == inputText[endIndex])
        {
            string redSubstring = "";
            for (int i = 0; i < inputText.Length; i++)
            {
                if (i >= startIndex && i <= endIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    redSubstring += inputText[i];
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                
                Console.Write(inputText[i]);
            }
            Console.WriteLine();
            Console.ResetColor();
            if (long.TryParse(redSubstring, out long redValue))
            {
                totalSumOfRedValues += redValue;
            }
            break;
        }
    }
}
Console.WriteLine();
Console.WriteLine($"Total of all red values: {totalSumOfRedValues}");
