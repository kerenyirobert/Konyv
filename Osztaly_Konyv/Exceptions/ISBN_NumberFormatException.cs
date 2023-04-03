using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv.Exceptions
{
    public class ISBN_NumberFormatException : Exception
    {
        public ISBN_NumberFormatException()
        {

        }

        public override string Message => "Az ISBN száma nem megfelelő!";
    }
}
