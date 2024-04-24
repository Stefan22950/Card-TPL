using Google.Protobuf.WellKnownTypes;

using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InterfataGrafica
{
    public partial class AdaugaCard1 : Form
    {


        MySqlConnection cnn = new MySqlConnection("server=" + ConfigurationManager.AppSettings["ip"] + ";" + System.Configuration.ConfigurationManager.ConnectionStrings["TPLDB"].ConnectionString);
        MySqlCommand command;
        MySqlDataAdapter da;
        DataSet ds;
        DatabaseFunctions db;
        Persoana pers;
        Card card;

        public string fnrc { get; set; }
        public string tip;
        public string pret;
        public int id_pers = 0;

        public int ret = 0;

        public AdaugaCard1()
        {

            InitializeComponent();
            btACadauga.Enabled = false;           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdaugaCard1_Load(object sender, EventArgs e)
        {
            btACclientexis.Hide(); btACclientn.Hide();
            lblTitle.Hide();
            lblACnume.Hide(); txtACnume.Hide();
            lblACprenume.Hide(); txtACprenume.Hide();
            lblACcat.Hide(); txtACcat.Hide();
            lblACcnp.Hide(); txtACcnp.Hide();
            lblACtip.Hide(); txtACtip.Hide();
            lblACwarning.Hide(); 
            pictureBox1.Hide(); 
            btACadauga.Hide();
            panel1.Hide();     
            pictureBox2.Show();
            panelclientexistent.Hide();
            txtAC1cardnr.Focus(); txtAC1cardnr.Text = fnrc;
            
            
        }

        private void btACadauga_Click(object sender, EventArgs e)
        {
            string ID_card = txtAC1cardnr.Text.Substring(2);
            string nume = txtACnume.Text; nume = UppercaseFirst(nume);
            string prenume = txtACprenume.Text; prenume = UppercaseFirst(prenume);
            string categorie = txtACcat.Text.ToUpper();
            string tip_abon = txtACtip.Text.ToUpper();
            int durata_abon = 0;
            float pret = 0;
            if (tip_abon == "1 ZI")
            {
                durata_abon = 1;
                pret = 11;
            }
            else if (tip_abon == "15 ZILE")
            {
                durata_abon = 15;
                pret = 51;
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
                pret = 80;
            }
            else if (tip_abon == "LUNAR" && categorie == "NENOMINAL")
            {
                durata_abon = 30;
                pret = 125;
            }
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";

            string pret1=pret.ToString(nfi);

            DateTime DataCrearii = DateTime.Now; var datac = DataCrearii.ToString("yyyy-MM-dd HH:mm:ss");
            DateTime DataInc = DateTime.Now; var datai = DataInc.ToString("yyyy-MM-dd HH:mm:ss");
            DateTime DataExp = DateTime.Now; 
            if (durata_abon == 1)
                DataExp = DataExp.AddDays(1);
            else if (durata_abon == 15)
                DataExp = DataExp.AddDays(15);
            else if (durata_abon == 30)
                DataExp = DataExp.AddDays(30);
            var datae = DataExp.ToString("yyyy-MM-dd HH:mm:ss");

            db = new DatabaseFunctions();

            id_pers =db.GetLastPersID();
            pers = new Persoana(id_pers, nume, prenume, categorie, txtACcnp.Text);
            card = new Card(Int32.Parse(ID_card),nume,prenume, txtACcnp.Text,categorie,tip_abon,pret,DataCrearii,DataInc,DataExp);

            db.InsertPers(pers);
            int nrinc=db.GetLastNrincarc(card);
            db.InsertIncarc(card, nrinc);
            db.InsertCard(card, pers);

            this.Close();
        }

        static string UppercaseFirst(string s)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        private void txtACcnp_TextChanged(object sender, EventArgs e)
        {

            if (txtACcnp.Text.Length != 13)
            {
                txtACcnp.ForeColor = Color.Black;
                txtACcnp.BackColor = Color.Red;
                btACadauga.Enabled = false;
            }
            else if(txtACcnp.Text.All(char.IsNumber) == true)
            {
                txtACcnp.BackColor = Color.Green;
                txtACcnp.ForeColor = Color.White;
                
            }

            ValidateTextBoxes();
        }

        private void ValidateTextBoxes()
        {
            if (txtACnume.Text.Length != 0 && txtACprenume.Text.Length != 0 && txtACcat.Text.Length != 0 && txtACtip.Text.Length != 0  && (txtACcnp.Text.Length == 13 && txtACcnp.Text.All(char.IsNumber) == true))
            {
                btACadauga.Enabled = true;
            }
            else
            {
                btACadauga.Enabled = false;
            }


        }

        private void txtACnume_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void txtACprenume_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBoxes();
        }

        private void txtACcat_TextChanged(object sender, EventArgs e)
        {
            string categorie = txtACcat.Text.ToUpper();
            string tip_abon = txtACtip.Text.ToUpper();
            float pret = 0;
            if (tip_abon == "1 ZI")
            {
                pret = 11;
            }
            else if (tip_abon == "15 ZILE")
            {
                pret = 51;
            }
            else if (tip_abon == "LUNAR" && categorie == "ELEV")
            {
                pret = 0;
            }
            else if (tip_abon == "LUNAR" && (categorie == "PENSIONAR" || categorie == "STUDENT"))
            {
                pret = 37.5F;
            }
            else if (tip_abon == "LUNAR" && categorie == "NOMINAL")
            {
                pret = 80;
            }
            else if (tip_abon == "LUNAR" && categorie == "NENOMINAL")
            {
                pret = 125;
            }


            lblACpret2.Text = pret.ToString() + " RON";

            ValidateTextBoxes();
        }

        private void txtACtip_TextChanged(object sender, EventArgs e)
        {
            string categorie = txtACcat.Text.ToUpper();
            string tip_abon = txtACtip.Text.ToUpper();
            float pret = 0;
            if (tip_abon == "1 ZI")
            {
                pret = 11;
            }
            else if (tip_abon == "15 ZILE")
            {
                pret = 51;
            }
            else if (tip_abon == "LUNAR" && categorie == "ELEV")
            {
                pret = 0;
            }
            else if (tip_abon == "LUNAR" && (categorie == "PENSIONAR" || categorie == "STUDENT"))
            {
                pret = 37.5F;
            }
            else if (tip_abon == "LUNAR" && categorie == "NOMINAL")
            {
                pret = 80;
            }
            else if (tip_abon == "LUNAR" && categorie == "NENOMINAL")
            {
                pret = 125;
            }


            lblACpret2.Text = pret.ToString() + " RON";

            ValidateTextBoxes();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtACcnp_Validating(object sender, CancelEventArgs e)
        {
            db=new DatabaseFunctions();
            if(txtACcnp.TextLength == 13)
            {
                if(db.CautareConflictCNPDB(txtACcnp.Text)==1)
                {
                    btACadauga.Enabled = false;
                    string message = "Conflict CNP! Reintroduceți CNP-ul clientului.";
                    var result = MessageBox.Show(message,"Eroare",MessageBoxButtons.OK,MessageBoxIcon.Error);

                    if(result == DialogResult.OK)
                    {
                        txtACcnp.Clear();
                    }

                }
            }
            ValidateTextBoxes() ;
        }

        private void txtAC1cardnr_TextChanged(object sender, EventArgs e)
        {db=new DatabaseFunctions();
            if (txtAC1cardnr.Text.Length == 10)
            {
                if (txtAC1cardnr.Text.Substring(0, 3) == "001")
                {
                    if (db.CautareConflictCardDB(txtAC1cardnr.Text) == 0)
                    {
                        txtAC1cardnr.Hide();
                        lblAC1info.Hide();
                        pictureBox2.Hide();
                        btACclientexis.Show();
                        btACclientn.Show();

                    }
                    else
                    {
                        
                        if(DialogResult.OK == MessageBox.Show("Conflict Card! Utilizați un card nou.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error))
                        {
                            MessageBox.Show("Conflict Card! Utilizați un card nou.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        txtAC1cardnr.Clear();

                    }

                }
            }
            
        }

        private void txtAC1cardnr_Validating(object sender, CancelEventArgs e)
        {db=new DatabaseFunctions();
            if (txtAC1cardnr.TextLength == 10)
            {
                if (db.CautareConflictCardDB(txtAC1cardnr.Text) == 1)
                {
                    this.Close();
                    ret = 1;

                    string message = "Conflict Card! Utilizați un card nou.";
                    var result = MessageBox.Show(message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                        MessageBox.Show(message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void txtAC1cardnr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void btACclientn_Click(object sender, EventArgs e)
        {
            btACclientexis.Hide(); btACclientn.Hide();
            txtAC1cardnr.Hide();
            lblTitle.Show();
            lblACnume.Show(); txtACnume.Show();
            lblACprenume.Show(); txtACprenume.Show();
            lblACcat.Show(); txtACcat.Show();
            lblACcnp.Show(); txtACcnp.Show();
            lblACtip.Show(); txtACtip.Show();
            lblACwarning.Show();
            pictureBox1.Show();
            btACadauga.Show();
            panel1.Show();
            lblAC1info.Hide();
            pictureBox2.Hide();
            lblTitle.Text = lblTitle.Text + txtAC1cardnr.Text;
            lblp3pret2.Text = "-";
        }

        private void btACclientexis_Click(object sender, EventArgs e)
        {
            Bind_data();
            txtAC1cardnr.Hide();
            lblTitle.Show();
            panelclientexistent.Show();
            lblp3nume2.Text = lblp3prenume2.Text = lblp3CNP2.Text = lblp3pret2.Text = "-";
            lblTitle.Text = lblTitle.Text + txtAC1cardnr.Text;
        }

        private void txtp3tip_TextChanged(object sender, EventArgs e)
        {
            
            lblp3pret2.Text = 5.ToString() + " RON";

            ValidateTextBoxes();
        }

        private void btp3adauga_Click(object sender, EventArgs e)
        {
            string ID_card = txtAC1cardnr.Text.Substring(2);
            string nume = lblp3nume2.Text; nume = UppercaseFirst(nume);
            string prenume = lblp3prenume2.Text; prenume = UppercaseFirst(prenume);
            string categorie = txtp3cat.Text.ToUpper();
            string tip_abon = txtp3tip.Text.ToUpper();
            
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";

            string pret1 = 5.ToString(nfi);
            pret = pret1;

            DateTime DataCrearii = DateTime.Now; var datac = DataCrearii.ToString("yyyy-MM-dd HH:mm:ss");
            DateTime DataInc = DateTime.Now; var datai = DataInc.ToString("yyyy-MM-dd HH:mm:ss");
            DateTime DataExp = DateTime.Now;
            var datae = DataExp.ToString("yyyy-MM-dd HH:mm:ss");
            db=new DatabaseFunctions();

            id_pers = db.GetPersIDByCNP(lblp3CNP2.Text);
            pers = new Persoana(id_pers,nume,prenume,categorie, lblp3CNP2.Text);
            card = new Card(Int32.Parse(ID_card),nume,prenume, lblp3CNP2.Text,categorie,tip_abon,5,DataCrearii,DataInc,DataExp);
            
            db.UpdateCategPers(pers, lblp3CNP2.Text);
            int nrinc=db.GetNrIncarcByIDcard(card);
            card = db.GetCardSters(card, pers);
            db.InsertIncarc(card, nrinc);
            db.InsertCard(card, pers);
            
            this.Close();
        }

        private void Bind_data()
        {
            cnn.Open();
            string insertQuery8 = "SELECT Nr_incar FROM Incarcari WHERE ID_asocC = " + txtAC1cardnr.Text.Substring(2) + " ORDER BY Nr_incar DESC LIMIT 1";
            command = new MySqlCommand(insertQuery8, cnn);
            var dr4 = command.ExecuteReader();
            int nrinc = 0;
            if (dr4.HasRows)
            {
                dr4.Read();
                nrinc = dr4.GetInt32(0);
                nrinc++;
            }
            else { nrinc = 1; }
            dr4.Close();
            cnn.Close();


            string insertQuery7 = "SELECT Nume,Prenume,CNP,Categorie,ID_pers FROM Persoane WHERE NOT EXISTS(SELECT ID_card FROM Carduri WHERE ID_asoc=ID_pers);";
            cnn.Open();
            command = new MySqlCommand(insertQuery7, cnn);
            command.ExecuteNonQuery();
            da = new MySqlDataAdapter(command);
            ds = new DataSet();
            da.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {

                txtpersoane.Items.Add(ds.Tables[0].Rows[i][0] + " ;" + ds.Tables[0].Rows[i][1] + " ;" + ds.Tables[0].Rows[i][2] + " ;"+ ds.Tables[0].Rows[i][3] + " ;" + ds.Tables[0].Rows[i][4]);
                
            }

            cnn.Close();
        }
        public int CountCharsUsingLinqCount(string source, char toFind)
        {
            return source.Count(t => t == toFind);
        }

        private void txtpersoane_TextChanged(object sender, EventArgs e)
        {
            lblp3nume2.Text = lblp3prenume2.Text = lblp3CNP2.Text = lblp3pret2.Text = "-";

            if (CountCharsUsingLinqCount(txtpersoane.Text, ';')==4)
            {
                string[] splits = txtpersoane.Text.Split(';');
                lblp3nume2.Text = splits[0];
                lblp3prenume2.Text = splits[1];
                lblp3CNP2.Text = splits[2];
                txtp3cat.Text = splits[3];
                id_pers = Int32.Parse(splits[4]);

                cnn.Open();
                string insertQuery9 = "SELECT Tip_abonS FROM Carduri_sterse WHERE ID_asocS=" + id_pers + "";
                command = new MySqlCommand(insertQuery9, cnn);
                var dr9 = command.ExecuteReader();
                if (dr9.HasRows)
                {
                    dr9.Read();
                    tip = dr9.GetString(0);

                }
                txtp3tip.Text = tip;
                lblp3pret2.Text = 5.ToString() + " RON";
                dr9.Close();
                cnn.Close();

            }
            
        }
    }
}
