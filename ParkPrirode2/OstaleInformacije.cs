using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkPrirode2.DTO;
using ParkPrirode2.DTOManangers;


namespace ParkPrirode2
{
    public partial class OstaleInformacije : Form
    {
        public int IdOblasti { get; set; }
        public string TipZastite { get; set; }

        public OstaleInformacije()
        {
            InitializeComponent();            
        }
        public OstaleInformacije(int id,string tip)
        {
            InitializeComponent();
            IdOblasti = id;
            TipZastite = tip;

        }

        private void popuniPolja()
        {
            lblTipZastite.Text = this.TipZastite;
            cmbIzaberi.Items.Clear();
            cmbIzaberi.Items.Add("Radnici");
            cmbIzaberi.Items.Add("Biljke");
            cmbIzaberi.Items.Add("Zivotinje");
            cmbIzaberi.Items.Add("Opstine u oblasti");            
            if (this.TipZastite == "Stalna zastita")
                cmbIzaberi.Items.Add("Hranilista");
            cmbIzaberi.SelectedIndex = 0;
            this.prikaziRadnike();
            
        }

        
        private void postaviImenaKolonaRadnik()// prikazivanje dgv-a za oba slucaja
        {
            dataGridView1.Columns[0].HeaderText = "ID radnika";
            dataGridView1.Columns[1].HeaderText = "Ime";
            dataGridView1.Columns[2].HeaderText = "Prezime";
            dataGridView1.Columns[3].HeaderText = "Tip radnika";
            if (this.TipZastite == "Stalna zastita")
                dataGridView1.Columns[4].HeaderText = "Radna knjizica";//
        }
   

       

        private void postaviImenaKolonaBiljka()
        {
            dataGridView1.Columns[0].HeaderText = "ID biljke";
            dataGridView1.Columns[1].HeaderText = "Latinski naziv";
            dataGridView1.Columns[2].HeaderText = "lokalni naziv";
            dataGridView1.Columns[3].HeaderText = "Posebna zastita";
          
        }

        private void postaviImenaKolonaZivotinja()
        {
            dataGridView1.Columns[0].HeaderText = "ID zivotinje";
            dataGridView1.Columns[1].HeaderText = "Latinski naziv";
            dataGridView1.Columns[2].HeaderText = "Lokalni naziv";
            dataGridView1.Columns[3].HeaderText = "SBP";
            dataGridView1.Columns[4].HeaderText = "Zivotinja/Ptica (1/0)";

        }

        private void postaviImenaKolonaOpstineUOblasti()// prikazivanje dgv-a za oba slucaja
        {
            dataGridView1.Columns[0].HeaderText = "ID Opstine u oblasti";
            dataGridView1.Columns[1].HeaderText = "Naziv opstine";
        }

        private void postaviImenaKolonaHraniliste()
        {
            dataGridView1.Columns[0].HeaderText = "Broj hranilista";
            dataGridView1.Columns[1].HeaderText = "Pocetni mesec";
            dataGridView1.Columns[2].HeaderText = "Krajnji mesec";
            dataGridView1.Columns[3].HeaderText = "Pripada oblasti";
        }

        private void prikaziPodatke()
        {
            if (cmbIzaberi.SelectedIndex != 3)
                btnIzmeni.Visible = true;
            switch (cmbIzaberi.SelectedIndex)
            {
                case 0:
                    this.prikaziRadnike();
                    break;
                case 1:
                    this.prikaziBiljke();
                    break;
                case 2:
                    this.prikaziZivotinje();
                    break;
                case 3:
                    this.prikaziOpstineUOBlasti();
                    break;
                case 4:
                    this.prikaziHranilista();
                    break;

            }
        }

        private void prikaziRadnike()
        {
            if (this.TipZastite == "Stalna zastita")
            {
                dataGridView1.DataSource = DTOManangerRadnik.VratiStalneRadnikePrikaz(IdOblasti);
            }
            else
            {
                dataGridView1.DataSource = DTOManangerRadnik.VratiRadnikePrikaz(IdOblasti);                
            }
            this.postaviImenaKolonaRadnik();
        }


        private void prikaziBiljke()
        {
            dataGridView1.DataSource = DTOManangerBiljka.VratiSveBiljkeView(this.IdOblasti);
            this.postaviImenaKolonaBiljka();
        }


        private void prikaziZivotinje()
        {
            
                dataGridView1.DataSource = DTOManangerZivotinja.VratiZivotinjePrikaz(IdOblasti);
            
            this.postaviImenaKolonaZivotinja();
        }

        private void prikaziOpstineUOBlasti()
        {
            if (cmbIzaberi.SelectedIndex == 3)
                btnIzmeni.Visible = false;
            dataGridView1.DataSource = DTOManangerOpstineUOblasti.VratiOpstineUOblastiPrikaz(IdOblasti);
            
            this.postaviImenaKolonaOpstineUOblasti();
        }

        private void prikaziHranilista()
        {
            dataGridView1.DataSource = DTOmanangerHraniliste.VratiHranilistaView(this.IdOblasti);
            this.postaviImenaKolonaHraniliste();
        }

        private void klikDodaj()
        {
            switch (cmbIzaberi.SelectedIndex)
            {
                case 0:
                    this.DodajRadnika();
                    break;
                case 1:
                    this.DodajBiljku();
                    break;
                case 2:
                    this.DodajZivotinju();
                    break;
                case 3:
                    this.DodajOpstineUOblasti();
                    break;
                case 4:
                    this.DodajHraniliste();
                    break;
            }
        }
        
        private void DodajRadnika()
        {            
            var frm = new DodajRadnika(this.IdOblasti,this.TipZastite);
            
            DialogResult dlg = frm.ShowDialog();

            if (dlg == System.Windows.Forms.DialogResult.OK)
                this.prikaziPodatke();
        }

        private void DodajBiljku()
        {
            var frm = new DodajBiljku(this.IdOblasti);
            
            DialogResult dlg = frm.ShowDialog();

            if (dlg == System.Windows.Forms.DialogResult.OK)
                this.prikaziPodatke();
        }

        private void DodajZivotinju()
        {
            var frm = new DodajZivotinju(this.IdOblasti);
            DialogResult dlg = frm.ShowDialog();

            if (dlg == System.Windows.Forms.DialogResult.OK)
                this.prikaziPodatke();
        }

        private void DodajOpstineUOblasti()
        {
            var frm = new DodajOpstineUOblasti(this.IdOblasti);
            //frm.Show();
            DialogResult dlg = frm.ShowDialog();

            if (dlg == System.Windows.Forms.DialogResult.OK)
                this.prikaziPodatke();
        }

        private void DodajHraniliste()
        {
            var frm = new DodajHraniliste(this.IdOblasti);
            DialogResult dlg = frm.ShowDialog();

            if (dlg == System.Windows.Forms.DialogResult.OK)
                this.prikaziPodatke();

        }
        private void klikIzmeni()
        {
            switch (cmbIzaberi.SelectedIndex)
            {
                case 0:
                    this.IzmeniRadnika();
                    break;
                case 1:
                    this.IzmeniBiljku();
                    break;
                case 2:
                    this.IzmeniZivotinju();
                    break;

                case 4:
                    this.IzmeniHraniliste();
                    break;
            }
        }

        private void IzmeniRadnika()
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            int indeks = dataGridView1.SelectedRows[0].Index;
            var frm = new DodajRadnika(this.IdOblasti,this.TipZastite,Int32.Parse(dataGridView1[0,indeks].Value.ToString()));
            DialogResult dlg = frm.ShowDialog();

            if (dlg == System.Windows.Forms.DialogResult.OK)
                this.prikaziPodatke();
        }

        private void IzmeniBiljku()
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            int indeks = dataGridView1.SelectedRows[0].Index;
            var frm = new DodajBiljku(this.IdOblasti, Int32.Parse(dataGridView1[0, indeks].Value.ToString()), dataGridView1[3, indeks].Value.ToString());
      
            DialogResult dlg = frm.ShowDialog();

            if (dlg == System.Windows.Forms.DialogResult.OK)
                this.prikaziPodatke();
        }

        private void IzmeniZivotinju()
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            int indeks = dataGridView1.SelectedRows[0].Index;
            var frm = new DodajZivotinju(this.IdOblasti, Int32.Parse(dataGridView1[0, indeks].Value.ToString()), Int32.Parse(dataGridView1[4, indeks].Value.ToString()));
    
            DialogResult dlg = frm.ShowDialog();

            if (dlg == System.Windows.Forms.DialogResult.OK)
                this.prikaziPodatke();
        }



        private void IzmeniHraniliste()
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            int indeks = dataGridView1.SelectedRows[0].Index;

            var frm = new DodajHraniliste(this.IdOblasti, Int32.Parse(dataGridView1[0, indeks].Value.ToString()));

            DialogResult dlg = frm.ShowDialog();

            if (dlg == System.Windows.Forms.DialogResult.OK)
                this.prikaziPodatke();

        }
        private void klikObrisi()
        {
            switch (cmbIzaberi.SelectedIndex)
            {
                case 0:
                    this.ObrisiRadnika();
                    break;
                case 1:
                    this.ObrisiBiljku();
                    break;
                case 2:
                    this.ObrisiZivotinju();
                    break;
                case 3:
                    this.ObrisiOpstineUOblasti();
                    break;
                case 4:
                    this.ObrisiHraniliste();
                    break;
            }

        }

        private void ObrisiRadnika()
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            int indeks = dataGridView1.SelectedRows[0].Index;
            DTOManangerRadnik.ObrisiRadnika(Int32.Parse(dataGridView1[0, indeks].Value.ToString()));
            this.prikaziPodatke();
        }

        private void ObrisiBiljku()
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            int indeks = dataGridView1.SelectedRows[0].Index;
            DTOManangerBiljka.ObrisiBiljku(Int32.Parse(dataGridView1[0, indeks].Value.ToString()));
            this.prikaziPodatke();
        }

        private void ObrisiZivotinju()
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            int indeks = dataGridView1.SelectedRows[0].Index;
            DTOManangerZivotinja.ObrisiZivotinju(Int32.Parse(dataGridView1[0, indeks].Value.ToString()));
            this.prikaziPodatke();
        }

        private void ObrisiOpstineUOblasti()
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            int indeks = dataGridView1.SelectedRows[0].Index;
            DTOManangerOpstineUOblasti.ObrisiOpstineUOblasti(Int32.Parse(dataGridView1[0, indeks].Value.ToString()));
            this.prikaziPodatke();
        }

        private void ObrisiHraniliste()
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            int indeks = dataGridView1.SelectedRows[0].Index;
            DTOmanangerHraniliste.ObrisiHraniliste(Int32.Parse(dataGridView1[0, indeks].Value.ToString()));
            this.prikaziPodatke();
        }

        private void OstaleInformacije_Load(object sender, EventArgs e)
        {
            this.popuniPolja();
            
        }

        private void CmbIzaberi_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.prikaziPodatke();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.klikDodaj();
        }

        private void BtnIzmeni_Click(object sender, EventArgs e)
        {
            this.klikIzmeni();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.klikObrisi();
        }
    }
}
