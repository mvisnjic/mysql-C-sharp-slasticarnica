using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrijavaKorisnika
{
    public class infozaposlenik
    {
        private static string _imezapo;

        public static string imezapo
        {
            get
            {
                return _imezapo;
            }
            set
            {
                _imezapo = value;
            }
        }
    }
}
