using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class MinSeatMovement
    {
        public static void Main(string[] args)
        {
            var seats = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(x => x).ToArray();
            var students = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(x => x).ToArray();
            decimal diff = 0;
            for (int i = 0; i < seats.Length; i++)
            {
                diff += Math.Abs(seats[i]- students[i]);
            }
            Console.WriteLine(diff);
        }
    }

    
}
