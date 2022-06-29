using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June_2022
{
    public class QueueReconstructionByHeight
    {
        public static void Main(string[] args)
        {
            int[][] people = new int[6][];
            people[0] = new int[2] { 7, 0 };
            people[1] = new int[2] { 4, 4 };
            people[2] = new int[2] { 7, 1 };
            people[3] = new int[2] { 5, 0 };
            people[4] = new int[2] { 6, 1 };
            people[5] = new int[2] { 5, 2 };

            int[][] result = ReconstructQueue(people);
        }

        private static int[][] ReconstructQueue(int[][] people)
        {
            List<Person> list = new List<Person>();
            foreach(var person in people)
            {
                var peopleObj = new Person(person[0], person[1]);
                list.Add(peopleObj);
            }
            var result = list.OrderBy()
        }
    }

    public class Person
    {
        public int Height { get; set; }
        public int Position { get; set; }

        public Person(int height, int position)
        {
            this.Height = height;
            this.Position = position;
        }

        public int[] ToArray() => new[] { Height, Position };
    }
}
