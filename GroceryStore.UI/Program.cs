using GroceryStore.Core;
using GroceryStore.Data;
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
            DIFactory.Initialize();
            var storeKeeper = (IStoreKeeper)DIFactory.GenerateDI("IStore");
            Application.Run(new Checkout(storeKeeper));
        }
    }
}
