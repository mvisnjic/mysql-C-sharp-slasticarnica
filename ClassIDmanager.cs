using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrijavaKorisnika
{
    public class idmanager
    {
        private static int _idmanager;

        public static int idmana
        {
            get
            {
                return _idmanager;
            }
            set
            {
                _idmanager = value;
            }
        }
    }
}


