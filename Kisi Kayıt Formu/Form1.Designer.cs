
namespace Kisi_Kayıt_Formu
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
            this.lblTcKimlik = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblMezuniyet = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtTcKimlik = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSilChkbx = new System.Windows.Forms.Button();
            this.btnSilNormalSecim = new System.Windows.Forms.Button();
            this.btnTümSil = new System.Windows.Forms.Button();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbBay = new System.Windows.Forms.RadioButton();
            this.rdbBayan = new System.Windows.Forms.RadioButton();
            this.lblDogumYeri = new System.Windows.Forms.Label();
            this.lblTelefonNo = new System.Windows.Forms.Label();
            this.txtDogumYeri = new System.Windows.Forms.TextBox();
            this.txtTelefonNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTcKimlik
            // 
            this.lblTcKimlik.AutoSize = true;
            this.lblTcKimlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTcKimlik.Location = new System.Drawing.Point(12, 20);
            this.lblTcKimlik.Name = "lblTcKimlik";
            this.lblTcKimlik.Size = new System.Drawing.Size(110, 17);
            this.lblTcKimlik.TabIndex = 0;
            this.lblTcKimlik.Text = "TC KİMLİK NO";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(12, 67);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(95, 17);
            this.lblAdSoyad.TabIndex = 0;
            this.lblAdSoyad.Text = "ADI SOYADI";
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYas.Location = new System.Drawing.Point(12, 114);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(42, 17);
            this.lblYas.TabIndex = 0;
            this.lblYas.Text = "YAŞI";
            // 
            // lblMezuniyet
            // 
            this.lblMezuniyet.AutoSize = true;
            this.lblMezuniyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMezuniyet.Location = new System.Drawing.Point(12, 161);
            this.lblMezuniyet.Name = "lblMezuniyet";
            this.lblMezuniyet.Size = new System.Drawing.Size(96, 17);
            this.lblMezuniyet.TabIndex = 0;
            this.lblMezuniyet.Text = "MEZUNİYET";
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(310, 20);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 33);
            this.btnAra.TabIndex = 1;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtTcKimlik
            // 
            this.txtTcKimlik.Location = new System.Drawing.Point(154, 20);
            this.txtTcKimlik.Name = "txtTcKimlik";
            this.txtTcKimlik.Size = new System.Drawing.Size(120, 20);
            this.txtTcKimlik.TabIndex = 2;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(154, 64);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(120, 20);
            this.txtAdSoyad.TabIndex = 2;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(154, 114);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(120, 20);
            this.txtYas.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(153, 160);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(13, 219);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 33);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSilChkbx
            // 
            this.btnSilChkbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSilChkbx.Location = new System.Drawing.Point(120, 219);
            this.btnSilChkbx.Name = "btnSilChkbx";
            this.btnSilChkbx.Size = new System.Drawing.Size(149, 33);
            this.btnSilChkbx.TabIndex = 1;
            this.btnSilChkbx.Text = "SİL(checkbox)";
            this.btnSilChkbx.UseVisualStyleBackColor = true;
            this.btnSilChkbx.Click += new System.EventHandler(this.btnSilChkbx_Click);
            // 
            // btnSilNormalSecim
            // 
            this.btnSilNormalSecim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSilNormalSecim.Location = new System.Drawing.Point(301, 219);
            this.btnSilNormalSecim.Name = "btnSilNormalSecim";
            this.btnSilNormalSecim.Size = new System.Drawing.Size(161, 33);
            this.btnSilNormalSecim.TabIndex = 1;
            this.btnSilNormalSecim.Text = "SİL(normal Seçim)";
            this.btnSilNormalSecim.UseVisualStyleBackColor = true;
            this.btnSilNormalSecim.Click += new System.EventHandler(this.btnSilNormalSecim_Click);
            // 
            // btnTümSil
            // 
            this.btnTümSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTümSil.Location = new System.Drawing.Point(494, 219);
            this.btnTümSil.Name = "btnTümSil";
            this.btnTümSil.Size = new System.Drawing.Size(133, 33);
            this.btnTümSil.TabIndex = 1;
            this.btnTümSil.Text = "TÜMÜNÜ SİL";
            this.btnTümSil.UseVisualStyleBackColor = true;
            this.btnTümSil.Click += new System.EventHandler(this.btnTümSil_Click);
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniKayit.Location = new System.Drawing.Point(659, 219);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(129, 33);
            this.btnYeniKayit.TabIndex = 1;
            this.btnYeniKayit.Text = "YENİ KAYIT";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbBayan);
            this.groupBox1.Controls.Add(this.rdbBay);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(431, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 64);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CİNSİYET";
            // 
            // rdbBay
            // 
            this.rdbBay.AutoSize = true;
            this.rdbBay.Location = new System.Drawing.Point(29, 31);
            this.rdbBay.Name = "rdbBay";
            this.rdbBay.Size = new System.Drawing.Size(56, 21);
            this.rdbBay.TabIndex = 0;
            this.rdbBay.TabStop = true;
            this.rdbBay.Text = "BAY";
            this.rdbBay.UseVisualStyleBackColor = true;
            // 
            // rdbBayan
            // 
            this.rdbBayan.AutoSize = true;
            this.rdbBayan.Location = new System.Drawing.Point(129, 31);
            this.rdbBayan.Name = "rdbBayan";
            this.rdbBayan.Size = new System.Drawing.Size(77, 21);
            this.rdbBayan.TabIndex = 1;
            this.rdbBayan.TabStop = true;
            this.rdbBayan.Text = "BAYAN";
            this.rdbBayan.UseVisualStyleBackColor = true;
            // 
            // lblDogumYeri
            // 
            this.lblDogumYeri.AutoSize = true;
            this.lblDogumYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumYeri.Location = new System.Drawing.Point(391, 114);
            this.lblDogumYeri.Name = "lblDogumYeri";
            this.lblDogumYeri.Size = new System.Drawing.Size(106, 17);
            this.lblDogumYeri.TabIndex = 0;
            this.lblDogumYeri.Text = "DOĞUM YERİ";
            // 
            // lblTelefonNo
            // 
            this.lblTelefonNo.AutoSize = true;
            this.lblTelefonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefonNo.Location = new System.Drawing.Point(391, 160);
            this.lblTelefonNo.Name = "lblTelefonNo";
            this.lblTelefonNo.Size = new System.Drawing.Size(107, 17);
            this.lblTelefonNo.TabIndex = 0;
            this.lblTelefonNo.Text = "TELEFON NO";
            // 
            // txtDogumYeri
            // 
            this.txtDogumYeri.Location = new System.Drawing.Point(540, 114);
            this.txtDogumYeri.Name = "txtDogumYeri";
            this.txtDogumYeri.Size = new System.Drawing.Size(120, 20);
            this.txtDogumYeri.TabIndex = 2;
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Location = new System.Drawing.Point(540, 158);
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(120, 20);
            this.txtTelefonNo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(802, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kayıt Sayısı :";
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 271);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(965, 228);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Salmon;
            this.label2.Location = new System.Drawing.Point(910, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 532);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtTelefonNo);
            this.Controls.Add(this.txtDogumYeri);
            this.Controls.Add(this.txtTcKimlik);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnYeniKayit);
            this.Controls.Add(this.btnTümSil);
            this.Controls.Add(this.btnSilNormalSecim);
            this.Controls.Add(this.btnSilChkbx);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.lblMezuniyet);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTelefonNo);
            this.Controls.Add(this.lblDogumYeri);
            this.Controls.Add(this.lblTcKimlik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTcKimlik;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblMezuniyet;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtTcKimlik;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSilChkbx;
        private System.Windows.Forms.Button btnSilNormalSecim;
        private System.Windows.Forms.Button btnTümSil;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbBayan;
        private System.Windows.Forms.RadioButton rdbBay;
        private System.Windows.Forms.Label lblDogumYeri;
        private System.Windows.Forms.Label lblTelefonNo;
        private System.Windows.Forms.TextBox txtDogumYeri;
        private System.Windows.Forms.TextBox txtTelefonNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
    }
}

