using System;
using System.Collections.Generic;
using System.Text;

namespace Easy_II.Helper
{
    public class Graph
    {
        public List<Vertex> AdjacencyList { get; set; }
        public Graph()
        {
            AdjacencyList = new List<Vertex>();
        }
    }
}
