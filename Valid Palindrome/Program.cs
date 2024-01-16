using System.Text;

namespace TopSWE;
class Program
{
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            s = s.ToLower();

            HashSet<char> lookup = new();

            for (char i = 'a'; i <= 'z'; i++)
                lookup.Add(i);

            s = String.Concat(s.Where(c => lookup.Contains(c)));

            for (int i = 0; i < s.Length - 1; i++)
                if (s[i] != s[s.Length - 1 - i])
                    return false;
            
            return true;
        }
    }

    static void Main(string[] args)
    {
        Solution solution = new();

        string s = "A man, a plan, a canal: Panama";
        Console.WriteLine(solution.IsPalindrome(s));
    }
}
