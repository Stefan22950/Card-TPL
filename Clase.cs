using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace InterfataGrafica
{

    public class Persoana
    {
        //public string nume, prenume, categorie, cnp;
        public int ID_pers { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public string categorie { get; set; }
        public string cnp { get; set; }

        public string FullInfo
        {
            get
            {
                return $"{ID_pers} {nume} {prenume} {categorie} {cnp}";
            }

        }


        public Persoana()
        {
            nume = string.Empty;
            prenume = string.Empty;
            categorie = string.Empty;
            cnp = string.Empty;
        }

        public Persoana(int _ID_pers,string _nume, string _prenume, string _categorie, string _cnp)
        {
            ID_pers = _ID_pers;
            nume = _nume;
            prenume = _prenume;
            categorie = _categorie;
            cnp = _cnp;
        }

    }
    public class Card : Persoana
    {
        public int ID_card, durata_abon;
        public DateTime data_creare, data_inc, data_exp;
        public string locatie_creare, locatie_inc, tip_abon;
        public float pret;
        public Card()
        {
            data_creare = data_inc = data_exp = DateTime.Now;
            locatie_creare = locatie_inc = tip_abon = string.Empty;

        }
        public Card(int _id, string _nume, string _prenume, string _cnp, string _categorie, string _tip_abon, float _pret, DateTime _data_creare, DateTime _data_inc, DateTime _data_exp)
        {
            //#Date Persoana
            ID_card = _id;
            nume = _nume;
            prenume = _prenume;
            cnp = _cnp;
            categorie = _categorie;
            //#Date Card
            tip_abon = _tip_abon;
            pret = _pret;
            data_creare = _data_creare;
            data_inc = _data_inc;
            data_exp = _data_exp;
        }
    }
}
