using GroceryStore.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStore.UI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var products = GroceryStore.Core.Program.CreateProducts();
            var store = (IStore)DIFactory.GenerateDI("IStore");
            store.Products = products;
            Application.Run(new Checkout(store));
        }
    }
}
