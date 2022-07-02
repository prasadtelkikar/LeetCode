using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Dream
{
    public class MeetingRoom2
    {
        public static void Main(string[] args)
        {
            int[][] intervals = new int[3][];
            intervals[0] = new int[] { 0, 30 };
            intervals[1] = new int[] { 5, 10 };
            intervals[2] = new int[] { 15, 20 };

            int result = MinMeetingRooms(intervals);
            Console.WriteLine(result);
        }

        private static int MinMeetingRooms(int[][] intervals)
        {
            int meetingRoomCount = 0;
            int startIndex = 0;
            int endIndex = 0;
            int result = 0;
            var startTimes = intervals.Select(x => x[0]).OrderBy(x => x).ToArray();
            var endTimes = intervals.Select(x => x[1]).OrderBy(x => x).ToArray();
           
            while(startIndex < intervals.Length)
            {
                if(startTimes[startIndex] < endTimes[endIndex])
                {
                    meetingRoomCount++;
                    startIndex++;
                }
                else
                {
                    endIndex++;
                    meetingRoomCount--;
                }
                result = Math.Max(result, meetingRoomCount);
            }
            return result;
        }
    }

    public class MeetingRoomTime
    {
        public int StartTime { get; set; }
        public int EndTime { get; set; }

        public int Duration { get; private set; }

        public MeetingRoomTime(int[] interval)
        {
            this.StartTime = interval[0];
            this.EndTime = interval[1];
            this.Duration = this.EndTime - this.StartTime;
        }
    }
}
