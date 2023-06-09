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

using static System.Net.Mime.MediaTypeNames;

namespace InterfataGrafica
{
    public partial class Sterge : Form
    {
        MySqlConnection cnn = new MySqlConnection("server=79.112.132.123;database=TPL;uid=TPLuser;pwd=TPL2023;");
        MySqlCommand command;
        public int id_pers;
        public string datac; public string datai; public string datae;


        public string fCNP { get; set; }
        public Sterge()
        {
            InitializeComponent();
            btSsterge.Enabled = false;
        }

        private void Sterge_Load(object sender, EventArgs e)
        {
            lblSnume2.Text = lblSprenume2.Text = lblSnrCard2.Text = lblScat2.Text = lblStip2.Text = lblSdatai2.Text = lblSdatae2.Text = "-";
            txtScnp.Focus();
            txtScnp.Text = fCNP;
            
        }

        private int CautareConflictCNPDB()
        {
            cnn.Open();
            string insertQuery1 = "SELECT * FROM Persoane WHERE CNP = " + txtScnp.Text + "";
            command = new MySqlCommand(insertQuery1, cnn);
            var dr = command.ExecuteReader();
            string nume, prenume, cnp, categorie;
            int ok = 0;
            while (dr.HasRows)
            {
                dr.Read();
                id_pers= dr.GetInt32(0);
                nume= dr.GetString(1);
                prenume= dr.GetString(2);
                cnp = dr.GetString(3);
                categorie = dr.GetString(4);
                if (cnp == txtScnp.Text)
                {
                    ok = 1;
                    lblSnume2.Text = nume;
                    lblSprenume2.Text = prenume;
                    lblScat2.Text = categorie;
                    break;
                }
                
            }
            dr.Close();
            cnn.Close();
            return ok;
        }


        private void ValidateTextBoxes()
        {
            if (txtScnp.Text.Length== 13)
            {
                btSsterge.Enabled = true;
            }
            else
            {
                btSsterge.Enabled = false;
            }


        }

        private void txtScnp_TextChanged(object sender, EventArgs e)
        {
            

            int ok = 0;
            if (txtScnp.Text.Length != 13)
            {
                txtScnp.BackColor = Color.Red;
                btSsterge.Enabled = false;
                lblSnume2.Text = lblSprenume2.Text = lblSnrCard2.Text = lblScat2.Text = lblStip2.Text = lblSdatai2.Text = lblSdatae2.Text = "-";
            }
            else if (txtScnp.Text.All(char.IsNumber) == true)
            {
                txtScnp.BackColor = Color.Green;
                txtScnp.ForeColor = Color.White;
                ok = 1;

            }

            if (ok == 1)
            {
                if (CautareConflictCNPDB() == 1)
                {
                    cnn.Open();
                    string insertQuery2 = "SELECT ID_card,Tip_abon,Data_creare,Data_inc,Data_exp FROM Carduri WHERE ID_asoc =" + id_pers + "";
                    command = new MySqlCommand(insertQuery2, cnn);
                    var dr = command.ExecuteReader();
                    string tip;
                    
                    int nrc = 0;
                    if (dr.HasRows)
                    {
                        dr.Read();
                        nrc = dr.GetInt32(0);
                        tip = dr.GetString(1);
                        datac = dr.GetDateTime(2).ToString("yyyy-MM-dd HH:mm:ss");
                        datai = dr.GetDateTime(3).ToString("yyyy-MM-dd HH:mm:ss");
                        datae = dr.GetDateTime(4).ToString("yyyy-MM-dd HH:mm:ss");



                        lblSnrCard2.Text = "00" + nrc.ToString();
                        lblStip2.Text = tip;
                        lblSdatai2.Text = datai;
                        lblSdatae2.Text = datae;
                    }
                    dr.Close();
                    cnn.Close();

                }

                ValidateTextBoxes();
            }


        }

        private void btSsterge_Click(object sender, EventArgs e)
        {




            var result = MessageBox.Show("Sunteți sigur/ă că doriți să ștergeți cardul? ", "Atenționare!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) {
                string insertQuery5 = "INSERT INTO Carduri_sterse(ID_asocS,CategorieS,Tip_abonS,Data_creariiS,Data_incS,Data_expS) VALUES ('" + id_pers + "','" + lblScat2.Text + "','" + lblStip2.Text + "','" + datac + "','" + datai + "','" + datae + "')";
                cnn.Open();
                command = new MySqlCommand(insertQuery5, cnn);
                command.ExecuteNonQuery();
                cnn.Close();

                string insertQuery3 = "DELETE FROM Carduri WHERE ID_asoc=" + id_pers + "";
                cnn.Open();
                command = new MySqlCommand(insertQuery3, cnn);
                command.ExecuteNonQuery();
                cnn.Close();

                string insertQuery4 = "DELETE FROM Incarcari WHERE ID_asocC=" + lblSnrCard2.Text.Substring(2) + "";
                cnn.Open();
                command = new MySqlCommand(insertQuery4, cnn);
                command.ExecuteNonQuery();
                cnn.Close();
            }
            this.Close();
        }
    }
}
