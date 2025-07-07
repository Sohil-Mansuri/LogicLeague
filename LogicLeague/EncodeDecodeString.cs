using System.Text;

namespace LogicLeague
{
    internal class EncodeDecodeString
    {
        private const string Separator = "#";
        public static string EncodeString(string[] inputStrings)
        {

            StringBuilder encoded = new();
            foreach (string str in inputStrings)
            {
                encoded.Append(str);
                encoded.Append(Separator);
            }

            encoded.Remove(encoded.Length - 1, 1);

            return encoded.ToString();
        }

        public static string[] Decode(string input)
        {
            return input.Split(Separator);
        }
    }
}
