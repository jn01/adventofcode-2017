using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Part2.ConsoleApp
{
    public class EvenlyDividesFinder
    {
        public int Get(IEnumerable<int> row)
        {
            var result = row.SelectMany(
                x => row,
                (y, z) => { return new { y = y, z = z }; })
                .Where(x => x.y != x.z
                    && x.y % x.z == 0)
                .Select(x => x.y / x.z)
                .FirstOrDefault();

            return result;
        }
    }
}
