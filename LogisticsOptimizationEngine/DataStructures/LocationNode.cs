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
        public string Name {  get; set; }

        // Dictionary holds: <Target Location, Distance>
        public Dictionary<LocationNode, int> Connections {  get; set; }

        public LocationNode(string name)
        {
            Name = name;
            Connections = new Dictionary<LocationNode, int>();
        }

        public void AddConnection(LocationNode target, int distance)
        {
            Connections[target] = distance;
        }
    }
}
