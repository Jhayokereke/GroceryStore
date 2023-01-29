using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Commons.Utilities
{
    public static class Generator
    {
        public static string GenerateId()
        {
            return Guid.NewGuid().ToString();
        }

        public static string GenerateId(int length, string prefix)
        {
            return prefix + "-" + Guid.NewGuid().ToString().Substring(0, length);
        }
    }
}
