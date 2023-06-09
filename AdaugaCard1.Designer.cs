using System.Windows.Forms;

namespace InterfataGrafica
{
    partial class AdaugaCard1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblACnume = new System.Windows.Forms.Label();
            this.lblACprenume = new System.Windows.Forms.Label();
            this.lblACcnp = new System.Windows.Forms.Label();
            this.lblACcat = new System.Windows.Forms.Label();
            this.lblACtip = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtACtip = new System.Windows.Forms.ComboBox();
            this.txtACcat = new System.Windows.Forms.ComboBox();
            this.txtACcnp = new System.Windows.Forms.TextBox();
            this.txtACprenume = new System.Windows.Forms.TextBox();
            this.txtACnume = new System.Windows.Forms.TextBox();
            this.btACadauga = new System.Windows.Forms.Button();
            this.lblACwarning = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAC1cardnr = new System.Windows.Forms.TextBox();
            this.lblAC1info = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btACclientn = new System.Windows.Forms.Button();
            this.btACclientexis = new System.Windows.Forms.Button();
            this.panelclientexistent = new System.Windows.Forms.Panel();
            this.lblPersoane = new System.Windows.Forms.Label();
            this.txtpersoane = new System.Windows.Forms.ComboBox();
            this.lblp3nume = new System.Windows.Forms.Label();
            this.lblp3nume2 = new System.Windows.Forms.Label();
            this.lblp3prenume = new System.Windows.Forms.Label();
            this.lblp3prenume2 = new System.Windows.Forms.Label();
            this.lblp3cnp = new System.Windows.Forms.Label();
            this.lblp3CNP2 = new System.Windows.Forms.Label();
            this.lblp3cat = new System.Windows.Forms.Label();
            this.lblp3tip = new System.Windows.Forms.Label();
            this.lblp3pret = new System.Windows.Forms.Label();
            this.lblp3pret2 = new System.Windows.Forms.Label();
            this.lblACpret = new System.Windows.Forms.Label();
            this.lblACpret2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btp3adauga = new System.Windows.Forms.Button();
            this.txtp3cat = new System.Windows.Forms.Label();
            this.txtp3tip = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelclientexistent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTitle.Location = new System.Drawing.Point(92, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(186, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Adaugă Cardul nr ";
            // 
            // lblACnume
            // 
            this.lblACnume.AutoSize = true;
            this.lblACnume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACnume.Location = new System.Drawing.Point(106, 1);
            this.lblACnume.Name = "lblACnume";
            this.lblACnume.Size = new System.Drawing.Size(74, 25);
            this.lblACnume.TabIndex = 1;
            this.lblACnume.Text = "Nume:";
            // 
            // lblACprenume
            // 
            this.lblACprenume.AutoSize = true;
            this.lblACprenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACprenume.Location = new System.Drawing.Point(76, 36);
            this.lblACprenume.Name = "lblACprenume";
            this.lblACprenume.Size = new System.Drawing.Size(104, 25);
            this.lblACprenume.TabIndex = 2;
            this.lblACprenume.Text = "Prenume:";
            // 
            // lblACcnp
            // 
            this.lblACcnp.AutoSize = true;
            this.lblACcnp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACcnp.Location = new System.Drawing.Point(118, 71);
            this.lblACcnp.Name = "lblACcnp";
            this.lblACcnp.Size = new System.Drawing.Size(62, 25);
            this.lblACcnp.TabIndex = 3;
            this.lblACcnp.Text = "CNP:";
            // 
            // lblACcat
            // 
            this.lblACcat.AutoSize = true;
            this.lblACcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACcat.Location = new System.Drawing.Point(69, 105);
            this.lblACcat.Name = "lblACcat";
            this.lblACcat.Size = new System.Drawing.Size(111, 25);
            this.lblACcat.TabIndex = 4;
            this.lblACcat.Text = "Categorie:";
            // 
            // lblACtip
            // 
            this.lblACtip.AutoSize = true;
            this.lblACtip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACtip.Location = new System.Drawing.Point(17, 139);
            this.lblACtip.Name = "lblACtip";
            this.lblACtip.Size = new System.Drawing.Size(163, 25);
            this.lblACtip.TabIndex = 5;
            this.lblACtip.Text = "Tip Abonament:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblACpret2);
            this.panel1.Controls.Add(this.txtACtip);
            this.panel1.Controls.Add(this.txtACcat);
            this.panel1.Controls.Add(this.txtACcnp);
            this.panel1.Controls.Add(this.txtACprenume);
            this.panel1.Controls.Add(this.txtACnume);
            this.panel1.Location = new System.Drawing.Point(189, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 204);
            this.panel1.TabIndex = 6;
            // 
            // txtACtip
            // 
            this.txtACtip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtACtip.FormattingEnabled = true;
            this.txtACtip.Items.AddRange(new object[] {
            "1 zi",
            "15 zile",
            "Lunar"});
            this.txtACtip.Location = new System.Drawing.Point(3, 141);
            this.txtACtip.Name = "txtACtip";
            this.txtACtip.Size = new System.Drawing.Size(255, 21);
            this.txtACtip.TabIndex = 12;
            this.txtACtip.TextChanged += new System.EventHandler(this.txtACtip_TextChanged);
            // 
            // txtACcat
            // 
            this.txtACcat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtACcat.FormattingEnabled = true;
            this.txtACcat.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtACcat.Items.AddRange(new object[] {
            "Nominal",
            "Pensionar",
            "Student",
            "Elev",
            "Nenominal"});
            this.txtACcat.Location = new System.Drawing.Point(3, 106);
            this.txtACcat.Name = "txtACcat";
            this.txtACcat.Size = new System.Drawing.Size(255, 21);
            this.txtACcat.TabIndex = 11;
            this.txtACcat.TextChanged += new System.EventHandler(this.txtACcat_TextChanged);
            // 
            // txtACcnp
            // 
            this.txtACcnp.Location = new System.Drawing.Point(3, 74);
            this.txtACcnp.Name = "txtACcnp";
            this.txtACcnp.Size = new System.Drawing.Size(255, 20);
            this.txtACcnp.TabIndex = 2;
            this.txtACcnp.TextChanged += new System.EventHandler(this.txtACcnp_TextChanged);
            this.txtACcnp.Validating += new System.ComponentModel.CancelEventHandler(this.txtACcnp_Validating);
            // 
            // txtACprenume
            // 
            this.txtACprenume.Location = new System.Drawing.Point(3, 38);
            this.txtACprenume.Name = "txtACprenume";
            this.txtACprenume.Size = new System.Drawing.Size(255, 20);
            this.txtACprenume.TabIndex = 1;
            this.txtACprenume.TextChanged += new System.EventHandler(this.txtACprenume_TextChanged);
            // 
            // txtACnume
            // 
            this.txtACnume.Location = new System.Drawing.Point(3, 3);
            this.txtACnume.Name = "txtACnume";
            this.txtACnume.Size = new System.Drawing.Size(255, 20);
            this.txtACnume.TabIndex = 0;
            this.txtACnume.TextChanged += new System.EventHandler(this.txtACnume_TextChanged);
            // 
            // btACadauga
            // 
            this.btACadauga.BackColor = System.Drawing.Color.Green;
            this.btACadauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btACadauga.ForeColor = System.Drawing.Color.Beige;
            this.btACadauga.Location = new System.Drawing.Point(176, 288);
            this.btACadauga.Name = "btACadauga";
            this.btACadauga.Size = new System.Drawing.Size(84, 30);
            this.btACadauga.TabIndex = 8;
            this.btACadauga.Text = "Adaugă";
            this.btACadauga.UseVisualStyleBackColor = false;
            this.btACadauga.Click += new System.EventHandler(this.btACadauga_Click);
            // 
            // lblACwarning
            // 
            this.lblACwarning.AutoSize = true;
            this.lblACwarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACwarning.Location = new System.Drawing.Point(71, 253);
            this.lblACwarning.Name = "lblACwarning";
            this.lblACwarning.Size = new System.Drawing.Size(372, 18);
            this.lblACwarning.TabIndex = 10;
            this.lblACwarning.Text = "Verificați integritatea datelor înainte de a adăuga!";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblACpret);
            this.panel2.Controls.Add(this.txtAC1cardnr);
            this.panel2.Controls.Add(this.lblACnume);
            this.panel2.Controls.Add(this.lblACprenume);
            this.panel2.Controls.Add(this.lblACcnp);
            this.panel2.Controls.Add(this.lblACcat);
            this.panel2.Controls.Add(this.lblACtip);
            this.panel2.Location = new System.Drawing.Point(3, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 204);
            this.panel2.TabIndex = 13;
            // 
            // txtAC1cardnr
            // 
            this.txtAC1cardnr.Location = new System.Drawing.Point(57, 59);
            this.txtAC1cardnr.Name = "txtAC1cardnr";
            this.txtAC1cardnr.Size = new System.Drawing.Size(127, 20);
            this.txtAC1cardnr.TabIndex = 14;
            this.txtAC1cardnr.TextChanged += new System.EventHandler(this.txtAC1cardnr_TextChanged);
            this.txtAC1cardnr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAC1cardnr_KeyDown);
            this.txtAC1cardnr.Validating += new System.ComponentModel.CancelEventHandler(this.txtAC1cardnr_Validating);
            // 
            // lblAC1info
            // 
            this.lblAC1info.AutoSize = true;
            this.lblAC1info.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAC1info.Location = new System.Drawing.Point(50, 58);
            this.lblAC1info.Name = "lblAC1info";
            this.lblAC1info.Size = new System.Drawing.Size(371, 110);
            this.lblAC1info.TabIndex = 6;
            this.lblAC1info.Text = "Atinge noul card\r\n      de cititor";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::InterfataGrafica.Properties.Resources.Wireless;
            this.pictureBox2.Location = new System.Drawing.Point(100, 170);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(261, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InterfataGrafica.Properties.Resources.pngwing_com;
            this.pictureBox1.Location = new System.Drawing.Point(31, 247);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btACclientn
            // 
            this.btACclientn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btACclientn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btACclientn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btACclientn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btACclientn.Location = new System.Drawing.Point(68, 51);
            this.btACclientn.Name = "btACclientn";
            this.btACclientn.Size = new System.Drawing.Size(329, 62);
            this.btACclientn.TabIndex = 15;
            this.btACclientn.Text = "Client nou";
            this.btACclientn.UseVisualStyleBackColor = false;
            this.btACclientn.Click += new System.EventHandler(this.btACclientn_Click);
            // 
            // btACclientexis
            // 
            this.btACclientexis.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btACclientexis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btACclientexis.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btACclientexis.Location = new System.Drawing.Point(69, 193);
            this.btACclientexis.Name = "btACclientexis";
            this.btACclientexis.Size = new System.Drawing.Size(329, 62);
            this.btACclientexis.TabIndex = 16;
            this.btACclientexis.Text = "Client Existent";
            this.btACclientexis.UseVisualStyleBackColor = false;
            this.btACclientexis.Click += new System.EventHandler(this.btACclientexis_Click);
            // 
            // panelclientexistent
            // 
            this.panelclientexistent.Controls.Add(this.txtp3tip);
            this.panelclientexistent.Controls.Add(this.txtp3cat);
            this.panelclientexistent.Controls.Add(this.btp3adauga);
            this.panelclientexistent.Controls.Add(this.label1);
            this.panelclientexistent.Controls.Add(this.pictureBox3);
            this.panelclientexistent.Controls.Add(this.lblp3pret2);
            this.panelclientexistent.Controls.Add(this.lblp3pret);
            this.panelclientexistent.Controls.Add(this.lblp3tip);
            this.panelclientexistent.Controls.Add(this.lblp3cat);
            this.panelclientexistent.Controls.Add(this.lblp3CNP2);
            this.panelclientexistent.Controls.Add(this.lblp3cnp);
            this.panelclientexistent.Controls.Add(this.lblp3prenume2);
            this.panelclientexistent.Controls.Add(this.lblp3prenume);
            this.panelclientexistent.Controls.Add(this.lblp3nume2);
            this.panelclientexistent.Controls.Add(this.lblp3nume);
            this.panelclientexistent.Controls.Add(this.txtpersoane);
            this.panelclientexistent.Controls.Add(this.lblPersoane);
            this.panelclientexistent.Location = new System.Drawing.Point(3, 36);
            this.panelclientexistent.Name = "panelclientexistent";
            this.panelclientexistent.Size = new System.Drawing.Size(465, 282);
            this.panelclientexistent.TabIndex = 15;
            // 
            // lblPersoane
            // 
            this.lblPersoane.AutoSize = true;
            this.lblPersoane.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersoane.Location = new System.Drawing.Point(6, 12);
            this.lblPersoane.Name = "lblPersoane";
            this.lblPersoane.Size = new System.Drawing.Size(104, 25);
            this.lblPersoane.TabIndex = 0;
            this.lblPersoane.Text = "Persoane";
            // 
            // txtpersoane
            // 
            this.txtpersoane.FormattingEnabled = true;
            this.txtpersoane.Location = new System.Drawing.Point(116, 15);
            this.txtpersoane.Name = "txtpersoane";
            this.txtpersoane.Size = new System.Drawing.Size(333, 21);
            this.txtpersoane.TabIndex = 2;
            this.txtpersoane.TextChanged += new System.EventHandler(this.txtpersoane_TextChanged);
            // 
            // lblp3nume
            // 
            this.lblp3nume.AutoSize = true;
            this.lblp3nume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp3nume.Location = new System.Drawing.Point(36, 47);
            this.lblp3nume.Name = "lblp3nume";
            this.lblp3nume.Size = new System.Drawing.Size(74, 25);
            this.lblp3nume.TabIndex = 3;
            this.lblp3nume.Text = "Nume:";
            // 
            // lblp3nume2
            // 
            this.lblp3nume2.AutoSize = true;
            this.lblp3nume2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp3nume2.Location = new System.Drawing.Point(118, 47);
            this.lblp3nume2.Name = "lblp3nume2";
            this.lblp3nume2.Size = new System.Drawing.Size(0, 25);
            this.lblp3nume2.TabIndex = 4;
            // 
            // lblp3prenume
            // 
            this.lblp3prenume.AutoSize = true;
            this.lblp3prenume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp3prenume.Location = new System.Drawing.Point(6, 76);
            this.lblp3prenume.Name = "lblp3prenume";
            this.lblp3prenume.Size = new System.Drawing.Size(104, 25);
            this.lblp3prenume.TabIndex = 5;
            this.lblp3prenume.Text = "Prenume:";
            // 
            // lblp3prenume2
            // 
            this.lblp3prenume2.AutoSize = true;
            this.lblp3prenume2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp3prenume2.Location = new System.Drawing.Point(118, 76);
            this.lblp3prenume2.Name = "lblp3prenume2";
            this.lblp3prenume2.Size = new System.Drawing.Size(0, 25);
            this.lblp3prenume2.TabIndex = 6;
            // 
            // lblp3cnp
            // 
            this.lblp3cnp.AutoSize = true;
            this.lblp3cnp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp3cnp.Location = new System.Drawing.Point(48, 106);
            this.lblp3cnp.Name = "lblp3cnp";
            this.lblp3cnp.Size = new System.Drawing.Size(62, 25);
            this.lblp3cnp.TabIndex = 7;
            this.lblp3cnp.Text = "CNP:";
            // 
            // lblp3CNP2
            // 
            this.lblp3CNP2.AutoSize = true;
            this.lblp3CNP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp3CNP2.Location = new System.Drawing.Point(118, 106);
            this.lblp3CNP2.Name = "lblp3CNP2";
            this.lblp3CNP2.Size = new System.Drawing.Size(0, 25);
            this.lblp3CNP2.TabIndex = 8;
            // 
            // lblp3cat
            // 
            this.lblp3cat.AutoSize = true;
            this.lblp3cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp3cat.Location = new System.Drawing.Point(-1, 134);
            this.lblp3cat.Name = "lblp3cat";
            this.lblp3cat.Size = new System.Drawing.Size(111, 25);
            this.lblp3cat.TabIndex = 9;
            this.lblp3cat.Text = "Categorie:";
            // 
            // lblp3tip
            // 
            this.lblp3tip.AutoSize = true;
            this.lblp3tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp3tip.Location = new System.Drawing.Point(62, 164);
            this.lblp3tip.Name = "lblp3tip";
            this.lblp3tip.Size = new System.Drawing.Size(48, 25);
            this.lblp3tip.TabIndex = 11;
            this.lblp3tip.Text = "Tip:";
            // 
            // lblp3pret
            // 
            this.lblp3pret.AutoSize = true;
            this.lblp3pret.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp3pret.Location = new System.Drawing.Point(53, 196);
            this.lblp3pret.Name = "lblp3pret";
            this.lblp3pret.Size = new System.Drawing.Size(57, 25);
            this.lblp3pret.TabIndex = 13;
            this.lblp3pret.Text = "Pret:";
            // 
            // lblp3pret2
            // 
            this.lblp3pret2.AutoSize = true;
            this.lblp3pret2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblp3pret2.Location = new System.Drawing.Point(116, 196);
            this.lblp3pret2.Name = "lblp3pret2";
            this.lblp3pret2.Size = new System.Drawing.Size(0, 25);
            this.lblp3pret2.TabIndex = 14;
            // 
            // lblACpret
            // 
            this.lblACpret.AutoSize = true;
            this.lblACpret.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACpret.Location = new System.Drawing.Point(123, 173);
            this.lblACpret.Name = "lblACpret";
            this.lblACpret.Size = new System.Drawing.Size(57, 25);
            this.lblACpret.TabIndex = 15;
            this.lblACpret.Text = "Pret:";
            // 
            // lblACpret2
            // 
            this.lblACpret2.AutoSize = true;
            this.lblACpret2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblACpret2.Location = new System.Drawing.Point(4, 172);
            this.lblACpret2.Name = "lblACpret2";
            this.lblACpret2.Size = new System.Drawing.Size(0, 25);
            this.lblACpret2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Verificați integritatea datelor înainte de a adăuga!";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::InterfataGrafica.Properties.Resources.pngwing_com;
            this.pictureBox3.Location = new System.Drawing.Point(29, 223);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // btp3adauga
            // 
            this.btp3adauga.BackColor = System.Drawing.Color.Green;
            this.btp3adauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btp3adauga.ForeColor = System.Drawing.Color.Beige;
            this.btp3adauga.Location = new System.Drawing.Point(175, 251);
            this.btp3adauga.Name = "btp3adauga";
            this.btp3adauga.Size = new System.Drawing.Size(84, 30);
            this.btp3adauga.TabIndex = 17;
            this.btp3adauga.Text = "Adaugă";
            this.btp3adauga.UseVisualStyleBackColor = false;
            this.btp3adauga.Click += new System.EventHandler(this.btp3adauga_Click);
            // 
            // txtp3cat
            // 
            this.txtp3cat.AutoSize = true;
            this.txtp3cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtp3cat.Location = new System.Drawing.Point(118, 134);
            this.txtp3cat.Name = "txtp3cat";
            this.txtp3cat.Size = new System.Drawing.Size(0, 25);
            this.txtp3cat.TabIndex = 18;
            // 
            // txtp3tip
            // 
            this.txtp3tip.AutoSize = true;
            this.txtp3tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtp3tip.Location = new System.Drawing.Point(118, 164);
            this.txtp3tip.Name = "txtp3tip";
            this.txtp3tip.Size = new System.Drawing.Size(0, 25);
            this.txtp3tip.TabIndex = 19;
            // 
            // AdaugaCard1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.panelclientexistent);
            this.Controls.Add(this.btACclientexis);
            this.Controls.Add(this.btACclientn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblACwarning);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btACadauga);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAC1info);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 360);
            this.MinimumSize = new System.Drawing.Size(480, 360);
            this.Name = "AdaugaCard1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adauga Card";
            this.Load += new System.EventHandler(this.AdaugaCard1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelclientexistent.ResumeLayout(false);
            this.panelclientexistent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblACnume;
        private System.Windows.Forms.Label lblACprenume;
        private System.Windows.Forms.Label lblACcnp;
        private System.Windows.Forms.Label lblACcat;
        private System.Windows.Forms.Label lblACtip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtACnume;
        private System.Windows.Forms.TextBox txtACprenume;
        private System.Windows.Forms.TextBox txtACcnp;
        private System.Windows.Forms.Button btACadauga;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblACwarning;
        private System.Windows.Forms.ComboBox txtACcat;
        private System.Windows.Forms.ComboBox txtACtip;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAC1info;
        private System.Windows.Forms.TextBox txtAC1cardnr;
        private PictureBox pictureBox2;
        private Button btACclientn;
        private Button btACclientexis;
        private Panel panelclientexistent;
        private Label lblp3tip;
        private Label lblp3cat;
        private Label lblp3CNP2;
        private Label lblp3cnp;
        private Label lblp3prenume2;
        private Label lblp3prenume;
        private Label lblp3nume2;
        private Label lblp3nume;
        private ComboBox txtpersoane;
        private Label lblPersoane;
        private Label lblp3pret2;
        private Label lblp3pret;
        private Label lblACpret2;
        private Label lblACpret;
        private Label label1;
        private PictureBox pictureBox3;
        private Button btp3adauga;
        private Label txtp3tip;
        private Label txtp3cat;
    }
}