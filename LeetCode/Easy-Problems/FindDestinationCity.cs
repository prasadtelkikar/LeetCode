using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Problems
{
    public class FindDestinationCity
    {
        public static void Main(string[] args)
        {
            FindDestinationCity destinationCity = new FindDestinationCity();
            IList<IList<string>> list = new List<IList<string>>();
            list.Add(new List<string>() { "London", "New York" });
            list.Add(new List<string>() { "New York", "Lima" });
            list.Add(new List<string>() { "Lima", "Sao Paulo" });
            string result = destinationCity.DestCity(list);
            Console.WriteLine(result);
        }

        //Where there is zero destination, that will be the output
        private string DestCity(IList<IList<string>> paths)
        {
            Dictionary<string, int> graph = new Dictionary<string, int>();
            foreach (IList<string> path in paths)
            {
                string source = path[0];
                string destination = path[1];

                if (graph.ContainsKey(source))
                    graph[source]++;
                else
                    graph.Add(source, 1);

                if(!graph.ContainsKey(destination))
                    graph.Add(destination, 0);

            }
            return graph.First(x => x.Value == 0).Key;
        }
    }
}
