using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bumper
{
    public class RangeLookup
    {
        public static readonly List<(int Start, int End, string Text)> ranges = new List<(int, int, string)>
            {
            (1, 10, "Trader 1"),
            (11, 20, "Trader 2"),
            };

        public string FormatNID_ENGINE(int number)
        {
            int left = 0, right = ranges.Count - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                var (start, end, Text) = ranges[mid];

                if (number < start)
                    right = mid - 1;
                else if (number > end)
                    left = mid + 1;
                else
                    return Text;
            }
            return "Unknown";
        }
    }
}








