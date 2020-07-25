using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fitnet.MBudzisz.DAL
{
    public class HardDriveInspector : IFileInspector
    {
        public int InspectFile(FileInfo file, string lookupValue)
        {
            var contents = File.ReadAllText(file.FullName);
            int count = 0;
            int i = 0;
            while ((i = contents.IndexOf(lookupValue, i)) != -1)
            {
                Thread.Sleep(1000);
                i += lookupValue.Length;
                count++;
            }
            return count;
        }
    }
}
