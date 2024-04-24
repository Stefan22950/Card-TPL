using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfataGrafica
{
    public partial class IncarcaCard : Form
    {
        MySqlConnection cnn = new MySqlConnection("server=" + ConfigurationManager.AppSettings["ip"] + ";" + System.Configuration.ConfigurationManager.ConnectionStrings["TPLDB"].ConnectionString);
        MySqlCommand command;

        public string fnr {  get; set; }

        public IncarcaCard()
        {
            InitializeComponent();
            btICincarca.Enabled = false;
        }

        private void IncarcaCard_Load(object sender, EventArgs e)
        {
            lblTitle.Hide();
            lblICtip.Hide();
            lblICcat.Hide();
            lblICexpira.Hide(); 
            lblICexpira2.Hide();
            lblICincepe.Hide(); 
            txtICcat.Hide();
            txtICtip.Hide();
            dateTimePicker1.Hide();
            btICincarca.Hide();
            lblICpret1.Hide(); lblICpret2.Hide();
            txtICcardnr.Focus(); txtICcardnr.Text = fnr;

        }

        private int CautareConflictCardDB()
        {
            cnn.Open();
            string insertQuery1 = "SELECT ID_card FROM Carduri WHERE ID_card = " + txtICcardnr.Text + "";
            command = new MySqlCommand(insertQuery1, cnn);
            var dr = command.ExecuteReader();
            string card1;
            int ok = 0;
            while (dr.HasRows)
            {
                dr.Read();// Get first record.
                card1 = dr.GetString(0);// Get value of first column as string.
                if (card1 == txtICcardnr.Text.Substring(2))
                {
                    ok = 1;
                    break;
                }
            }
            dr.Close();
            cnn.Close();
            return ok;

        }

        private void txtICcardnr_TextChanged(object sender, EventArgs e)
        {
            if (txtICcardnr.Text.Length == 10)
            {
                if (txtICcardnr.Text.Substring(0, 3) == "001")
                {
                    if (CautareConflictCardDB() == 1)
                    {
                        txtICcardnr.Hide();
                        lblIC1info.Hide();
                        pictureBox2.Hide();
                        lblTitle.Show();
                        lblICcat.Show(); txtICcat.Show();
                        lblICtip.Show(); txtICtip.Show();
                        dateTimePicker1.Show();
                        lblICincepe.Show();
                        lblICexpira.Show(); lblICexpira2.Show();
                        btICincarca.Show();
                        lblICpret1.Show(); lblICpret2.Show();
                        lblTitle.Text = lblTitle.Text + txtICcardnr.Text;

                        cnn.Open();
                        string insertQuery1 = "SELECT Data_exp FROM Carduri WHERE ID_card = " + txtICcardnr.Text.Substring(2) + "";
                        command = new MySqlCommand(insertQuery1, cnn);
                        var dr = command.ExecuteReader();
                        DateTime datae1;
                        if (dr.HasRows)
                        {
                            dr.Read();// Get first record.
                            datae1 = dr.GetDateTime(0);// Get value of first column as string.
                            dateTimePicker1.Value = datae1.AddDays(1);
                        }
                        dr.Close();
                        cnn.Close();
                      
                    }
                    else
                    {

                        if (DialogResult.OK == MessageBox.Show("Card inexistent! Doriți să adăugați cardul în sistem?", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error))
                        {
                            Thread.Sleep(100);
                            var result = MessageBox.Show("Card inexistent! Doriți să adăugați cardul în sistem?", "Eroare", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                            if (result == DialogResult.Yes) 
                            {
                                this.Hide();
                                this.Close();
                                AdaugaCard1 form = new AdaugaCard1();
                                form.ShowDialog();
                            } else 
                            {
                                txtICcardnr.Clear();
                            }

                        }
                        txtICcardnr.Clear();

                    }

                }
            }
        }

        private void btICincarca_Click(object sender, EventArgs e)
        {
            string categorie = txtICcat.Text.ToUpper();
            string tip_abon = txtICtip.Text.ToUpper();
            int durata_abon = 0;
            float pret = 0;
            if (tip_abon == "1 ZI")
            {
                durata_abon = 1;
                pret = 6;
            }
            else if (tip_abon == "15 ZILE")
            {
                durata_abon = 15;
                pret = 46;
            }
            else if (tip_abon == "LUNAR" && categorie == "ELEV")
            {
                durata_abon = 30;
                pret = 0;
            }
            else if (tip_abon == "LUNAR" && (categorie == "PENSIONAR" || categorie == "STUDENT"))
            {
                durata_abon = 30;
                pret = 37.5F;
            }
            else if (tip_abon == "LUNAR" && categorie == "NOMINAL")
            {
                durata_abon = 30;
                pret = 75;
            }
            else if (tip_abon == "LUNAR" && categorie == "NENOMINAL")
            {
                durata_abon = 30;
                pret = 120;
            }
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";

            string pret1 = pret.ToString(nfi);

            var datai = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss"); 
            DateTime DataExp = dateTimePicker1.Value;
            if (durata_abon == 1)
                DataExp = DataExp.AddDays(1);
            else if (durata_abon == 15)
                DataExp = DataExp.AddDays(15);
            else if (durata_abon == 30)
                DataExp = DataExp.AddDays(30);
            var datae = DataExp.ToString("yyyy-MM-dd HH:mm:ss");

            cnn.Open();
            string insertQuery1 = "SELECT Nr_incar FROM Incarcari WHERE ID_asocC = " + txtICcardnr.Text.Substring(2) + " ORDER BY Nr_incar DESC LIMIT 1";
            command = new MySqlCommand(insertQuery1, cnn);
            var dr = command.ExecuteReader();
            int nrinc = 0;
            if (dr.HasRows)
            {
                dr.Read();// Get first record.
                nrinc = dr.GetInt32(0);// Get value of first column as string.
                nrinc++;
            }
            else { nrinc = 1; }
            dr.Close();
            cnn.Close();
            
            string insertQuery2 = "INSERT INTO Incarcari(ID_asocC,Nr_incar,Categorie,Tip_abon,Data_reinc) VALUES ('" + txtICcardnr.Text + "','" + nrinc + "','" + categorie + "','" + tip_abon + "','" + datai + "')";
            cnn.Open();
            command = new MySqlCommand(insertQuery2, cnn);
            command.ExecuteNonQuery();
            cnn.Close();
            string insertQuery3 = "UPDATE Carduri SET Tip_abon ='" + tip_abon +"',Pret='" + pret1 + "',Data_inc='" + datai + "',Data_exp='"+ datae +"' WHERE ID_card = "+ txtICcardnr.Text.Substring(2) +";";
            cnn.Open();
            command = new MySqlCommand(insertQuery3, cnn);
            command.ExecuteNonQuery();
            cnn.Close();
            string insertQuery4 = "SELECT ID_asoc FROM Carduri WHERE ID_card ="+ txtICcardnr.Text.Substring(2) + ";";
            cnn.Open();
            command = new MySqlCommand(insertQuery4, cnn);
            var dr1 = command.ExecuteReader();
            int id_pers = 0;
            if (dr1.HasRows)
            {
                dr1.Read();// Get first record.
                id_pers = dr1.GetInt32(0);// Get value of first column as string.
            }
            dr1.Close();
            cnn.Close();

            string insertQuery5 = "UPDATE Persoane SET Categorie='" + categorie + "'WHERE ID_pers =" + id_pers + ";";
            cnn.Open();
            command = new MySqlCommand(insertQuery5, cnn);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Datele au fost actualizate");
                }
                else
                {
                    MessageBox.Show("Datele nu au fost actualizate");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cnn.Close();

            lblICexpira2.Text = datae;

            this.Close();


        }
        private void ValidateTextBoxes()
        {
            if (txtICcat.Text.Length != 0 && txtICtip.Text.Length !=0)
            {
                btICincarca.Enabled = true;
            }
            else
            {
                btICincarca.Enabled = false;
            }


        }

        private void txtICcat_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void txtICtip_TextChanged(object sender, EventArgs e)
        {

            string categorie = txtICcat.Text.ToUpper();
            string tip_abon = txtICtip.Text.ToUpper();
            int durata_abon = 0;
            float pret = 0;
            if (tip_abon == "1 ZI")
            {
                durata_abon = 1;
                pret = 6;
            }
            else if (tip_abon == "15 ZILE")
            {
                durata_abon = 15;
                pret = 46;
            }
            else if (tip_abon == "LUNAR" && categorie == "ELEV")
            {
                durata_abon = 30;
                pret = 0;
            }
            else if (tip_abon == "LUNAR" && (categorie == "PENSIONAR" || categorie == "STUDENT"))
            {
                durata_abon = 30;
                pret = 37.5F;
            }
            else if (tip_abon == "LUNAR" && categorie == "NOMINAL")
            {
                durata_abon = 30;
                pret = 75;
            }
            else if (tip_abon == "LUNAR" && categorie == "NENOMINAL")
            {
                durata_abon = 30;
                pret = 120;
            }
            
            lblICexpira2.Text = dateTimePicker1.Value.AddDays(durata_abon).ToString("dd/MM/yyyy HH:mm");
            lblICpret2.Text = pret.ToString() + " RON";

            ValidateTextBoxes();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string categorie = txtICcat.Text.ToUpper();
            string tip_abon = txtICtip.Text.ToUpper();
            int durata_abon = 0;
            if (tip_abon == "1 ZI")
            {
                durata_abon = 1;
            }
            else if (tip_abon == "15 ZILE")
            {
                durata_abon = 15;

            }
            else if (tip_abon == "LUNAR" && categorie == "ELEV")
            {
                durata_abon = 30;
            }
            else if (tip_abon == "LUNAR" && (categorie == "PENSIONAR" || categorie == "STUDENT"))
            {
                durata_abon = 30;
                
            }
            else if (tip_abon == "LUNAR" && categorie == "NOMINAL")
            {
                durata_abon = 30;
                
            }
            else if (tip_abon == "LUNAR" && categorie == "NENOMINAL")
            {
                durata_abon = 30;
                
            }

            lblICexpira2.Text = dateTimePicker1.Value.AddDays(durata_abon).ToString("dd/MM/yyyy HH:mm");
        }
    }
}
