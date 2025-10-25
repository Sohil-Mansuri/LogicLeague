
namespace LogicLeague.Graph
{
    /// <summary>
    /// https://leetcode.com/problems/course-schedule/
    /// </summary>
    internal class CourseSchedule
    {
        public static bool CanFinish(int numCourses, int[][] prerequisites)
        {
            Dictionary<int, List<int>> graph = [];
            Stack<int> order = [];

            foreach (var pre in prerequisites)
            {
                if (!graph.TryGetValue(pre[0], out var dependnecy))
                    dependnecy = [];

                dependnecy.Add(pre[1]);
                graph[pre[0]] = dependnecy;
            }

            HashSet<int> visiting = [];
            HashSet<int> visited = [];

            for (int course = 0; course < numCourses; course++)
            {
                if (!CanSchedule(course, visiting, graph, order, visited))
                    return false;

                visited.Add(course);
            }

            return true;

        }

        private static bool CanSchedule(int course, HashSet<int> visiting, Dictionary<int, List<int>> graph, Stack<int> order, HashSet<int> visited)
        {
            if (visiting.Contains(course)) return false;

            if (!graph.TryGetValue(course, out var item) || item is null)
            {
                if (!visited.Contains(course))
                {
                    order.Push(course);
                    visited.Add(course);
                }

                return true;
            }

            visiting.Add(course);

            foreach (var dependnecy in graph[course])
            {
                if (!CanSchedule(dependnecy, visiting, graph, order, visited))
                    return false;
            }

            visiting.Remove(course);
            visited.Add(course);
            graph[course] = null;
            order.Push(course);
            return true;
        }


        public static bool CanFinishV2(int numCourses, int[][] prerequisites)
        {
            Dictionary<int, HashSet<int>> graph = [];
            Dictionary<int, int> indegree = [];

            foreach (var course in prerequisites)
            {
                if (!graph.ContainsKey(course[0]))
                    graph[course[0]] = [];

                if (!graph.ContainsKey(course[1]))
                    graph[course[1]] = [];

                graph[course[0]].Add(course[1]);
                indegree[course[1]] = indegree.GetValueOrDefault(course[1], 0) + 1;
                indegree[course[0]] = indegree.GetValueOrDefault(course[0], 0);
            }

            Queue<int> queue = new(indegree.Where(w => w.Value == 0).Select(s => s.Key));

            IList<int> result = [];

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();
                result.Add(current);

                foreach (var neighbour in graph[current])
                {
                    indegree[neighbour]--;
                    if (indegree[neighbour] == 0)
                        queue.Enqueue(neighbour);
                }
            }

            if (graph.Count != result.Count)
                return false;

            return true;
        }
    }
}
