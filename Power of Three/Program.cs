using System.Text;
using Microsoft.VisualBasic;

namespace TopSWE;


class Program
{
    public class Solution
    {
        public bool IsPowerOfThree(int n)
        {
            if(n <= 0)
                return false;

            return (1162261467) % n == 0 ? true : false;
        }
    }

    static void Main(string[] args)
    {
        Solution solution = new();

        Console.WriteLine(int.MaxValue % 3);
        Console.WriteLine((int.MaxValue - 1) % 3);
        Console.WriteLine(Math.Log(int.MaxValue - 1, 3));
        Console.WriteLine(Math.Pow(3, 19)); // equals 1162261467

        Console.WriteLine(solution.IsPowerOfThree(27));
    }
}
