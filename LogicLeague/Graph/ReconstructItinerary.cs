
using System;

namespace LogicLeague.Graph
{
    internal class ReconstructItinerary
    {
        public static IList<string> FindItinerary(IList<IList<string>> tickets)
        {
            Dictionary<string, List<string>> graph = [];

            foreach (var item in tickets)
            {
                if (!graph.TryGetValue(item[0], out var n1))
                    n1 = [];

                n1.Add(item[1]);
                graph[item[0]] = n1;
            }

            foreach (var key in graph.Keys)
            {
                graph[key].Sort();
            }

            LinkedList<string> result = new();

            DFS("JFK", result, graph);

            return result.ToList();
        }

        private static void DFS(string airport, LinkedList<string> result, Dictionary<string, List<string>> graph)
        {
            graph.TryGetValue(airport, out var destinations);
            while(destinations is not null && destinations.Count > 0)
            {
                var next = destinations[0];
                graph[airport].RemoveAt(0);
                DFS(next, result, graph);
            }

            result.AddFirst(airport);
        }
    }
}
