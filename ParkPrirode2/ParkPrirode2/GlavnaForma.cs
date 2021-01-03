using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkPrirode2.DTOManangers;

namespace ParkPrirode2
{
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }


        #region MetodeOblasti

        private void PrikaziOblasti()
        { 
            if (chbStalnazastita.Checked)
                dataGridView1.DataSource = DTOManangerOblast.VratiOblastiSaStalnomZastitom();
            else
                dataGridView1.DataSource = DTOManangerOblast.VratiSveOblasti().ToList();
        }

        private void postaviNaziveKolona()
        {
            dataGridView1.Columns[0].HeaderText = "ID oblasti";
            dataGridView1.Columns[1].HeaderText = "Naziv oblasti";
            dataGridView1.Columns[2].HeaderText = "Povrsina";
            dataGridView1.Columns[3].HeaderText = "Tip zastite";
            dataGridView1.Columns[4].HeaderText = "Broj radnika u oblasti";
            dataGridView1.Columns[5].HeaderText = "Broj zivotinja";
            dataGridView1.Columns[6].HeaderText = "Broj biljaka";

        }

         private void dodajOblast()
         {            
             var frm = new AddOblast();
             //frm.Show();
             DialogResult dlg = frm.ShowDialog();

             if (dlg == System.Windows.Forms.DialogResult.OK)
                PrikaziOblasti();
         }

         private void ObrisiOblast()
         {
             if (dataGridView1.SelectedRows.Count == 0)
                 return;

             int indeks = dataGridView1.SelectedRows[0].Index;

             int povratnaVrednost=DTOManangerOblast.ObrisiOblast(Int32.Parse(dataGridView1[0,indeks].Value.ToString()));
             if(povratnaVrednost==2)
             {
                 MessageBox.Show("Doslo je do greske");
             }
             else if(povratnaVrednost==1)
             {
                 MessageBox.Show("Uspesno ste obrisali oblast");
             }
             else if(povratnaVrednost==0)
             {
                 MessageBox.Show("Neko je u medjuvremenu obrisao oblast");
             }
             PrikaziOblasti();
         }

        private void IzmeniOblast()
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            int indeks = dataGridView1.SelectedRows[0].Index;
            var frm = new AddOblast(Int32.Parse(dataGridView1[0, indeks].Value.ToString()));
            //frm.Show();
            DialogResult dlg = frm.ShowDialog();

            if (dlg == System.Windows.Forms.DialogResult.OK)
                PrikaziOblasti();

        }

        private void prikaziFormuSaOstalimInformacijama()
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            int indeks = dataGridView1.SelectedRows[0].Index;
            var frm = new OstaleInformacije(Int32.Parse(dataGridView1[0, indeks].Value.ToString()),dataGridView1[3,indeks].Value.ToString());
            //frm.Show();
            DialogResult dlg = frm.ShowDialog();

            if (dlg == System.Windows.Forms.DialogResult.OK)
                PrikaziOblasti();
        }

        #endregion




        #region HranilistaFunkcije

      

        private void postaviImenaKolonaHraniliste()
        {
            dataGridView1.Columns[0].HeaderText = "Broj hranilista";
            dataGridView1.Columns[1].HeaderText = "Pocetni mesec";
            dataGridView1.Columns[2].HeaderText = "Krajnji mesec";
            dataGridView1.Columns[3].HeaderText = "Pripada oblasti";
        }

        

        private void chbPrikaziAktivnaPromena()
        {
            if (chbPrikaziAktivna.Checked)
                this.prikaziAktivnaHranilista();
            else
                this.prikaziSvaHranilista();
            this.postaviImenaKolonaHraniliste();
        }


        private void prikaziAktivnaHranilista()
        {
            dataGridView2.DataSource = DTOmanangerHraniliste.PrikaziAktivnaHranilista(); //odradjeno je
        }

        private void prikaziSvaHranilista()
        {
            dataGridView2.DataSource = DTOmanangerHraniliste.VratiSvaHranilistaView();
        }
        

        private void klikPrikaziZivotinje()
        {
            if (!chbPrikaziPtice.Checked && !chbPrikaziPre.Checked)
                this.prikaziZivotinje(0);//prikaziSveZivotinje
            else if (chbPrikaziPtice.Checked && !chbPrikaziPre.Checked)
                this.prikaziZivotinje(1);//prikaziFiltriranePtice
            else if (!chbPrikaziPtice.Checked && chbPrikaziPre.Checked)
                this.prikaziZivotinje(2);//prikaziFiltriraneSveZivotinjeDatum
            else if (chbPrikaziPtice.Checked && chbPrikaziPre.Checked)
                this.prikaziZivotinje(3);//prikaziFiltriranePticeDatum



        }


        private void prikaziZivotinje(int kodOperacije)
        {
            if (dataGridView2.SelectedRows.Count == 0)
                return;
            int indeks = dataGridView2.SelectedRows[0].Index;

            Prikaz frm = null;
            if(chbPrikaziPre.Checked == true)
                frm = new Prikaz(Int32.Parse(dataGridView2[0, indeks].Value.ToString()), "Zivotinja", kodOperacije, dtpDatum.Value);

            else
                frm = new Prikaz(Int32.Parse(dataGridView2[0, indeks].Value.ToString()),"Zivotinja",kodOperacije);
            
            DialogResult dlg = frm.ShowDialog();
                       
                
        }

        private void klikPoveziZivotinju()
        {
            if (dataGridView2.SelectedRows.Count == 0)
                return;
            int indeks = dataGridView2.SelectedRows[0].Index;
            var frm = new Prikaz(Int32.Parse(dataGridView2[0, indeks].Value.ToString()), "Zivotinje");
            DialogResult dlg = frm.ShowDialog();
                
        }


        #endregion



        #region DogadjajiOblasti

        

        private void TabPage1_Enter(object sender, EventArgs e)
        {
            this.PrikaziOblasti();

            this.postaviNaziveKolona();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.dodajOblast();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.ObrisiOblast();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = DTOManangerOblast.VratiOblastiSaStalnomZastitom().ToList() ;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.IzmeniOblast();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.prikaziFormuSaOstalimInformacijama();
        }

        #endregion




        #region DogadjajiHranilista
        private void TabPage5_Enter(object sender, EventArgs e)
        {
            dtpDatum.Enabled = false;
            this.prikaziSvaHranilista();
            this.postaviImenaKolonaHraniliste();
        }

        private void BtnPrikazi_Click(object sender, EventArgs e)
        {
            this.klikPrikaziZivotinje();
        }

        private void ChbPrikaziAktivna_CheckedChanged(object sender, EventArgs e)
        {
            this.chbPrikaziAktivnaPromena();
        }

        private void ChbPrikaziPtice_CheckedChanged(object sender, EventArgs e)
        {
           // this.chbPrikaziPticePromena();
        }

        private void ChbPrikaziPre_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPrikaziPre.Checked)
                dtpDatum.Enabled = true;
            else
                dtpDatum.Enabled = false;
        }

        private void Button6_Click(object sender, EventArgs e)
        {

            this.klikPoveziZivotinju();
        }


        #endregion

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ChbStalnazastita_CheckedChanged(object sender, EventArgs e)
        {
            this.PrikaziOblasti();
        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {
            this.PrikaziOblasti();

            this.postaviNaziveKolona();
        }
    }
}
