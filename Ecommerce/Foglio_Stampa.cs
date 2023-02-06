using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Foglio_Stampa : Cancelleria
    {
        private string _grammatura;

        public string Grammatura
        {
            get { return _grammatura; }
            set
            {
                if (value == null)
                    throw new Exception("Grammatura invalida");
                else
                    _grammatura = value;
            }
        }
    }
}
