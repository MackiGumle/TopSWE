using System.Text;

namespace TopSWE;
class Program
{
    public class Solution
    {
        public IList<string> FizzBuzz(int n)
        {
            List<string> list = new();

            for(int i = 1; i <= n; i++)
            {
                StringBuilder sb = new();
                
                if(i % 3 == 0)
                    sb.Append("Fizz");
                if(i % 5 == 0)
                    sb.Append("Buzz");
                
                if(sb.Length == 0)
                    sb.Append(i.ToString());

                list.Add(sb.ToString());
            }

            return list;
        }
    }

    static void Main(string[] args)
    {
        Solution solution = new();

        foreach(var elem in solution.FizzBuzz(5))
            Console.WriteLine(elem);
    }
}
