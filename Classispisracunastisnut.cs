using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrijavaKorisnika
{
    class classbutton
    {
        private static bool _ispisgumb;
        public static bool printbutton
        {
            get
            {
                return _ispisgumb;
            }
            set
            {
                _ispisgumb = value;
            }
        }
    }
}
/*    
 *    
 *  private static string _imemana;

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
*/