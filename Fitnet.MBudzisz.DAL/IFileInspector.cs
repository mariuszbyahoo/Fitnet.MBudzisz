using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitnet.MBudzisz.Utils
{
    public interface IFileInspector
    {
        int InspectFile(FileInfo file, string lookupValue);
    }
}
