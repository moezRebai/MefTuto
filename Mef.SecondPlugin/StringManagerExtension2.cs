using Mef.Contracts;
using System.ComponentModel.Composition;

namespace Mef.SecondPlugin
{
    [Export(typeof(IStringManager))]
    public class StringManagerExtension2 : IStringManager
    {
        public string Description
        {
            get
            {
                return "String replace from Plugin 2";
            }
        }

        public string ManipulateString(string a, string b)
        {
            return a.Replace(b, string.Empty);
        }
    }
}
