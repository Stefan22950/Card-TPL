namespace InterfataGrafica
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLID = new System.Windows.Forms.TextBox();
            this.lblLid = new System.Windows.Forms.Label();
            this.lblLlogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtLID);
            this.panel1.Controls.Add(this.lblLid);
            this.panel1.Controls.Add(this.lblLlogin);
            this.panel1.Location = new System.Drawing.Point(241, 164);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 259);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(163, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Logare";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLID
            // 
            this.txtLID.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLID.Location = new System.Drawing.Point(137, 107);
            this.txtLID.Multiline = true;
            this.txtLID.Name = "txtLID";
            this.txtLID.Size = new System.Drawing.Size(193, 43);
            this.txtLID.TabIndex = 2;
            // 
            // lblLid
            // 
            this.lblLid.AutoSize = true;
            this.lblLid.BackColor = System.Drawing.Color.Transparent;
            this.lblLid.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLid.Location = new System.Drawing.Point(67, 107);
            this.lblLid.Name = "lblLid";
            this.lblLid.Size = new System.Drawing.Size(64, 39);
            this.lblLid.TabIndex = 1;
            this.lblLid.Text = "ID:";
            // 
            // lblLlogin
            // 
            this.lblLlogin.AutoSize = true;
            this.lblLlogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLlogin.Location = new System.Drawing.Point(146, 24);
            this.lblLlogin.Name = "lblLlogin";
            this.lblLlogin.Size = new System.Drawing.Size(141, 42);
            this.lblLlogin.TabIndex = 0;
            this.lblLlogin.Text = "Logare";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InterfataGrafica.Properties.Resources._20230322_154359_058_saved;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(910, 595);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLID;
        private System.Windows.Forms.Label lblLid;
        private System.Windows.Forms.Label lblLlogin;
        private System.Windows.Forms.Button button1;
    }
}