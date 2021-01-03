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
    public partial class DodajZivotinju : Form
    {

        int IdOblasti { get; set; }
        int IdZivotinje { get; set; }
        int PticaSelicaFleg { get; set; }
        public DodajZivotinju()
        {
            InitializeComponent();
        }
        public DodajZivotinju(int idOblasti)
        {
            InitializeComponent();
            this.IdOblasti = idOblasti;
            this.IdZivotinje = 0;
        }
        public DodajZivotinju(int idOblasti, int idZivotinje)
        {
            InitializeComponent();
            this.IdOblasti = idOblasti;
            this.IdZivotinje = idZivotinje;
        }
        public DodajZivotinju(int idOblasti, int idZivotinje, int Fleg)
        {
            InitializeComponent();
            this.IdOblasti = idOblasti;
            this.IdZivotinje = idZivotinje;
            this.PticaSelicaFleg = Fleg;
        }
        private void ucitavanjeForme()
        {

            if (IdZivotinje != 0)
                this.ucitajKontrole();
            else
                pcbPhoto.Image = ParkPrirode2.Properties.Resources.animal;
        }
        private void ucitajKontrole()
        {
            if (this.PticaSelicaFleg == 0)
            {
                ZivotinjaBasic z = DTOManangerZivotinja.VratiZivotinjuBasic(this.IdZivotinje);
                tbxLatinskiNaziv.Text = z.LatinskiNaziv;
                tbxLokalniNaziv.Text = z.LokalniNaziv;
                tbxSBP.Text = z.SBP.ToString();
                pcbPhoto.Image = ParkPrirode2.Properties.Resources.animal; 
                chbFleg.Enabled = false;
            }
            else
            {
                ZivotinjaBasic z = DTOManangerZivotinja.VratiZivotinjuBasic(this.IdZivotinje);
                tbxLatinskiNaziv.Text = z.LatinskiNaziv;
                tbxLokalniNaziv.Text = z.LokalniNaziv;
                tbxSBP.Text = z.SBP.ToString();
                pcbPhoto.Image = ParkPrirode2.Properties.Resources.bird;
                chbFleg.Checked = true;
                chbFleg.Enabled = false;

            }
        }
        private void DodavanjeZivotinje()
        {
            if (!chbFleg.Checked || chbFleg.Enabled == false)
            {
                ZivotinjaBasic z = new ZivotinjaBasic()
                {
                    LatinskiNaziv = tbxLatinskiNaziv.Text,
                    LokalniNaziv = tbxLokalniNaziv.Text,
                    SBP = int.Parse(tbxSBP.Text),
                    PticaSelicaFleg = 0,
                };
                DTOManangerZivotinja.SacuvajZivotinju(z, this.IdOblasti);
            }
            else
            {
                ZivotinjaBasic a = new ZivotinjaBasic()
                {
                    LatinskiNaziv = tbxLatinskiNaziv.Text,
                    LokalniNaziv = tbxLokalniNaziv.Text,
                    SBP = int.Parse(tbxSBP.Text),
                    PticaSelicaFleg = 1,
                };
                DTOManangerZivotinja.SacuvajPticuSelicu(a, this.IdOblasti);
            }
        }
        private void AzuriranjeZivotinje()
        {
            if (!chbFleg.Checked)
            {
                ZivotinjaBasic z = new ZivotinjaBasic()
                {
                    Id = this.IdZivotinje,
                    LatinskiNaziv = tbxLatinskiNaziv.Text,
                    LokalniNaziv = tbxLokalniNaziv.Text,
                    SBP = int.Parse(tbxSBP.Text),
                    PticaSelicaFleg = 0,
                };
                DTOManangerZivotinja.AzurirajZivotinju(z);
            }
            else
            {
                ZivotinjaBasic z = new ZivotinjaBasic()
                {
                    Id = this.IdZivotinje,
                    LatinskiNaziv = tbxLatinskiNaziv.Text,
                    LokalniNaziv = tbxLokalniNaziv.Text,
                    SBP = int.Parse(tbxSBP.Text),
                    PticaSelicaFleg = 1,
                };
                DTOManangerZivotinja.AzurirajPticuSelicu(z);
            }
        }

        private void ErrorProvider()
        {
            if (String.IsNullOrEmpty(tbxLatinskiNaziv.Text))
                epLatinskiNaziv.SetError(tbxLatinskiNaziv, "Ovo polje ne sme biti prazno");
            else
                epLatinskiNaziv.Clear();
            if (String.IsNullOrEmpty(tbxLokalniNaziv.Text))
                epLokalniNaziv.SetError(tbxLokalniNaziv, "Ovo polje ne sme biti prazno");
            else
                epLokalniNaziv.Clear();
            if (tbxSBP.TextLength < 5)
                epSBP.SetError(tbxSBP, "Mora imati 5 cifari!");
            else
                epSBP.Clear();
        }


        private bool ValidacijaKontrola()
        {
            if (epSBP.GetError(tbxSBP) != "" ||
               epLatinskiNaziv.GetError(tbxLatinskiNaziv) != "" ||
               epLokalniNaziv.GetError(tbxLokalniNaziv) != "")
                return false;
            else
                return true;
        }
        private void clickOk()
        {
            if (this.ValidacijaKontrola())
            {

                if (this.IdZivotinje == 0)
                    this.DodavanjeZivotinje();
                else
                    this.AzuriranjeZivotinje();

                this.Close();
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
        private void DodajZivotinju_Load(object sender, EventArgs e)
        {
            this.ucitavanjeForme();
        }

        private void PcbPhoto_Click(object sender, EventArgs e)
        {

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.ErrorProvider();
            this.clickOk();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChbFleg_CheckedChanged(object sender, EventArgs e)
        {
            if (chbFleg.Checked)
                pcbPhoto.Image = ParkPrirode2.Properties.Resources.bird;
            else
                pcbPhoto.Image = ParkPrirode2.Properties.Resources.animal;
        }
        #region KeyPressEvent
        private void TbxLatinskiNaziv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void TbxLokalniNaziv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void TbxSBP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        #endregion
        #region LeaveEvent
        private void TbxLatinskiNaziv_Leave(object sender, EventArgs e)
        {
            tbxLatinskiNaziv.Text = tbxLatinskiNaziv.Text.PostaviPrvoVelikoSlovo();
        }

        private void TbxLokalniNaziv_Leave(object sender, EventArgs e)
        {
            tbxLokalniNaziv.Text = tbxLokalniNaziv.Text.PostaviPrvoVelikoSlovo();
        }
        #endregion
    }
}
