using System.Text;

namespace TopSWE;


class Program
{
    public class Solution
    {
        public int HammingWeight(uint n)
        {
            if (n == 0)
                return 0;

            int count = 0;

            for (int i = 0; i < sizeof(uint) * 8; i++)
                if ((1 & (n >> i)) == 1)
                    count++;

            return count;
        }
    }

    static void Main(string[] args)
    {
        Solution solution = new();
        string[] strs = { "flower", "flow", "flight" };

        Console.WriteLine(solution.HammingWeight(11));
    }
}
