using System.Text;

/*
"flower",
"flow",
"flight"
*/
namespace TopSWE;
class Program
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            StringBuilder sb = new();

            int min = strs.Min(s => s.Length);

            for (int i = 0; i < min; i++)
            {
                char? letter = strs[0][i];
                bool contains = false;

                foreach (var word in strs)
                    if (letter == word[i])
                        contains = true;
                    else
                        contains = false;

                if (contains)
                    sb.Append(letter);
                else
                    break;
            }

            return sb.ToString();
        }
    }

    static void Main(string[] args)
    {
        Solution solution = new();
        string[] strs = { "flower", "flow", "flight" };

        Console.WriteLine(solution.LongestCommonPrefix(strs));
    }
}
