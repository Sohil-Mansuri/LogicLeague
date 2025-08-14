namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/design-twitter/
    /// </summary>
    public class Twitter
    {
        private readonly Dictionary<int, HashSet<int>> _followees = [];
        private readonly Dictionary<int, List<(int tweetId, int time)>> _posts = [];
        private int _timeStamp = 0;

        public void PostTweet(int userId, int tweetId)
        {
            if (!_posts.ContainsKey(userId))
                _posts[userId] = [];

            _posts[userId].Add((tweetId, _timeStamp++));
        }

        public IList<int> GetNewsFeed(int userId)
        {
            List<(int tweetId, int time)> allPosts = [];
            List<int> result = [];

            if (_posts.ContainsKey(userId))
                allPosts.AddRange(_posts[userId]);

            // Add tweets from followees
            if (_followees.ContainsKey(userId))
            {
                foreach (var followee in _followees[userId])
                {
                    if (_posts.ContainsKey(followee))
                        allPosts.AddRange(_posts[followee]);
                }
            }


            var minHeap = new PriorityQueue<int, int>();

            foreach (var post in allPosts)
            {
                minHeap.Enqueue(post.tweetId, post.time);

                if (minHeap.Count > 10)
                    minHeap.Dequeue();
            }

            while (minHeap.Count > 0)
            {
                result.Add(minHeap.Dequeue());
            }

            result.Reverse();

            return result;
        }

        public void Follow(int followerId, int followeeId)
        {
            if (!_followees.ContainsKey(followerId))
                _followees[followerId] = [];

            _followees[followerId].Add(followeeId);
        }

        public void Unfollow(int followerId, int followeeId)
        {
            if (_followees.ContainsKey(followerId))
                _followees[followerId].Remove(followeeId);
        }
    }
}
