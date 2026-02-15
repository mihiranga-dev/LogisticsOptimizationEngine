using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsOptimizationEngine.DataStructures
{
    // This is the "Container" for our map
    public class LogisticsGraph
    {
        public List<LocationNode> Nodes { get; set; }

        public LogisticsGraph()
        {
            Nodes = new List<LocationNode>();
        }
    }
}