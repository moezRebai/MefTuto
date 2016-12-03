using System;

namespace MefExmaples
{
    public class Program
    {
        static void Main(string[] args)
        {
            ExtensionsLoader loader = new ExtensionsLoader();

            loader.ImportPlugins();

            System.Console.WriteLine(string.Format("{0} plugins are loaded", loader.NumberOfImportedOperations));

            var result = loader.CallImportedPlugins("Mef Plugins example ", "Plugins");

            foreach (string item in result)
            {
                System.Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
