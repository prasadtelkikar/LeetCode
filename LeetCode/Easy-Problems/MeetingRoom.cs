using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class MeetingRoom
    {
        public static void Main(string[] args)
        {
            int[][] intervals = new int[2][];
            //intervals[0] = new int[] { 0, 30 };
            //intervals[1] = new int[] { 5, 10 };
            //intervals[2] = new int[] { 15, 20 };

            intervals[0] = new int[] { 7, 10 };
            intervals[1] = new int[] { 2, 4 };

            bool canAttendAllMeeting = CanAttendMeetings(intervals);
            Console.WriteLine(canAttendAllMeeting);
        }

        private static bool CanAttendMeetings(int[][] intervals)
        {
            var meetings = intervals.Select(x => new MeetingTime(x)).OrderBy(x => x.Start).ToArray();
            
            for(int i = 1; i < meetings.Length; i++)
            {
                //Next start should be always higher than previous end
                if (meetings[i].Start < meetings[i-1].End)
                    return false;
            }
            return true;

        }
    }

    public class MeetingTime
    {
        public int Start { get; set; }
        public int End { get; set; }
        public MeetingTime(int[] time)
        {
            Start = time[0];
            End = time[1];
        }
    }
}
