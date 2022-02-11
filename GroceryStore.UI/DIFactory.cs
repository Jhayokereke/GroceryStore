using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.UI
{
    public static class DIFactory
    {

        public static object GenerateDI(string nameOf)
        {
            switch (nameOf)
            {
                case "IStore":
                    return new Store();
                default:
                    return null;
            }
        }
    }
}
