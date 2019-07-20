namespace $safeprojectname$
{
    partial class Form1
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
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBolum = new System.Windows.Forms.ComboBox();
            this.listBoxDegisen = new System.Windows.Forms.ListBox();
            this.listBoxBoyanan = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblYil = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(12, 40);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(240, 20);
            this.txtPlaka.TabIndex = 0;
            this.txtPlaka.TextChanged += new System.EventHandler(this.txtPlaka_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plaka";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bolum";
            // 
            // comboBolum
            // 
            this.comboBolum.FormattingEnabled = true;
            this.comboBolum.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.comboBolum.Location = new System.Drawing.Point(314, 40);
            this.comboBolum.Name = "comboBolum";
            this.comboBolum.Size = new System.Drawing.Size(121, 21);
            this.comboBolum.TabIndex = 4;
            // 
            // listBoxDegisen
            // 
            this.listBoxDegisen.FormattingEnabled = true;
            this.listBoxDegisen.Location = new System.Drawing.Point(15, 92);
            this.listBoxDegisen.Name = "listBoxDegisen";
            this.listBoxDegisen.Size = new System.Drawing.Size(228, 160);
            this.listBoxDegisen.TabIndex = 5;
            this.listBoxDegisen.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBoxBoyanan
            // 
            this.listBoxBoyanan.FormattingEnabled = true;
            this.listBoxBoyanan.Location = new System.Drawing.Point(15, 282);
            this.listBoxBoyanan.Name = "listBoxBoyanan";
            this.listBoxBoyanan.Size = new System.Drawing.Size(228, 173);
            this.listBoxBoyanan.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Durum:";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(373, 104);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(51, 13);
            this.lblDurum.TabIndex = 8;
            this.lblDurum.Text = "unknown";
            this.lblDurum.Click += new System.EventHandler(this.lblDurum_Click);
            // 
            // lblYil
            // 
            this.lblYil.AutoSize = true;
            this.lblYil.Location = new System.Drawing.Point(373, 207);
            this.lblYil.Name = "lblYil";
            this.lblYil.Size = new System.Drawing.Size(51, 13);
            this.lblYil.TabIndex = 10;
            this.lblYil.Text = "unknown";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Yıl:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(373, 175);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(51, 13);
            this.lblModel.TabIndex = 12;
            this.lblModel.Text = "unknown";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(314, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Model:";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(373, 139);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(51, 13);
            this.lblMarka.TabIndex = 14;
            this.lblMarka.Text = "unknown";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(314, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Marka:";
            // 
            // btnSorgula
            // 
            this.btnSorgula.Location = new System.Drawing.Point(467, 36);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(249, 23);
            this.btnSorgula.TabIndex = 15;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 464);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblYil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxBoyanan);
            this.Controls.Add(this.listBoxDegisen);
            this.Controls.Add(this.comboBolum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlaka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBolum;
        private System.Windows.Forms.ListBox listBoxDegisen;
        private System.Windows.Forms.ListBox listBoxBoyanan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblYil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSorgula;
    }
}

