using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrijavaKorisnika
{
    public class idzaposlenik
    {
        private static int _idzaposlenik;

        public static int idzapo
        {
            get
            {
                return _idzaposlenik;
            }
            set
            {
                _idzaposlenik = value;
            }
        }
    }
}
