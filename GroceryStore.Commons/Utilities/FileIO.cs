using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Commons.Utilities
{
    public class FileIO
    {
        public FileIO(string basePath)
        {
            _baseDir = basePath;
        }
        private readonly string _baseDir;
        public bool GenerateReceipt(string text)
        {
            var path = $@"{_baseDir}\CustomerReceipt{DateTime.UtcNow.ToFileTimeUtc()}.txt";

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine($"Customer Receipt\n" +
                    $"{DateTime.Now.ToString("ddd, dd MMM yyyy hh:mm:ss tt")}");
                sw.WriteLine(text);
            }
            
            return false;
        }
    }
}
