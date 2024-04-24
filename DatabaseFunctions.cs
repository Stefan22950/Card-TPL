using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfataGrafica
{
    
    public class DatabaseFunctions
    {


        MySqlConnection cnn = new MySqlConnection("server="+ ConfigurationManager.AppSettings["ip"] + ";"+ System.Configuration.ConfigurationManager.ConnectionStrings["TPLDB"].ConnectionString);
        MySqlCommand command;
        MySqlDataAdapter da;
        DataSet ds;

        //"server=79.112.129.91;database=TPL;uid=TPLuser;pwd=TPL2023;"

        public DatabaseFunctions()
        {

        }

        public int GetLastPersID()
        {
            cnn.Open();
            string insertQuery1 = "SELECT ID_pers FROM Persoane ORDER BY ID_pers DESC LIMIT 1";
            command = new MySqlCommand(insertQuery1, cnn);
            var dr = command.ExecuteReader();
            int id_pers = 0;
            if (dr.HasRows)
            {
                dr.Read();
                id_pers = dr.GetInt32(0);
                id_pers++;
            }
            else { id_pers = 1; }
            dr.Close();
            cnn.Close();
            return id_pers;
        }

        public void InsertPers(Persoana p)
        {
            string insertQuery2 = "INSERT INTO Persoane(ID_pers,nume,prenume,categorie,cnp) VALUES('" + p.ID_pers + "','" + p.nume + "','" + p.prenume + "','" + p.categorie + "'," + p.cnp + ")";
            cnn.Open();
            command = new MySqlCommand(insertQuery2, cnn);
            command.ExecuteNonQuery();
            cnn.Close();
        }

        public int GetLastNrincarc(Card c)
        {
            cnn.Open();
            string insertQuery4 = "SELECT Nr_incar FROM Incarcari WHERE ID_asocC = " + c.ID_card + " ORDER BY Nr_incar DESC LIMIT 1";
            command = new MySqlCommand(insertQuery4, cnn);
            var dr2 = command.ExecuteReader();
            int nrinc = 0;
            if (dr2.HasRows)
            {
                dr2.Read();
                nrinc = dr2.GetInt32(0);
                nrinc++;
            }
            else { nrinc = 1; }
            dr2.Close();
            cnn.Close();
            return nrinc;
        }

        public void InsertIncarc(Card c,int nrinc)
        {
            var datai = c.data_inc.ToString("yyyy-MM-dd HH:mm:ss");
            string insertQuery5 = "INSERT INTO Incarcari(ID_asocC,Nr_incar,Categorie,Tip_abon,Data_reinc) VALUES ('" + c.ID_card + "','" + nrinc + "','" + c.categorie + "','" + c.tip_abon + "','" + datai + "')";
            cnn.Open();
            command = new MySqlCommand(insertQuery5, cnn);
            command.ExecuteNonQuery();
            cnn.Close();
        }

        public void InsertCard(Card c,Persoana p)
        {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";

            string pret1 = c.pret.ToString(nfi);
            var datac = c.data_creare.ToString("yyyy-MM-dd HH:mm:ss");
            var datai = c.data_inc.ToString("yyyy-MM-dd HH:mm:ss");
            var datae = c.data_exp.ToString("yyyy-MM-dd HH:mm:ss");

            string insertQuery3 = "INSERT INTO Carduri(ID_asoc,ID_card,Tip_abon,Pret,Data_creare,Data_inc,Data_exp) VALUES('" + p.ID_pers + "','" + c.ID_card + "','" + c.tip_abon + "','" + pret1 + "','" + datac + "','" + datai + "','" + datae + "')";
            cnn.Open();
            command = new MySqlCommand(insertQuery3, cnn);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Datele au fost introduse");
                }
                else
                {
                    MessageBox.Show("Datele nu au fost introduse");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cnn.Close();
        }

        public int CautareConflictCNPDB(string cnp)
        {
            cnn.Open();
            string insertQuery1 = "SELECT CNP FROM Persoane WHERE CNP = " + cnp + "";
            command = new MySqlCommand(insertQuery1, cnn);
            var dr = command.ExecuteReader();
            string cnp1;
            int ok = 0;
            while (dr.HasRows)
            {
                dr.Read();
                cnp1 = dr.GetString(0);
                if (cnp1 == cnp)
                {
                    ok = 1;
                    break;
                }
            }
            dr.Close();
            cnn.Close();
            return ok;
        }

        public int CautareConflictCardDB(string nrcard)
        {
            cnn.Open();
            string insertQuery1 = "SELECT ID_card FROM Carduri WHERE ID_card = " + nrcard + "";
            command = new MySqlCommand(insertQuery1, cnn);
            var dr = command.ExecuteReader();
            string card1;
            int ok = 0;
            while (dr.HasRows)
            {
                dr.Read();
                card1 = dr.GetString(0);
                if (card1 == nrcard.Substring(2))
                {
                    ok = 1;
                    break;
                }
            }
            dr.Close();
            cnn.Close();
            return ok;
        }

        public int GetPersIDByCNP(string cnp)
        {
            cnn.Open();
            string insertQuery1 = "SELECT ID_pers FROM Persoane WHERE CNP=" + cnp + "";
            command = new MySqlCommand(insertQuery1, cnn);
            var dr = command.ExecuteReader();
            int id_pers = 0;
            if (dr.HasRows)
            {
                dr.Read();
                id_pers = dr.GetInt32(0);

            }
            dr.Close();
            cnn.Close();
            return id_pers;
        }

        public void UpdateCategPers(Persoana p,string cnp)
        {
            string insertQuery2 = "UPDATE Persoane SET categorie= '" + p.categorie + "' WHERE CNP =" + cnp + "";
            cnn.Open();
            command = new MySqlCommand(insertQuery2, cnn);
            command.ExecuteNonQuery();
            cnn.Close();
        }

        public int GetNrIncarcByIDcard(Card c)
        {
            cnn.Open();
            string insertQuery4 = "SELECT Nr_incar FROM Incarcari WHERE ID_asocC = " + c.ID_card + " ORDER BY Nr_incar DESC LIMIT 1";
            command = new MySqlCommand(insertQuery4, cnn);
            var dr2 = command.ExecuteReader();
            int nrinc = 0;
            if (dr2.HasRows)
            {
                dr2.Read();
                nrinc = dr2.GetInt32(0);
                nrinc++;
            }
            else { nrinc = 1; }
            dr2.Close();
            cnn.Close();
            return nrinc;
        }

        public Card GetCardSters(Card c,Persoana p)
        {
            Card c1 = new Card();
            c1.ID_card = c.ID_card; c1.nume=c.nume; c1.prenume=c.prenume; c1.cnp = c.cnp; c1.pret=c.pret;c1.data_creare=c.data_creare; c1.data_inc=c.data_inc;
            cnn.Open();
            string insertQuery9 = "SELECT CategorieS,Tip_abonS,Data_expS FROM Carduri_sterse WHERE ID_asocS=" + p.ID_pers + "";
            command = new MySqlCommand(insertQuery9, cnn);
            var dr9 = command.ExecuteReader();
            if (dr9.HasRows)
            {
                dr9.Read();
                c1.categorie = dr9.GetString(0);
                c1.tip_abon = dr9.GetString(1);
                c1.data_exp = dr9.GetDateTime(2);               
            }
            dr9.Close();
            cnn.Close();
            return c1;
        }

    }
}
