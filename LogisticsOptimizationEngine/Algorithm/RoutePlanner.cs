using LogisticsOptimizationEngine.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsOptimizationEngine.Algorithm
{
    public class RoutePlanner
    {
        public string FindShortestPath(LogisticsGraph graph, string startName, string endName)
        {
            // Find the actual Node objects from the names provided by the UI
            var startNode = graph.Nodes.FirstOrDefault(l => l.Name == startName);
            var endNode = graph.Nodes.FirstOrDefault(l => l.Name == endName);

            if (startNode == null || endNode == null) return "Location not found.";

            // Setup the "Dijkstra Table"
            // distances: keeps track of the shortest distance from start to every other node
            var distances = new Dictionary<LocationNode, int>();

            // Keeps track of the best 'previous' node so we can reconstruct the path
            var previous = new Dictionary<LocationNode, LocationNode>();

            // List of nodes we haven't processed yet
            var unvisited = new List<LocationNode>();

            foreach(var node in graph.Nodes)
            {
                distances[node] = int.MaxValue; // Set initial distance to infinity
                unvisited.Add(node);
            }

            distances[startNode] = 0; // Distance to start is always 0

            // The Main Loop
            while (unvisited.Count != 0)
            {
                // Sort the unvisited nodes to find the one with the smallest distance
                unvisited.Sort((x, y) => distances[x].CompareTo(distances[y]));
                var smallest = unvisited[0];
                unvisited.Remove(smallest);

                // If we reached our destination, we are done!
                if (smallest == endNode)
                {
                    var path = new List<string>();
                    while (previous.ContainsKey(smallest))
                    {
                        path.Add(smallest.Name);
                        smallest = previous[smallest];
                    }
                    path.Add(startNode.Name);
                    path.Reverse(); // Reverse because we traced it backwards
                    return string.Join(" -> ", path) + $" (Total: {distances[endNode]} km)";
                }

                if (distances[smallest] == int.MaxValue) break;

                // Check all neighbors of the current node
                foreach (var neighbor in smallest.Neighbors)
                {
                    int alt = distances[smallest] + neighbor.Value;
                    if (alt < distances[neighbor.Key])
                    {
                        distances[neighbor.Key] = alt;
                        previous[neighbor.Key] = smallest;
                    }
                }
            }
            return "No route available.";
        }

        // ALGORITHM : Breadth-First Search (BFS) - Checks if two locations are connected
        public bool CheckConnectivity(LogisticsGraph graph, string startName, string endName)
        {
            var startNode = graph.Nodes.Find(l => l.Name == startName);
            var endNode = graph.Nodes.Find(l => l.Name == endName);

            if (startNode == null || endNode == null) return false;

            Queue<LocationNode> queue = new Queue<LocationNode>();
            HashSet<LocationNode> visited = new HashSet<LocationNode>();

            queue.Enqueue(startNode);
            visited.Add(startNode);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                if (current == endNode) return true;

                foreach (var neighbor in current.Neighbors.Keys)
                {
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        queue.Enqueue(neighbor);
                    }
                }
            }
            return false;
        }
    }
}
