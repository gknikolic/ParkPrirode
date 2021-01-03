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
    public partial class Prikaz : Form
    {
        int IdRoditelja { get; set; }
        string ElementZaPrikaz { get; set; }// da li je zivotinja ili sta vec

        int KodOperacije { get; set; } // da bi znali kako da prikazemo odnosno sa kojim ogranicenjima

        DateTime Datum { get; set; }

        public Prikaz()
        {
            InitializeComponent();
        }
        public Prikaz(int id, string el, int kod)
        {
            InitializeComponent();
            this.IdRoditelja = id;
            this.KodOperacije = kod;
            this.ElementZaPrikaz = el;
        }

        public Prikaz(int id, string el, int kod, DateTime a)
        {
            InitializeComponent();
            this.IdRoditelja = id;
            this.KodOperacije = kod;
            this.ElementZaPrikaz = el;
            this.Datum = a;
        }

        public Prikaz(int id, string el)
        {
            InitializeComponent();
            this.IdRoditelja = id;
            this.KodOperacije = -1;
            this.ElementZaPrikaz = el;
        }

        private void postaviImenaKolonaZivotinja()
        {
            dataGridView1.Columns[0].HeaderText = "ID zivotinje";
            dataGridView1.Columns[1].HeaderText = "Latinski naziv";
            dataGridView1.Columns[2].HeaderText = "Lokalni naziv";
            dataGridView1.Columns[3].HeaderText = "SBP";
            dataGridView1.Columns[4].HeaderText = "Zivotinja/Ptica (1/0)";

        }

        private void prikazi()
        {
            if (this.KodOperacije == -1)
                dataGridView1.DataSource = DTOManangerZivotinja.VratiSveZivotinje();//
            else
            {
                if (this.ElementZaPrikaz == "Zivotinja")
                {
                    if (this.KodOperacije == 0)
                        dataGridView1.DataSource = DTOManangerZivotinja.VratiZivotinjeNaHranilistuPrikaz(this.IdRoditelja);
                    else if (this.KodOperacije == 1)
                        dataGridView1.DataSource = DTOManangerZivotinja.VratiPticeNaHranilistuPrikaz(this.IdRoditelja);
                    else if (this.KodOperacije == 2)
                        dataGridView1.DataSource = DTOManangerZivotinja.VratiZivotinjeNaHranilistuPrimecenaNakonPrikaz(this.IdRoditelja, this.Datum);
                    else if (this.KodOperacije == 3)
                        dataGridView1.DataSource = DTOManangerZivotinja.VratiPticeNaHranilistuPrimecenaNakonPrikaz(this.IdRoditelja, this.Datum);

                }
            }
            this.postaviImenaKolonaZivotinja();
        }

        
        private void klikNaDugmeOk()
        {
            if (dataGridView1.SelectedRows.Count == 0)
                MessageBox.Show("Izaberi zivotinju");
            else
            {
                int indeks = dataGridView1.SelectedRows[0].Index;
                DTOmanangerHraniliste.PostaviZivotinjaPrimecena(Int32.Parse(dataGridView1[0, indeks].Value.ToString()), this.IdRoditelja);

            }
        }


        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.klikNaDugmeOk();
            this.Close();
        }

        private void Prikaz_Load(object sender, EventArgs e)
        {
            if (this.ElementZaPrikaz == "Zivotinja" && this.KodOperacije > -1)
            {
                btnOk.Visible = false;
            }
            this.prikazi();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
