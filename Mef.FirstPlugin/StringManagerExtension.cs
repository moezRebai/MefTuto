using Mef.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mef.FirstPlugin
{
    [Export(typeof(IStringManager))]
    public class StringManagerExtension : IStringManager
    {
        public string Description
        {
            get
            {
                return "String Concat from Plugin 1";
            }
        }

        public string ManipulateString(string a, string b)
        {
            return string.Concat(a, b);
        }
    }
}
