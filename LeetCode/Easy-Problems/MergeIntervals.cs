using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class MergeIntervals
    {
        public static void Main(string[] args)
        {
            int[][] intervals = new int[4][];

            intervals[0] = new int[]{ 1, 3 };
            intervals[1] = new int[]{ 2, 6 };
            intervals[2] = new int[] { 8, 10 };
            intervals[3] = new int[] { 15, 18 };

            int[][] result = Merge(intervals);

            foreach(var meeting in result)
                Console.WriteLine($"{meeting[0]}, {meeting[1]}");
        }

        private static int[][] Merge(int[][] intervals)
        {
            var meetings = intervals.Select(x => new Meeting(x)).OrderBy(x => x.Start).ToArray();
            List<Meeting> result = new List<Meeting>();
            result.Add(meetings[0]);
            for(int i = 1; i < meetings.Length; i++)
            {
                var currentMeeting = meetings[i];
                int lastIndex = result.Count - 1;
                if (currentMeeting.Start <= result[lastIndex].End)
                    result[lastIndex].End = Math.Max(currentMeeting.End, result[lastIndex].End);
                else
                    result.Add(currentMeeting);
            }
            return result.Select(x => new int[] { x.Start, x.End }).ToArray();
        }

    }

    public class Meeting
    {
        public int Start { get; set; }
        public int End { get; set; }

        public Meeting(int[] timings)
        {
            this.Start = timings[0];
            this.End = timings[1];
        }

        public Meeting(int start, int end)
        {
            this.Start = start;
            this.End= end;
        }
    }
}
