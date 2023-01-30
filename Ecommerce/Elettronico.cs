using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce
{
    public class Elettronico : Prodotto
    {
        //variabili
        private string _modello;       
        private string _giorno;
        private double _sconto = 5;   

        //properties
        public string Modello
        { get { return _modello; } private set { _modello = value; } }
        public double Sconto
        { get { return _sconto; } private set { _sconto = value; } }
        public string Giorno
        { get { return _giorno; } private set { _giorno = value; } }       
        public override double Prezzo
        { get { return Prezzo; } }

        //costruttori
        public Elettronico(string nome, string modello, string descrizione, string produttore, double prezzo) : base(nome, descrizione, produttore, prezzo)
        {        
            Modello = modello; 
            
        }

        //funzioni
        private double GetPrezzoScontato()
        {
           
        }
        private string GiornoDellaSettimana()
        {
            DayOfWeek giorno = DateTime.Today.DayOfWeek;
            return giorno.ToString();
        }
        
        
    }
}
