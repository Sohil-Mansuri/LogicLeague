namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/detect-squares/description/
    /// </summary>
    public class DetectSquares
    {

        private Dictionary<int, Dictionary<int, int>> _map;

        public DetectSquares()
        {
            _map = [];
        }

        public void Add(int[] point)
        {
            if (_map.ContainsKey(point[0]))
            {
                if (_map[point[0]].TryGetValue(point[1], out int value))
                {
                    _map[point[0]][point[1]] = ++value;
                }
                else
                {
                    _map[point[0]].Add(point[1], 1);
                }
            }
            else
            {
                _map.Add(point[0], new Dictionary<int, int> { { point[1], 1 } });
            }
        }

        public int Count(int[] point)
        {
            int x1 = point[0], y1 = point[1];

            if (!_map.TryGetValue(x1, out var secondPoints)) return 0;

            int result = 0;

            foreach (var secondPoint in secondPoints)
            {
                int y2 = secondPoint.Key;

                if (y1 == y2) continue;

                var sideLength = Math.Abs(y1 - y2);

                result += GetCount(x1 + sideLength, y1, y2, secondPoint.Value);
                result += GetCount(x1 - sideLength, y1, y2, secondPoint.Value);
            }

            return result;
        }

        public int GetCount(int x3x4, int y2, int y1, int y2Frequency)
        {
            if (_map.TryGetValue(x3x4, out var y3y4) && y3y4.TryGetValue(y2, out var y3) && y3y4.TryGetValue(y1, out var y4))
            {
                return y2Frequency * y3 * y4;
            }

            return 0;
        }
    }

}
