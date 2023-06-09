namespace InterfataGrafica
{
    partial class IncarcaCard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblICpret1 = new System.Windows.Forms.Label();
            this.txtICcardnr = new System.Windows.Forms.TextBox();
            this.lblICexpira = new System.Windows.Forms.Label();
            this.lblICincepe = new System.Windows.Forms.Label();
            this.lblICcat = new System.Windows.Forms.Label();
            this.lblICtip = new System.Windows.Forms.Label();
            this.btICincarca = new System.Windows.Forms.Button();
            this.lblIC1info = new System.Windows.Forms.Label();
            this.lblICpret2 = new System.Windows.Forms.Label();
            this.txtICcat = new System.Windows.Forms.ComboBox();
            this.txtICtip = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblICexpira2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTitle.Location = new System.Drawing.Point(94, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(182, 25);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Încarcă Cardul nr ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblICpret1);
            this.panel1.Controls.Add(this.txtICcardnr);
            this.panel1.Controls.Add(this.lblICexpira);
            this.panel1.Controls.Add(this.lblICincepe);
            this.panel1.Controls.Add(this.lblICcat);
            this.panel1.Controls.Add(this.lblICtip);
            this.panel1.Location = new System.Drawing.Point(7, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 185);
            this.panel1.TabIndex = 14;
            // 
            // lblICpret1
            // 
            this.lblICpret1.AutoSize = true;
            this.lblICpret1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblICpret1.Location = new System.Drawing.Point(119, 146);
            this.lblICpret1.Name = "lblICpret1";
            this.lblICpret1.Size = new System.Drawing.Size(57, 25);
            this.lblICpret1.TabIndex = 19;
            this.lblICpret1.Text = "Pret:";
            // 
            // txtICcardnr
            // 
            this.txtICcardnr.Location = new System.Drawing.Point(92, 65);
            this.txtICcardnr.Name = "txtICcardnr";
            this.txtICcardnr.Size = new System.Drawing.Size(106, 20);
            this.txtICcardnr.TabIndex = 18;
            this.txtICcardnr.TextChanged += new System.EventHandler(this.txtICcardnr_TextChanged);
            // 
            // lblICexpira
            // 
            this.lblICexpira.AutoSize = true;
            this.lblICexpira.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblICexpira.Location = new System.Drawing.Point(96, 110);
            this.lblICexpira.Name = "lblICexpira";
            this.lblICexpira.Size = new System.Drawing.Size(79, 25);
            this.lblICexpira.TabIndex = 7;
            this.lblICexpira.Text = "Expiră:";
            // 
            // lblICincepe
            // 
            this.lblICincepe.AutoSize = true;
            this.lblICincepe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblICincepe.Location = new System.Drawing.Point(96, 74);
            this.lblICincepe.Name = "lblICincepe";
            this.lblICincepe.Size = new System.Drawing.Size(82, 25);
            this.lblICincepe.TabIndex = 6;
            this.lblICincepe.Text = "Incepe:";
            // 
            // lblICcat
            // 
            this.lblICcat.AutoSize = true;
            this.lblICcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblICcat.Location = new System.Drawing.Point(69, 0);
            this.lblICcat.Name = "lblICcat";
            this.lblICcat.Size = new System.Drawing.Size(111, 25);
            this.lblICcat.TabIndex = 4;
            this.lblICcat.Text = "Categorie:";
            // 
            // lblICtip
            // 
            this.lblICtip.AutoSize = true;
            this.lblICtip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblICtip.Location = new System.Drawing.Point(17, 37);
            this.lblICtip.Name = "lblICtip";
            this.lblICtip.Size = new System.Drawing.Size(163, 25);
            this.lblICtip.TabIndex = 5;
            this.lblICtip.Text = "Tip Abonament:";
            // 
            // btICincarca
            // 
            this.btICincarca.BackColor = System.Drawing.Color.Green;
            this.btICincarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btICincarca.ForeColor = System.Drawing.Color.Beige;
            this.btICincarca.Location = new System.Drawing.Point(190, 230);
            this.btICincarca.Name = "btICincarca";
            this.btICincarca.Size = new System.Drawing.Size(84, 30);
            this.btICincarca.TabIndex = 16;
            this.btICincarca.Text = "Încarcă";
            this.btICincarca.UseVisualStyleBackColor = false;
            this.btICincarca.Click += new System.EventHandler(this.btICincarca_Click);
            // 
            // lblIC1info
            // 
            this.lblIC1info.AutoSize = true;
            this.lblIC1info.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIC1info.Location = new System.Drawing.Point(77, 33);
            this.lblIC1info.Name = "lblIC1info";
            this.lblIC1info.Size = new System.Drawing.Size(304, 110);
            this.lblIC1info.TabIndex = 8;
            this.lblIC1info.Text = "Atinge cardul\r\n    de cititor";
            // 
            // lblICpret2
            // 
            this.lblICpret2.AutoSize = true;
            this.lblICpret2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblICpret2.Location = new System.Drawing.Point(4, 146);
            this.lblICpret2.Name = "lblICpret2";
            this.lblICpret2.Size = new System.Drawing.Size(0, 25);
            this.lblICpret2.TabIndex = 20;
            // 
            // txtICcat
            // 
            this.txtICcat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtICcat.FormattingEnabled = true;
            this.txtICcat.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtICcat.Items.AddRange(new object[] {
            "Nominal",
            "Pensionar",
            "Student",
            "Elev",
            "Nenominal"});
            this.txtICcat.Location = new System.Drawing.Point(0, 4);
            this.txtICcat.Name = "txtICcat";
            this.txtICcat.Size = new System.Drawing.Size(255, 21);
            this.txtICcat.TabIndex = 11;
            this.txtICcat.TextChanged += new System.EventHandler(this.txtICcat_TextChanged);
            // 
            // txtICtip
            // 
            this.txtICtip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtICtip.FormattingEnabled = true;
            this.txtICtip.Items.AddRange(new object[] {
            "1 zi",
            "15 zile",
            "Lunar"});
            this.txtICtip.Location = new System.Drawing.Point(0, 41);
            this.txtICtip.Name = "txtICtip";
            this.txtICtip.Size = new System.Drawing.Size(255, 21);
            this.txtICtip.TabIndex = 12;
            this.txtICtip.TextChanged += new System.EventHandler(this.txtICtip_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(-2, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(257, 20);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::InterfataGrafica.Properties.Resources.Wireless;
            this.pictureBox2.Location = new System.Drawing.Point(98, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(261, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // lblICexpira2
            // 
            this.lblICexpira2.AutoSize = true;
            this.lblICexpira2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblICexpira2.Location = new System.Drawing.Point(4, 112);
            this.lblICexpira2.Name = "lblICexpira2";
            this.lblICexpira2.Size = new System.Drawing.Size(0, 25);
            this.lblICexpira2.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblICpret2);
            this.panel2.Controls.Add(this.lblICexpira2);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.txtICtip);
            this.panel2.Controls.Add(this.txtICcat);
            this.panel2.Location = new System.Drawing.Point(195, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 185);
            this.panel2.TabIndex = 15;
            // 
            // IncarcaCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(464, 263);
            this.Controls.Add(this.lblIC1info);
            this.Controls.Add(this.btICincarca);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.MaximumSize = new System.Drawing.Size(480, 302);
            this.MinimumSize = new System.Drawing.Size(480, 302);
            this.Name = "IncarcaCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Incarca Card";
            this.Load += new System.EventHandler(this.IncarcaCard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblICcat;
        private System.Windows.Forms.Label lblICtip;
        private System.Windows.Forms.Label lblICincepe;
        private System.Windows.Forms.Label lblICexpira;
        private System.Windows.Forms.Button btICincarca;
        private System.Windows.Forms.Label lblIC1info;
        private System.Windows.Forms.TextBox txtICcardnr;
        private System.Windows.Forms.Label lblICpret1;
        private System.Windows.Forms.Label lblICpret2;
        private System.Windows.Forms.ComboBox txtICcat;
        private System.Windows.Forms.ComboBox txtICtip;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblICexpira2;
        private System.Windows.Forms.Panel panel2;
    }
}