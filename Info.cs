using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfataGrafica
{
    public partial class Info : Form
    {
        MySqlConnection cnn = new MySqlConnection("server=79.112.132.123;database=TPL;uid=TPLuser;pwd=TPL2023;");
        MySqlCommand command;
        public int id_pers;
        public string txtcard;
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            lblInrcard2.Text = lblInume2.Text = lblIprenume2.Text = lblICNP2.Text = lblIcat2.Text = lblInrtotinc2.Text = lblIdatac2.Text = lblItip2.Text = lblIdatai2.Text = lblIdatae2.Text = "-";
            txtIcard.Focus();
        }

        private void Completarelabel()
        {
            cnn.Open();
            string insertQuery1 = "SELECT ID_asoc,ID_card,Tip_abon,Data_inc,Data_exp,Data_creare FROM Carduri WHERE ID_card = " + txtIcard.Text.Substring(2) + "";
            command = new MySqlCommand(insertQuery1, cnn);
            var dr = command.ExecuteReader();
            string tip,datac,datai,datae,nrc;
            while (dr.HasRows)
            {
                dr.Read();
                id_pers = dr.GetInt32(0);
                nrc= dr.GetInt32(1).ToString();
                tip = dr.GetString(2);
                datai = dr.GetDateTime(3).ToString("dd/MM/yyyy HH:mm");
                datae = dr.GetDateTime(4).ToString("dd/MM/yyyy HH:mm");
                datac = dr.GetDateTime(5).ToString("dd/MM/yyyy HH:mm");

                if ( nrc == txtIcard.Text.Substring(2))
                {
                    lblInrcard2.Text ="00" + nrc;
                    lblItip2.Text = tip;
                    lblIdatai2.Text = datai;
                    lblIdatae2.Text = datae;
                    lblIdatac2.Text = datac;
                    break;
                }

            }
            
            dr.Close();
            cnn.Close();

            cnn.Open();
            string insertQuery2 = "SELECT Nume,Prenume,CNP,Categorie FROM Persoane WHERE ID_pers=" + id_pers +"";
            command = new MySqlCommand(insertQuery2, cnn);
            var dr2 = command.ExecuteReader();
            string nume,prenume,cnp,categorie;
            while (dr2.HasRows)
            {
                dr2.Read();
                nume = dr2.GetString(0);
                prenume = dr2.GetString(1);
                cnp = dr2.GetString(2);
                categorie = dr2.GetString(3);
                
                lblInume2.Text = nume;
                lblIprenume2.Text = prenume;
                lblICNP2.Text = cnp;
                lblIcat2.Text = categorie;
                break;

            }
            dr2.Close();
            cnn.Close();

            cnn.Open();
            string insertQuery3 = "SELECT Nr_incar FROM Incarcari WHERE ID_asocC =" + txtIcard.Text.Substring(2) + "";
            command = new MySqlCommand(insertQuery3, cnn);
            var dr3 = command.ExecuteReader();
            string nrinc;
            while (dr3.HasRows)
            {
                dr3.Read();
                nrinc = dr3.GetInt32(0).ToString();
                lblInrtotinc2.Text = nrinc;
                break;

            }
            dr3.Close();
            cnn.Close();


        }

        private int CardNouValid()
        {
            cnn.Open();
            string insertQuery6 = "SELECT ID_asoc,ID_card,Tip_abon,Data_inc,Data_exp,Data_creare FROM Carduri WHERE ID_card = " + txtIcard.Text.Substring(2) + "";
            command = new MySqlCommand(insertQuery6, cnn);
            var dr6 = command.ExecuteReader();
            string tip, datac, datai, datae, nrc;
            int ok = 0;
            while (dr6.HasRows)
            {
                dr6.Read();
                id_pers = dr6.GetInt32(0);
                nrc = dr6.GetInt32(1).ToString();
                tip = dr6.GetString(2);
                datai = dr6.GetDateTime(3).ToString("dd/MM/yyyy HH:mm");
                datae = dr6.GetDateTime(4).ToString("dd/MM/yyyy HH:mm");
                datac = dr6.GetDateTime(5).ToString("dd/MM/yyyy HH:mm");

                if (nrc == txtIcard.Text.Substring(2))
                {
                    ok = 1;
                    lblInrcard2.Text ="00"+ nrc;
                    lblItip2.Text = tip;
                    lblIdatai2.Text = datai;
                    lblIdatae2.Text = datae;
                    lblIdatac2.Text = datac;
                    break;
                }

            }
            dr6.Close();
            cnn.Close();
            return ok; 
        }

        private void txtIcard_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txtIcard_TextChanged(object sender, EventArgs e)
        {
            if (txtIcard.Text.Length == 10)
            {
                
                Completarelabel();
                if(CardNouValid()==0)
                {
                    lblInrcard2.Text = "Card nou!";
                    lblInume2.Text = lblIprenume2.Text = lblICNP2.Text = lblIcat2.Text = lblInrtotinc2.Text = lblIdatac2.Text = lblItip2.Text = lblIdatai2.Text = lblIdatae2.Text = "-";
                }
                txtcard = txtIcard.Text;
                txtIcard.Clear();
                txtIcard.Focus();
            }
        }

       

        private void btSsterge_Click(object sender, EventArgs e)
        {

            Sterge form= new Sterge();
            form.fCNP = lblICNP2.Text;
            this.Hide();
            this.Close();
            form.ShowDialog();
        }

        private void btICincarca_Click(object sender, EventArgs e)
        {
            IncarcaCard form= new IncarcaCard();
            form.fnr = txtcard;
            this.Hide(); this.Close();
            form.ShowDialog();
        }

        private void btACadauga_Click(object sender, EventArgs e)
        {
            AdaugaCard1 form= new AdaugaCard1();
            form.fnrc = txtcard;
            this.Hide(); this.Close();
            form.ShowDialog();
        }
    }
}
