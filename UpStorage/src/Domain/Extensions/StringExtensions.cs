using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Extensions
{
    public static class StringExtensions
    {
        public static bool IsContainsChar(this string text)
        {
            var results = text.Select(x => char.IsLetter(x));

            if (results.Count(x=>x==true))
            {
                return true;
            }
            return false;
        }
    }
}
