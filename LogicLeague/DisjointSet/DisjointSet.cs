namespace LogicLeague.DisjointSet
{
    internal class DisjointSet
    {
        public int[] Parent { get; set; }
        public int[] Rank { get; set; }
        public int[] Size { get; set; }

        public int Components { get; private set; }

        public DisjointSet(int size)
        {
            Parent = new int[size];
            Rank = new int[size];
            Size = new int[size];
            for (int i = 0; i < size; i++)
            {
                Parent[i] = i;
                Rank[i] = 0;
                Size[i] = 1;
            }
            Components = size;
        }

        //Amortized O(α(n))
        public int Find(int x)
        {
            if (Parent[x] != x)
            {
                Parent[x] = Find(Parent[x]);
            }
            return Parent[x];
        }

        //Amortized O(α(n))
        public int FindV2(int x)
        {
            while (Parent[x] != x)
            {
                Parent[x] = Parent[Parent[x]];
                x = Parent[x];
            }
            return x;
        }

        public void Union(int x, int y)
        {
            int rootX = Find(x);
            int rootY = Find(y);
            if (rootX != rootY)
            {
                Parent[rootY] = rootX;
            }

            Components--;
        }

        public void UnionByRank(int x, int y)
        {
            int rootX = Find(x);
            int rootY = Find(y);
            if (rootX != rootY)
            {
                if (Rank[rootX] > Rank[rootY])
                {
                    Parent[rootY] = rootX;
                }
                else if (Rank[rootX] < Rank[rootY])
                {
                    Parent[rootX] = rootY;
                }
                else
                {
                    Parent[rootY] = rootX;
                    Rank[rootX]++;
                }
            }
            Components--;
        }

        public void UnionBySize(int x, int y)
        {
            int rootX = Find(x);
            int rootY = Find(y);
            if (rootX != rootY)
            {
                if (Size[rootX] > Size[rootY])
                {
                    Parent[rootY] = rootX;
                    Size[rootX] += Size[rootY];
                }
                else
                {
                    Parent[rootX] = rootY;
                    Size[rootY] += Size[rootX];
                }
            }

            Components--;

        }
    }

}
