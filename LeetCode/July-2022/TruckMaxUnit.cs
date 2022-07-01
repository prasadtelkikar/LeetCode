using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace July_2022
{
    public class TruckMaxUnit
    {
        public static void Main(string[] args)
        {
            int[][] boxTypes = new int[10][];
            boxTypes[0]= new int[] { 2, 1 };
            boxTypes[1]= new int[] { 4, 4 };
            boxTypes[2]= new int[] { 3, 1 };
            boxTypes[3]= new int[] { 4, 1 };
            boxTypes[4]= new int[] { 2, 4 };
            boxTypes[5]= new int[] { 3, 4 };
            boxTypes[6]= new int[] { 1, 3 };
            boxTypes[7]= new int[] { 4, 3 };
            boxTypes[8]= new int[] { 5, 3 };
            boxTypes[9]= new int[] { 3, 3 };

            int truckSize = 13;

            int result = MaximumUnits(boxTypes, truckSize);
            Console.WriteLine(result);
        }

        private static int MaximumUnits(int[][] boxTypes, int truckSize)
        {
            List<Container> containers = new List<Container>();
            for(int i = 0; i < boxTypes.Length; i++)
            {
                var container = new Container(boxTypes[i]);
                containers.Add(container);
            }
            containers = containers.OrderByDescending(x => x.BoxUnits).ToList();
            int result = 0;
            for(int i = 0;i < containers.Count;i++)
            {
                if(truckSize >= containers[i].NumberOfBoxes)
                {
                    truckSize -= containers[i].NumberOfBoxes;
                    result += containers[i].Total;
                }
                else
                {
                    result += truckSize * containers[i].BoxUnits;
                    break;
                }
            }

            return result;
        }
    }

    public class Container
    {
        public int NumberOfBoxes { get; set; }
        public int BoxUnits { get; set; }

        public int Total { get; set; }

        public Container(int[] arr)
        {
            this.NumberOfBoxes = arr[0];
            this.BoxUnits = arr[1];
            this.Total = this.NumberOfBoxes * this.BoxUnits;
        }
    }
}
