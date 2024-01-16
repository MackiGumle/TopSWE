using System.Text;

namespace TopSWE;
class Program
{
    public class Solution
    {
        public void ReverseString(char[] s)
        {
            char temp;

            for(int i = 0; i < (s.Length - 1) / 2; i++)
            {
                temp = s[i];
                s[i] = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = temp;
            }

            Console.WriteLine(s);
        }
    }

    static void Main(string[] args)
    {
        Solution solution = new();

        char[] s = {'h','e','l','l','o'};
        solution.ReverseString(s);
    }
}
