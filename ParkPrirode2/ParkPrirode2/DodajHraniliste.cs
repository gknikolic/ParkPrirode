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
    public partial class DodajHraniliste : Form
    {

        int IdOblasti { get; set; }
        int BrojHranilista { get; set; }
        public DodajHraniliste()
        {
            InitializeComponent();
        }

        public DodajHraniliste(int idOblasti)
        {
            InitializeComponent();
            this.IdOblasti = idOblasti;
        }

        public DodajHraniliste(int idOblasti,int brojHranilista)
        {
            InitializeComponent();
            this.IdOblasti = idOblasti;
            this.BrojHranilista = brojHranilista;
        }

        private void ucitavanjeFormu()
        {
            if(this.BrojHranilista!=0)
            {
                HranilisteBasic a = DTOmanangerHraniliste.VratiHranilisteBasic(this.BrojHranilista);
                lblBroj.Text = a.Broj.ToString();
                tbxKrajnjiMesec.Text = a.KrajnjiMesec.ToString();
                tbxPocetniMesec.Text = a.PocetniMesec.ToString(); ;
            }
            else
            {
                lblBroj.Visible = false;
            }
        }

        private void dodajHraniliste()
        {
            HranilisteBasic h = new HranilisteBasic()
            {
                PocetniMesec = Int32.Parse(tbxPocetniMesec.Text),
                KrajnjiMesec = Int32.Parse(tbxKrajnjiMesec.Text),
                Broj = this.BrojHranilista
            };
            DTOmanangerHraniliste.SacuvahHraniliste(h, this.IdOblasti);
        }

        private void azurirajHraniliste()
        {
            HranilisteBasic h = new HranilisteBasic
            {
                PocetniMesec = Int32.Parse(tbxPocetniMesec.Text),
                KrajnjiMesec = Int32.Parse(tbxKrajnjiMesec.Text),
                Broj = this.BrojHranilista
            };
            DTOmanangerHraniliste.AzurirajHraniliste(h);
        }

        private bool Validacija()
        {
            return true;
        }
        private void klikOk()
        {
            if(this.Validacija())
            {
                if (this.BrojHranilista == 0)
                    this.dodajHraniliste();
                else
                    this.azurirajHraniliste();
                this.Close();
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private void DodajHraniliste_Load(object sender, EventArgs e)
        {
            this.ucitavanjeFormu();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.klikOk();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
