using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitnet.MBudzisz.DAL
{
    public interface IDataInspector
    {
        Task InspectDataLayer(string pathToDataSource, string lookupString);
    }
}
