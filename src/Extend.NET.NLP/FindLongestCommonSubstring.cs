namespace Extend.NET.NLP;

public static partial class NlpExtensions
{
    /// <summary>
    /// Finds the longest common substring between two strings.
    /// </summary>
    /// <param name="str1">The first string to compare.</param>
    /// <param name="str2">The second string to compare.</param>
    /// <returns>The longest common substring.</returns>
    public static string FindLongestCommonSubstring(this string str1, string str2)
    {
        int[,] L = new int[str1.Length + 1, str2.Length + 1];
        int maxLen = 0;
        int endIndex = 0;

        for (int i = 0; i < str1.Length; i++)
        {
            for (int j = 0; j < str2.Length; j++)
            {
                if (str1[i] == str2[j])
                {
                    if (i == 0 || j == 0)
                        L[i, j] = 1;
                    else
                        L[i, j] = L[i - 1, j - 1] + 1;

                    if (L[i, j] > maxLen)
                    {
                        maxLen = L[i, j];
                        endIndex = i;
                    }
                }
            }
        }

        return str1.Substring(endIndex - maxLen + 1, maxLen);
    }
}