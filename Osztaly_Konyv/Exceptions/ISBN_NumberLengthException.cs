using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztaly_Konyv.Exceptions
{
    internal class ISBN_NumberLengthException : Exception
    {
        private int length;

        public ISBN_NumberLengthException(int length)
        {
            this.length = length;
        }
        public override string Message => $"Az ISBN számnak 10 vagy 13 hosszúnak kell lenni!\nEz a feltétel nem teljesült! (Hossz: {length})";
    }
}
