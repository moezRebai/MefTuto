using Mef.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Linq;
using System.Reflection;

namespace MefExmaples.Helpers
{

    public class ExtensionsLoader
    {
        [ImportMany(typeof(IStringManager))]
        private IEnumerable<IStringManager> _allStringOperations;

        public void ImportPlugins()
        {
            string exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string path = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Referenced Assemblies");
             
            var catalog = new AggregateCatalog();

            //Ajouter tous les classes ou bien les "parts" dans 
            // les differents assemblies qui se trouve dans le meme dossier d'exectuion.
            catalog.Catalogs.Add(new DirectoryCatalog(path));
            //catalog.Catalogs.Add(new DirectoryCatalog(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)));

            //Creer les contenaire des imports( dependences) CompositionContainer a partir des parties exportés 
            // dans le catalog
            CompositionContainer container = new CompositionContainer(catalog);

            //Executer le binding entre les exports et les imports
            container.ComposeParts(this);
        }

        public int NumberOfImportedOperations
        {
            get
            {
                return (_allStringOperations != null ? _allStringOperations.Count() : 0);
            }
        }

        public List<string> CallImportedPlugins(string a, string b)
        {
            var result = new List<string>();

            foreach (var item in _allStringOperations)
            {
                Console.WriteLine(item.Description);
                var res = item.ManipulateString(a, b);
                result.Add(res);
            }

            return result;
        }
    }
}
