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
    public partial class Login : Form
    {
        
        MySqlCommand command;

        public int id;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(150, 45, 162, 67);
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TopMost = true;

           //FormBorderStyle = FormBorderStyle.None;

            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnn.Open();
            string insertQuery1 = "SELECT * FROM Angajati WHERE ID_angajat=" + txtLID.Text + "";
            command = new MySqlCommand(insertQuery1, cnn);
            var dr = command.ExecuteReader();
            int ok = 0;
            if (dr.HasRows)
            {
                dr.Read();// Get first record.
                id = dr.GetInt32(0);// Get value of first column as string.
                ok = 1;
            }
            dr.Close();
            cnn.Close();
            if(ok == 1) 
            {
                txtLID.Clear();
                this.Hide();
                Main form = new Main();
                form.ShowDialog();
            }
            else
            {
                txtLID.Clear();
                MessageBox.Show("ID inexistent/gresit! Încercați din nou!","Eroare",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtLID.Focus();
            }


        }
    }
}
