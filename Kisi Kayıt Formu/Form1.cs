using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kisi_Kayıt_Formu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("TC KİMLİK NO", 150);
            listView1.Columns.Add("AD SOYAD", 200);
            listView1.Columns.Add("YAS", 100);
            listView1.Columns.Add("MEZUNİYET", 150);
            listView1.Columns.Add("CİNSİYET", 125);
            listView1.Columns.Add("DOGUM YERİ", 125);
            listView1.Columns.Add("TELEFON NO", 125);

            string[] mezuniyet = { "İlköğretim", "OrtaÖğretim", "Lise", "Lisans", "Yüksek Lisans", "Doktora" };
            comboBox1.Items.AddRange(mezuniyet);
            KayitSayisiYaz();

        }
        private void KayitSayisiYaz()
        {
            int kayitSayisi = listView1.Items.Count;
            label2.Text = kayitSayisi.ToString();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string tc = "", adSoyad = "", yas = "", dogumYeri = "", mezuniyet = "", cinsiyet = "", telNo = "";
            tc = txtTcKimlik.Text;
            adSoyad = txtAdSoyad.Text;
            yas = txtYas.Text;
            dogumYeri = txtDogumYeri.Text;
            mezuniyet = comboBox1.Text;
            telNo = txtTelefonNo.Text;
            if (rdbBay.Checked == true)
            {
                cinsiyet = rdbBay.Text;
            }
            else if (rdbBayan.Checked == true)
            {
                cinsiyet = rdbBayan.Text;
            }

            string[] bilgiler = { tc, adSoyad, yas, mezuniyet, cinsiyet, dogumYeri, telNo };
            bool arananKayitKontrolu = false;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text == txtTcKimlik.Text)
                {
                    arananKayitKontrolu = true;
                    MessageBox.Show(txtTcKimlik.Text + " Tc Kimlik Numarası Kayıtlarda Mevcuttur");
                }
            }
            if (arananKayitKontrolu == false)
            {
                ListViewItem lst = new ListViewItem(bilgiler);
                if (tc != "" && adSoyad != "" && yas != "" && mezuniyet != "" && cinsiyet != "" && dogumYeri != "" && telNo != "")
                {
                    listView1.Items.Add(lst);
                }
                else
                {
                    MessageBox.Show("Kayıt Bilgisi Eksik");
                }
                KayitSayisiYaz();
            }
        }
        private void btnSilChkbx_Click(object sender, EventArgs e)
        {
            int secilenSayisi = listView1.CheckedItems.Count;

            foreach (ListViewItem secilenKayitBilgisi in listView1.CheckedItems)
            {
                secilenKayitBilgisi.Remove();

            }
            MessageBox.Show(secilenSayisi.ToString() + " kadar kayıt silinmiştir");
            KayitSayisiYaz();
        }

        private void btnSilNormalSecim_Click(object sender, EventArgs e)
        {
            int secilenSayisi1 = listView1.SelectedItems.Count;
            foreach (ListViewItem secilenKayitBilgisi in listView1.SelectedItems)
            {
                secilenKayitBilgisi.Remove();

            }
            MessageBox.Show(secilenSayisi1.ToString() + " kadar kayıt silinmiştir");
            KayitSayisiYaz();
        }
        private void btnTümSil_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            KayitSayisiYaz();
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            bool arananKayitKontrolu = false;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[0].Text == txtTcKimlik.Text || listView1.Items[i].SubItems[1].Text == txtAdSoyad.Text)
                {
                    arananKayitKontrolu = true;
                    txtAdSoyad.Text = listView1.Items[i].SubItems[1].Text;
                    txtYas.Text = listView1.Items[i].SubItems[2].Text;
                    txtDogumYeri.Text = listView1.Items[i].SubItems[5].Text;
                    txtTelefonNo.Text = listView1.Items[i].SubItems[6].Text;
                    if (listView1.Items[i].SubItems[4].Text == "Bay")
                    {
                        rdbBay.Checked = true;
                    }
                    else if (listView1.Items[i].SubItems[4].Text == "Bayan")
                    {
                        rdbBayan.Checked = true;
                    }
                    txtAdSoyad.Enabled = false; txtDogumYeri.Enabled = false; txtTelefonNo.Enabled = false;
                    txtYas.Enabled = false; groupBox1.Enabled = false; comboBox1.Enabled = false;
                }
                if (arananKayitKontrolu = false)
                {
                    MessageBox.Show(txtTcKimlik.Text + " Tc Kimlik Numaralı Kayıt Bulunamadı");
                }
            }

        }
        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            txtAdSoyad.Enabled = true; txtDogumYeri.Enabled = true; txtTelefonNo.Enabled = true;
            txtYas.Enabled = true; groupBox1.Enabled = true; comboBox1.Enabled = true;
        }
    }
}
