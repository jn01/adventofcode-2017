using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Part1.ConsoleApp
{
    public class DifferenceFinder
    {
        public int GetDifference(string row, string delimiter)
        {
            var values = row.Split(delimiter, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x));

            return values.Max() - values.Min();
        }
    }
}
