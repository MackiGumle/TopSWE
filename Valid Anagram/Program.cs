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

            int sum = 0;

            foreach (var character in s)
                sum += character;

            int sum2 = 0;

            foreach (var character in t)
                sum2 += character;

            if(sum == sum2)
                return true;

            return false;
        }
    }

    static void Main(string[] args)
    {
        Solution solution = new();

        Console.WriteLine(solution.IsAnagram("anagram", "nagaram"));
    }
}
