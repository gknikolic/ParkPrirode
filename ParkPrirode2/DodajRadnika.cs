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
    public partial class DodajRadnika : Form
    {
        int IdOblasti { get; set; }
        int IdRadnika { get; set; }
        string TipOblasti { get; set; }// tip oblasti zato sto stalne radnike imamo samo u oblastima sa stalnom zastitom

        public DodajRadnika()
        {
            InitializeComponent();
        }

        public DodajRadnika(int idOblasti,string tipOblasti)
        {
            InitializeComponent();
            this.IdOblasti = idOblasti;
            this.TipOblasti = tipOblasti;
            this.IdRadnika = 0;

        }

        public DodajRadnika(int idOblasti, string tipOblasti,int idRadnika)
        {
            InitializeComponent();
            this.IdOblasti = idOblasti;
            this.TipOblasti = tipOblasti;
            this.IdRadnika = idRadnika;

        }



        private void ucitavanjeForme()
        {
            if (this.TipOblasti != "Stalna zastita")
            {
                tbxBrLicneKarte.Visible = false;
                tbxBrRadneKnjizice.Visible = false;
                tbxMestoIzdavanja.Visible = false;
                lblTipRadnika.Text = "Volonter";
                lbl1.Visible = false;
                lbl2.Visible = false;
                lbl3.Visible = false;
                pcbWorker.Image = ParkPrirode2.Properties.Resources.volonter;
            }
            else
            {
                pcbWorker.Image = ParkPrirode2.Properties.Resources.worker;
                lblTipRadnika.Text = "Stalni radnik";
            }
            if (IdRadnika != 0)
                this.ucitajKontrole();
            

        }
        private void ucitajKontrole()
        {
           if(this.TipOblasti=="Stalna zastita")
            {
                StalniRadnikBasic a = DTOManangerRadnik.VratiStalnogRadnikaBasic(this.IdRadnika);
                tbxMBR.Text = a.MBR;
                tbxIme.Text = a.Ime;
                tbxPrezime.Text = a.Prezime;
                tbxAdresa.Text = a.Adresa;
                tbxBrLicneKarte.Text = a.BrLicneKarte;
                tbxBrRadneKnjizice.Text = a.BrRadneKnjizice.ToString();
                tbxMestoIzdavanja.Text = a.MestoIzdavanjaLicneKarte;
                pcbWorker.Image = ParkPrirode2.Properties.Resources.worker;
            }
           else
            {
                RadnikBasic a = DTOManangerRadnik.VratiRadnikaBasic(this.IdRadnika);
                tbxMBR.Text = a.MBR;
                tbxIme.Text = a.Ime;
                tbxPrezime.Text = a.Prezime;
                tbxAdresa.Text = a.Adresa;
                pcbWorker.Image = ParkPrirode2.Properties.Resources.volonter;
            }
        }


        private void DodavanjeRadnika()
        {
            if(this.TipOblasti=="Stalna zastita")
            {
                StalniRadnikBasic a = new StalniRadnikBasic()
                {
                    MBR = tbxMBR.Text,
                    Ime = tbxIme.Text,
                    Prezime = tbxPrezime.Text,
                    Adresa = tbxAdresa.Text,
                    BrLicneKarte = tbxBrLicneKarte.Text,
                    BrRadneKnjizice = Int32.Parse(tbxBrRadneKnjizice.Text),
                    MestoIzdavanjaLicneKarte = tbxMestoIzdavanja.Text
                };
                DTOManangerRadnik.SacuvajStalnogRadnika(a, this.IdOblasti);
            }
            else
            {
                RadnikBasic a = new RadnikBasic()
                {
                    MBR = tbxMBR.Text,
                    Ime = tbxIme.Text,
                    Prezime = tbxPrezime.Text,
                    Adresa = tbxAdresa.Text
                };
                DTOManangerRadnik.SacuvajRadnika(a,this.IdOblasti);
            }
        }

        private void AzuriranjeRadnika()
        {
            if (this.TipOblasti == "Stalna zastita")
            {
                StalniRadnikBasic a = new StalniRadnikBasic()
                {
                    Id=this.IdRadnika,
                    MBR = tbxMBR.Text,
                    Ime = tbxIme.Text,
                    Prezime = tbxPrezime.Text,
                    Adresa = tbxAdresa.Text,
                    BrLicneKarte = tbxBrLicneKarte.Text,
                    BrRadneKnjizice = Int32.Parse(tbxBrRadneKnjizice.Text),
                    MestoIzdavanjaLicneKarte = tbxMestoIzdavanja.Text
                };
                DTOManangerRadnik.AzurirajStalnogRadnika(a);
            }
            else
            {
                RadnikBasic a = new RadnikBasic()
                {
                    Id=this.IdRadnika,
                    MBR = tbxMBR.Text,
                    Ime = tbxIme.Text,
                    Prezime = tbxPrezime.Text,
                    Adresa = tbxAdresa.Text
                };
                DTOManangerRadnik.AzurirajRadnika(a);
            }
        }


        private void errorVolonter()
        {
            if (tbxMBR.TextLength < 13)
                epMBR.SetError(tbxMBR, "Minimalno 13 cifara!");
            else
                epMBR.Clear();
            if (String.IsNullOrEmpty(tbxIme.Text))
                epIme.SetError(tbxIme, "Ovo polje ne sme biti prazno!");
            else
                epIme.Clear();

            if (String.IsNullOrEmpty(tbxPrezime.Text))
                epPrezime.SetError(tbxPrezime, "Ovo polje ne sme biti prazno!");
            else
                epPrezime.Clear();
        }

        private void errorStalniRadnik()
        {
            if (tbxMBR.TextLength < 13)
                epMBR.SetError(tbxMBR, "Minimalno 13 cifara!");
            else
                epMBR.Clear();

            if (tbxBrLicneKarte.TextLength < 9)
                epBrLicneKarte.SetError(tbxBrLicneKarte, "Minimalno 9 cifara!");
            else
                epBrLicneKarte.Clear();

            if (tbxBrRadneKnjizice.TextLength < 4)
                epBrRadneKnjziice.SetError(tbxBrRadneKnjizice, "Minimalno 5 cifara!");
            else
                epBrRadneKnjziice.Clear();

            if (String.IsNullOrEmpty(tbxIme.Text))
                epIme.SetError(tbxIme, "Ovo polje ne sme biti prazno!");
            else
                epIme.Clear();

            if (String.IsNullOrEmpty(tbxPrezime.Text))
                epPrezime.SetError(tbxPrezime, "Ovo polje ne sme biti prazno!");
            else
                epPrezime.Clear();
        }

        private void ErrorProvider()
        {
            if (this.TipOblasti == "Stalna zastita")
                errorStalniRadnik();
            else
                errorVolonter();
            
        }

        private bool validacijaVolonter()
        {
            if (epMBR.GetError(tbxMBR) != "" ||                          
                            epIme.GetError(tbxIme) != "" ||
                            epPrezime.GetError(tbxPrezime) != "")
                return false;
            else
                return true;
        }

        private bool validacijaStalniRadnik()
        {
            if (epMBR.GetError(tbxMBR) != "" ||
                            epBrLicneKarte.GetError(tbxBrLicneKarte) != "" ||
                            epBrRadneKnjziice.GetError(tbxBrRadneKnjizice) != "" ||
                            epIme.GetError(tbxIme) != "" ||
                            epPrezime.GetError(tbxPrezime) != "")
                return false;
            else
                return true;
        }

        private bool ValidacijaKontrola()
        {
            if (this.TipOblasti == "Stalna zastita")
                return this.validacijaStalniRadnik();
            else
                return this.validacijaVolonter();
        }
        private void klikOk()
        {
            if (this.ValidacijaKontrola())
            {

                if (this.IdRadnika == 0)
                    this.DodavanjeRadnika();
                else
                    this.AzuriranjeRadnika();

                this.Close();
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }

        }

        private void DodajRadnika_Load(object sender, EventArgs e)
        {
            this.ucitavanjeForme();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.ErrorProvider();
            this.klikOk();
        }
        #region KeyPressEvent
        private void TbxMBR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void TbxIme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void TbxPrezime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void TbxAdresa_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void TbxBrLicneKarte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void TbxMestoIzdavanja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void TbxBrRadneKnjizice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        #endregion
        #region LeaveEvent
        private void TbxIme_Leave(object sender, EventArgs e)
        {
            tbxIme.Text = tbxIme.Text.PostaviPrvoVelikoSlovo();
        }

        private void TbxPrezime_Leave(object sender, EventArgs e)
        {
            tbxPrezime.Text = tbxPrezime.Text.PostaviPrvoVelikoSlovo();
        }

        private void TbxAdresa_Leave(object sender, EventArgs e)
        {
            tbxAdresa.Text = tbxAdresa.Text.PostaviPrvoVelikoSlovo();
        }

        private void TbxMestoIzdavanja_Leave(object sender, EventArgs e)
        {
            tbxMestoIzdavanja.Text = tbxMestoIzdavanja.Text.PostaviPrvoVelikoSlovo();
        }
        #endregion
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
