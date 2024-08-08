using System.Text;

namespace P.LengthyWordsReversal;

public class LengthyWordsReversal
{
    public static string ReverseLongWords(string inputString)
    {
        string[] strings = inputString.Split(' ');
        for(int i = 0; i < strings.Length;i++)
        {
            if (strings[i].Length < 5) continue;

            strings[i] = Reverse(strings[i]);
        }
        
        return string.Join(" ", strings);
    }
    
    private static string Reverse(string text)
    {
        char[] cArray = text.ToCharArray();
        string reverse = String.Empty;
        
        for (int i = cArray.Length - 1; i > -1; i--)
        {
            reverse += cArray[i];
        }
        
        return reverse;
    }
}