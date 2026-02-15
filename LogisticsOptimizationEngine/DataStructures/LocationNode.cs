using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsOptimizationEngine.DataStructures
{
    public class LocationNode
    {
        public string Name { get; set; }
        // Store edges as: <Target Node, Distance in km>
        public Dictionary<LocationNode, int> Neighbors { get; set; }

        public LocationNode(string name)
        {
            Name = name;
            Neighbors = new Dictionary<LocationNode, int>();
        }

        public void AddNeighbor(LocationNode target, int distance)
        {
            Neighbors[target] = distance;
        }
    }
}
