using System;
using System.Collections.Generic;
using System.Text;

namespace Easy_II.Helper
{
    public class Vertex
    {
        public string Name { get; set; }
        public List<string> Edges { get; set; }

        public Vertex(string name)
        {
            this.Name = name;
            Edges = new List<string>();
        }
    }
}
