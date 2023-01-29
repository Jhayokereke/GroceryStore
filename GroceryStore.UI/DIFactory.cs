using GroceryStore.Core;
using GroceryStore.Data;
using System;

namespace GroceryStore.UI
{
    public static class DIFactory
    {
        public static DataStore Database { get; set; }
        public static IProductRepository ProductRepo { get; private set; }

        public static object GenerateDI(string nameOf)
        {
            switch (nameOf)
            {
                case "IStore":
                    return new StoreKeeper(Database, ProductRepo);
                default:
                    return null;
            }
        }

        internal static void Initialize()
        {
            Database = new DataStore();
            ProductRepo = new ProductRepository(Database);
        }
    }
}
