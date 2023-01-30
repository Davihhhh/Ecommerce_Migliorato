using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Prodotto
    {

        //variabili
        private string _id;
        private string _nome;        
        private string _produttore;
        private string _descrizione;
        private double _prezzo;

        protected const char Sp = ';';
        protected Random rnd = new Random();

        //properties
        public string Id
        {
            get {
                if (_id == null)
                    throw new Exception("Id è invalido");
                else 
                    return _id;
                    }
            private set { _id = value; }
        }
        public string Nome
        {
            get
            {
                if (_nome == null)
                    throw new Exception("Nome è invalido");
                else
                    return _nome;
            }
            private set { _nome = value; }
        }
        public string Descrizione
        {
            get
            {
                if (_descrizione == null)
                    throw new Exception("Descrizione è invalido");
                else
                    return _descrizione;
            }
            private set { _descrizione = value; }
        }     
        public string Produttore
        {
            get
            {
                if (_produttore == null)
                    throw new Exception("Produttore è invalido");
                else
                    return _produttore;
            }
            private set { _produttore = value; }
        }
        public double Prezzo
        {
            get
            {
                if (_prezzo < 0)
                    throw new Exception("Prezzo è invalido");
                else
                    return _prezzo;
            }
            private set { _prezzo = value; }
        }


        //costruttori
        public Prodotto(string nome, string descrizione, string produttore, double prezzo )
        {
            Id = GeneraId();
            Nome = nome;
            Descrizione = descrizione;
            Produttore = produttore;
            Prezzo = prezzo;
        }
        public Prodotto(): this(null, null, null, -1) { }
        protected Prodotto(Prodotto nuovo) : this(nuovo.Nome, nuovo.Descrizione, nuovo.Produttore, nuovo.Prezzo) { }

        //funzioni pubbliche
        public override string ToString()
        {
            string str = this.Id + Sp + this.Nome + Sp + this.Produttore + Sp + this.Descrizione + Sp + this.Prezzo;
            return str;
        }
        public bool Equals(string id)
        {
            if (this.Id == id)
                return true;
            return false;
        }
        public Prodotto Clone()
        {
            Prodotto p = new Prodotto(this);
            p.Id = this.Id;
            return p;
            
        }

        //funzioni private
        protected string GeneraId()
        {
            int lung = 10;
            char[] id = new char[lung];
            int val = 0;
            for (int a = 0; a < lung; a++)
            {
                val = rnd.Next(48, 58);
                id[a] = Convert.ToChar(val);               
            }
            string str = new string(id);
            return str;
        }
    }
}
