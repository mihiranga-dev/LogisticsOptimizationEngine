using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsOptimizationEngine.DataStructures
{
    public class LogisticsGraph
    {
        public List<LocationNode> Nodes { get; set; }

        public LogisticsGraph()
        {
            Nodes = new List<LocationNode>();
        }

        // Simplest Graph Algorithm: Find all connected routes
        public string GetRoutes(LocationNode startNode)
        {
            string routes = $"Routes from {startNode.Name}:\n";
            foreach (var connection in startNode.Connections)
            {
                routes += $" -> to {connection.Key.Name} is {connection.Value}km\n";
            }
            return routes;
        }
    }
}
