namespace LogicLeague
{
    public class TimeMap
    {
        private readonly Dictionary<string, List<(int Timestamp, string Value)>> _map;

        public TimeMap()
        {
            _map = [];
        }

        public void Set(string key, string value, int timestamp)
        {
            if (!_map.TryGetValue(key, out var list))
            {
                list = [];
                _map[key] = list;
            }

            list.Add((timestamp, value));
        }

        public string Get(string key, int timestamp)
        {
            if (!_map.TryGetValue(key, out var list))
                return "";

            int left = 0, right = list.Count - 1;
            string result = "";

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (list[mid].Timestamp <= timestamp)
                {
                    result = list[mid].Value;
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return result;
        }
    }
}
