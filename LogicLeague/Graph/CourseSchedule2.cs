namespace LogicLeague.Graph
{
    /// <summary>
    /// https://leetcode.com/problems/course-schedule-ii/
    /// </summary>
    internal class CourseSchedule2
    {
        public static int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            Dictionary<int, List<int>> graph = [];

            foreach (var edge in prerequisites)
            {
                if (!graph.TryGetValue(edge[0], out var pre))
                    pre = [];

                pre.Add(edge[1]);
                graph[edge[0]] = pre;
            }

            HashSet<int> visiting = [];
            HashSet<int> visited = [];
            List<int> order = [];
            for (int course = 0; course < numCourses; course++)
            {
                if (!DFS(visiting, graph, visited, order, course))
                    return [];
            }

            return [.. order];

        }

        private static bool DFS(HashSet<int> visiting, Dictionary<int, List<int>> graph, HashSet<int> visited, List<int> order, int course)
        {
            if (visiting.Contains(course)) return false;

            if (visited.Contains(course)) return true;

            visiting.Add(course);

            if (graph.TryGetValue(course, out var pre))
            {
                foreach (var preCourse in pre)
                {
                    if (!DFS(visiting, graph, visited, order, preCourse))
                        return false;
                }
            }

            visiting.Remove(course);
            graph[course] = null;

            visited.Add(course);
            order.Add(course);

            return true;
        }
    }
}
