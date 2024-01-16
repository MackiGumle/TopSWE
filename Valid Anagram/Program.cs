using System.Text;
using System.Collections.Generic;

namespace TopSWE;
class Program
{
    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            string ss = String.Concat(s.OrderBy(c => c));
            string ts = String.Concat(t.OrderBy(c => c));
            
            return ss.Equals(ts);
        }
    }

    static void Main(string[] args)
    {
        Solution solution = new();

        Console.WriteLine(solution.IsAnagram("anagram", "nagaram"));
    }
}
