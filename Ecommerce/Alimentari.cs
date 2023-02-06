using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Alimentari : Prodotto
    {
        //variabili
        private string[] _ingredienti;

        private DateTime Data = new DateTime();
        private int MaxIngredienti = 10;

        //costruttori
        public Alimentari(string nome, string descrizione, string produttore, double prezzo, string[] ingredienti, int maxIngredienti): base (nome, descrizione, produttore, prezzo)
        {
            _ingredienti = ingredienti;
            MaxIngredienti = maxIngredienti;
        }

        

    }
}
