using System.Text;

namespace LogicLeague
{
    /// <summary>
    /// https://leetcode.com/problems/text-justification/description/
    /// </summary>
    internal class TestJustification
    {
        public static IList<string> FullJustify(string[] words, int maxWidth)
        {
            if (words == null || words.Length == 0) return null;

            IList<string> result = [];

            int index = 0;

            while (index < words.Length)
            {
                int count = words[index].Length;
                int last = index + 1;
                while (last < words.Length)
                {
                    if (count + 1 + words[last].Length > maxWidth) break;

                    count += 1 + words[last].Length;

                    last++;
                }

                StringBuilder sb = new();
                sb.Append(words[index]);

                int diff = last - index - 1;

                if (last == words.Length || diff == 0)
                {
                    for (int i = index + 1; i < last; i++)
                    {
                        sb.Append(' ');
                        sb.Append(words[i]);
                    }

                    for (int i = sb.Length; i < maxWidth; i++)
                    {
                        sb.Append(' ');
                    }
                }
                else
                {
                    int spaces = (maxWidth - count) / diff;
                    int extraSpaces = (maxWidth - count) % diff;

                    for (int i = index + 1; i < last; i++)
                    {
                        for (int s = spaces; s > 0; s--)
                        {
                            sb.Append(' ');
                        }

                        if (extraSpaces > 0)
                        {
                            sb.Append(' ');
                            extraSpaces--;
                        }

                        sb.Append(' ');
                        sb.Append(words[i]);
                    }
                }

                index = last;
                result.Add(sb.ToString());
            }


            return result;
        }
    }
}
