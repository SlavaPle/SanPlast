using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanPlast.Dane
{
    static class Dane
    {
        public static DataSet DS { get; private set; }
        public static void ReadDS()
        {
            DS = new DataSet();
            DS.ReadXml(@"F:\SanPlast\Baza.xml");
        }
    }
}
