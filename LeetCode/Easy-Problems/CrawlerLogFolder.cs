using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class CrawlerLogFolder
    {
        public static void Main(string[] args)
        {
            string[] logs = Console.ReadLine().Split(' ');
            int result = MinOperations(logs);
            Console.WriteLine(result);
        }

        private static int MinOperations(string[] logs)
        {
            int distance = 0;
            foreach (string log in logs)
            {
                if (log == "../")
                {
                    if (distance > 0)
                        distance--;
                }
                else if (log == "./")
                    continue;
                else
                    distance++;
            }
            return distance;
        }
    }
}
