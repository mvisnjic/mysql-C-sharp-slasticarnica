using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrijavaKorisnika 
{ 

    public class infomanager
{
    private static string _imemana;

    public static string imemana
    {
        get
        {
            return _imemana;
        }
        set
        {
            _imemana = value;
        }
    }
}
}
