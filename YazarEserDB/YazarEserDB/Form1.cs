using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/// <summary>
/// CREATED BY BURAK ALPASLAN, BUSE DURAN, NURAY MARHAN
/// </summary>

namespace YazarEserDB
{
    public partial class Form1 : Form
    {
        Yazarlar yazar = new Yazarlar();
        Eserler eser = new Eserler();
        public Form1()
        {
            InitializeComponent();
        }

        YazarlarEserlerEntities7 db = new YazarlarEserlerEntities7();
        private void Form1_Load(object sender, EventArgs e)
        {
            GetAuthors();
            GetAuthors2();
            LoadGenreSort();
            LoadAuthorstoCombobox();
            LoadBooks();
        }

        // ANASAYFA :
        //This fills combobox with authors name.
        public void GetAuthors()
        {
            foreach (Yazarlar item in db.Yazarlars.ToList())
            {
                cbxYazarlar.Items.Add(item.YazarAdi);
            }
        }

        //This fills listbox with books according to selected author from combobox.      
        public void LoadListBox()
        {
            lstEserler.Items.Clear();
            foreach (Yazarlar yazar in db.Yazarlars.ToList())
            {
                foreach (Eserler eser in db.Eserlers.ToList())
                {
                    if (yazar.YazarID == eser.YazarID && cbxYazarlar.SelectedIndex + 1 == eser.YazarID)
                        lstEserler.Items.Add(eser.Baslik);
                }
            }
        }

        //This shows books in the listbox.
        private void cbxYazarlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListBox();
        }

        //This fills textbox with description with respect to selected book from listbox.
        public void AddDescription()
        {
            foreach (Eserler eser in db.Eserlers.ToList())
            {
                if (lstEserler.SelectedItem.ToString() == eser.Baslik)
                    txtAciklama.Text = eser.Icerik;
            }
        }

        //This shows description in the textbox.
        private void lstEserler_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddDescription();
        }

        //This clears all information in combobox, listbox and textbox.
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAciklama.Clear();
            lstEserler.Items.Clear();
            cbxYazarlar.Text = string.Empty;
        }

        // YAZARLAR:
        //This button adds full name of the author.
        private void btnEkleYazarlar_Click(object sender, EventArgs e)
        {
            if (txtTamAd.Text.Trim() == "")
                MessageBox.Show("Lütfen Tam Ad Bilgisini Boş Bırakmayınız!");
            else
            {
                if (!lstYazarlar.Items.Contains(txtTamAd.Text))
                {
                    yazar = new Yazarlar()
                    {
                        YazarAdi = txtTamAd.Text,
                    };
                    lstYazarlar.Items.Add(yazar.YazarAdi);
                    cbxYazarr.Items.Add(yazar.YazarAdi);
                    db.Yazarlars.Add(yazar);
                    db.SaveChanges();

                }
                else
                    MessageBox.Show("Böyle bir yazar zaten kayıtlı!");
            }
        }

        //This clears the full name of the author written in textbox.
        private void btnIptalYazarlar_Click(object sender, EventArgs e)
        {
            txtTamAd.Clear();
        }

        //This shows the added full name of author in the listbox.
        private void GetAuthors2()
        {
            foreach (Yazarlar yazar in db.Yazarlars.ToList())
            {
                lstYazarlar.Items.Add(yazar.YazarAdi);
            }
        }

        // ESERLER:
        //This fills the combobox of authors.
        public void LoadAuthorstoCombobox()
        {
            foreach (Yazarlar item in db.Yazarlars.ToList())
            {
                cbxYazarr.Items.Add(item.YazarAdi);
            }
        }

        //This fills the combobox of gendre sort.
        public void LoadGenreSort()
        {
            foreach (Eserler item in db.Eserlers.ToList())
            {
                if (item.EserTuru != null && !cbxTur.Items.Contains(item.EserTuru))
                    cbxTur.Items.Add(item.EserTuru);
            }
        }

        //This shows added informations in the listbox.
        public void LoadBooks()
        {

            foreach (var item in db.Eserlers.ToList())
            {

                ListViewItem lv = new ListViewItem();
                lv.Text = item.Baslik;
                lv.SubItems.Add(item.EserTuru != null ? item.EserTuru : "");
                lv.SubItems.Add(item.Yazarlar != null ? item.Yazarlar.YazarAdi : "");

                lsvEserler.Items.Add(lv);
            }
        }

        //This adds written and chosen informations to the list.
        private void btnEkleEserler_Click(object sender, EventArgs e)
        {
            lsvEserler.Items.Clear();
            if (txtEserBaslik.Text.Trim() == "")
                MessageBox.Show("Lütfen Tam Ad Bilgisini Boş Bırakmayınız!");
            else
            {
                ListViewItem lvi2 = new ListViewItem();
                lvi2.Text = eser.Baslik;
                lvi2.SubItems.Add(cbxTur.Text);
                lvi2.SubItems.Add(cbxYazarr.Text);
                yazar = null;
                if (cbxYazarr.Text != null)
                    yazar = db.Yazarlars.Where(y => y.YazarAdi == cbxYazarr.Text).FirstOrDefault();

                eser = new Eserler()
                {
                    Baslik = txtEserBaslik.Text,
                    EserTuru = (String.IsNullOrEmpty(cbxTur.Text) ? null : cbxTur.Text),
                    Yazarlar = yazar
                };
                db.Eserlers.Add(eser);
                db.SaveChanges();
                LoadBooks();
            }

        }

        //This clears all information.
        private void btnIptalEserler_Click(object sender, EventArgs e)
        {
            txtEserBaslik.Clear();
            cbxTur.Text = string.Empty;
            cbxYazarr.Text = string.Empty;

        }

        // This clears the added information from listview.
        private void btnSil_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < lsvEserler.Items.Count; i++)
            {

                if (lsvEserler.Items[i].Selected)
                {
                    lsvEserler.Items[i].SubItems.Clear();
                }

            }
        }
    }
}

