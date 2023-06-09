using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InterfataGrafica
{

    public partial class Main : Form
    {
        //AdministrareCarduri_FisierText adminCarduri;

        //List<Persoana> Persoane = new List<Persoana>();
        
        MySqlDataAdapter adpt;
        DataTable dt;


        public Main()
        {
            /*string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            adminCarduri = new AdministrareCarduri_FisierText(caleCompletaFisier);*/

            this.Size = new Size(600, 400);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(600, 400);
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.Text = "Genstionare Carduri";

            

            InitializeComponent();
            //AfisareTabel();
            AfisareTabDB();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btAdaugaCard_Click(object sender, EventArgs e)
        {
            AdaugaCard1 form = new AdaugaCard1();
            form.ShowDialog();
            AfisareTabDB();
            
        }
        
        /*private void AfisareTabel()
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;

            string[] lines = File.ReadAllLines(caleCompletaFisier);
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(';');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                dataGridView1.Rows.Add(row);
            }
        }*/

        private void AfisareTabDB()
        {
            adpt = new MySqlDataAdapter("SELECT ID_card, Nume, Prenume, CNP, Categorie, Tip_abon, Pret, Data_creare, Data_inc, Data_exp\r\n FROM Persoane, Carduri\r\n WHERE ID_pers= ID_asoc ORDER BY Nume,Prenume;", cnn);
            dt= new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btAdaugaCard_MouseEnter(object sender, EventArgs e)
        {
            btAdaugaCard.BackColor = Color.GreenYellow;
        }

        private void btAdaugaCard_MouseLeave(object sender, EventArgs e)
        {
            btAdaugaCard.BackColor = Color.Transparent;
        }

        private void btEditCard_MouseEnter(object sender, EventArgs e)
        {
            btEditCard.BackColor = Color.DarkOrange;
        }

        private void btEditCard_MouseLeave(object sender, EventArgs e)
        {
            btEditCard.BackColor = Color.Transparent;
        }

        private void btStergeCard_MouseEnter(object sender, EventArgs e)
        {
            btStergeCard.BackColor = Color.Red;
        }

        private void btStergeCard_MouseLeave(object sender, EventArgs e)
        {
            btStergeCard.BackColor = Color.Transparent;
        }

        private void btEditCard_Click(object sender, EventArgs e)
        {
            IncarcaCard form = new IncarcaCard();            
            form.ShowDialog();
            AfisareTabDB();
        }

        private void btStergeCard_Click(object sender, EventArgs e)
        {
            Sterge form = new Sterge();
            form.ShowDialog();
            AfisareTabDB();
        }

        private void btinfo_Click(object sender, EventArgs e)
        {
            Info form = new Info();
            form.ShowDialog();
            AfisareTabDB();
        }

        private void btDelog_Click(object sender, EventArgs e)
        {
            var result= MessageBox.Show("Doriți să vă delogați?","Atentie",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Login form = new Login();
                form.ShowDialog();
            }
        }

        private void btinfo_MouseEnter(object sender, EventArgs e)
        {
            btinfo.BackColor = Color.DeepSkyBlue;
        }

        private void btinfo_MouseLeave(object sender, EventArgs e)
        {
            btinfo.BackColor = Color.Transparent;
        }

    }
}
