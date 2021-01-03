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
    public partial class DodajBiljku : Form
    {

        int IdOblasti { get; set; }
        int IdBiljke { get; set; }
        bool PosebnaZastita { get; set; }// azuriranje
        public DodajBiljku()
        {
            InitializeComponent();
        }
        public DodajBiljku(int idOblasti)//dodavanje
        {
            InitializeComponent();
            this.IdOblasti = idOblasti;
            this.IdBiljke = 0;
        }
        public DodajBiljku(int idOblasti,int idBiljke,string posebnaZastita)// azuriranje
        {
            InitializeComponent();
            this.IdBiljke = idBiljke;
            this.IdOblasti = idOblasti;
            if (posebnaZastita == "Da")
                this.PosebnaZastita = true;
            else
                this.PosebnaZastita = false;
        }

        private void ucitajKontrole()
        {

            if (this.IdBiljke != 0)
            {

                if (PosebnaZastita)
                {
                    BiljkaPosebnaZastitaBasic b = DTOManangerBiljka.VratiBiljkaPosebnaZastitaBasic(this.IdBiljke);
                    tbxLatinskiNaziv.Text = b.LatinskiNaziv;
                    tbxLokalniNaziv.Text = b.LokalniNaziv;
                    tbxBrojOdluke.Text = b.BrojOdluke;
                    dateTimePicker1.Value = b.DatumPocetka;
                    chbPosebnaZastita.Checked = true;
                    pcbBiljka.Image = ParkPrirode2.Properties.Resources.biljkazastita;
                }
                else
                {
                    BiljkaBasic b = DTOManangerBiljka.VratiBiljkaBasic(this.IdBiljke);
                    tbxLatinskiNaziv.Text = b.LatinskiNaziv;
                    tbxLokalniNaziv.Text = b.LokalniNaziv;
                    chbPosebnaZastita.Checked = false;
                    this.IskljuciKontrole();
                    pcbBiljka.Image = ParkPrirode2.Properties.Resources.biljka;
                }
            }
            else
            {
                this.IskljuciKontrole();
            }

        }

        private void IskljuciKontrole()
        {
            tbxBrojOdluke.Visible = false;
            dateTimePicker1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            pcbBiljka.Image = ParkPrirode2.Properties.Resources.biljka;
        }


        private void UkljuciKontrole()
        {
            tbxBrojOdluke.Visible = true;
            dateTimePicker1.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            pcbBiljka.Image = ParkPrirode2.Properties.Resources.biljkazastita;
        }

        private void dodajBiljku()
        {
            BiljkaBasic b = new BiljkaBasic()
            {
                LatinskiNaziv = tbxLatinskiNaziv.Text,
                LokalniNaziv = tbxLokalniNaziv.Text
            };
            DTOManangerBiljka.DodajBiljku(b, this.IdOblasti);
        }

        private void dodajBiljkuPosebnaZastita()
        {
            BiljkaPosebnaZastitaBasic b = new BiljkaPosebnaZastitaBasic
            {
                
                LatinskiNaziv = tbxLatinskiNaziv.Text,
                LokalniNaziv = tbxLokalniNaziv.Text,
                BrojOdluke = tbxBrojOdluke.Text,
                DatumPocetka = dateTimePicker1.Value
            };
            DTOManangerBiljka.DodajBiljkuSaPosebnomZastitom(b, this.IdOblasti);
        }


        private void obrisiBiljku(int idBiljke)
        {
            DTOManangerBiljka.ObrisiBiljku(idBiljke);
        }

        private void AzurirajBiljku()
        {
            if(PosebnaZastita&&chbPosebnaZastita.Checked)
            {
                BiljkaPosebnaZastitaBasic b = new BiljkaPosebnaZastitaBasic()
                {
                    Id=this.IdBiljke,
                    LatinskiNaziv = tbxLatinskiNaziv.Text,
                    LokalniNaziv = tbxLokalniNaziv.Text,
                    BrojOdluke = tbxBrojOdluke.Text,
                    DatumPocetka = dateTimePicker1.Value
                };
                DTOManangerBiljka.AzurirajBiljkuPosebnaZastita(b);
            }
            else if(!PosebnaZastita&&!chbPosebnaZastita.Checked)
            {
                BiljkaBasic b = new BiljkaBasic()
                {
                    Id = this.IdBiljke,
                    LatinskiNaziv = tbxLatinskiNaziv.Text,
                    LokalniNaziv = tbxLokalniNaziv.Text
                };
                DTOManangerBiljka.AzurirajBiljku(b);
            }
            else if(PosebnaZastita&&!chbPosebnaZastita.Checked)
            {
                BiljkaBasic b = new BiljkaBasic()
                {
                    LatinskiNaziv = tbxLatinskiNaziv.Text,
                    LokalniNaziv = tbxLokalniNaziv.Text
                };
                DTOManangerBiljka.ObrisiBiljku(this.IdBiljke);
                DTOManangerBiljka.DodajBiljku(b,this.IdOblasti);
            }
            else if(!PosebnaZastita&&chbPosebnaZastita.Checked)
            {
                BiljkaPosebnaZastitaBasic b = new BiljkaPosebnaZastitaBasic()
                {
                    Id = this.IdBiljke,
                    LatinskiNaziv = tbxLatinskiNaziv.Text,
                    LokalniNaziv = tbxLokalniNaziv.Text,
                    BrojOdluke = tbxBrojOdluke.Text,
                    DatumPocetka = dateTimePicker1.Value
                };
                DTOManangerBiljka.ObrisiBiljku(this.IdBiljke);
                DTOManangerBiljka.DodajBiljkuSaPosebnomZastitom(b, this.IdOblasti);
            }
        }
        private void errorBiljka()
        {
            if (String.IsNullOrEmpty(tbxLatinskiNaziv.Text))
                epLatinskiNaziv.SetError(tbxLatinskiNaziv, "Ovo polje ne sme biti prazno!");
            else
                epLatinskiNaziv.Clear();
            if (String.IsNullOrEmpty(tbxLokalniNaziv.Text))
                epLokalniNaziv.SetError(tbxLokalniNaziv, "Ovo polje ne sme biti prazno!");
            else
                epLokalniNaziv.Clear();
        }
        private void errorBiljkaZastita()
        {
            if (String.IsNullOrEmpty(tbxLatinskiNaziv.Text))
                epLatinskiNaziv.SetError(tbxLatinskiNaziv, "Ovo polje ne sme biti prazno!");
            else
                epLatinskiNaziv.Clear();
            if (String.IsNullOrEmpty(tbxLokalniNaziv.Text))
                epLokalniNaziv.SetError(tbxLokalniNaziv, "Ovo polje ne sme biti prazno!");
            else
                epLokalniNaziv.Clear();
            if (tbxBrojOdluke.TextLength < 3 && String.IsNullOrEmpty(tbxBrojOdluke.Text))
                epBrojOdluke.SetError(tbxBrojOdluke, "Minimalno 3 cifre!");
            else
                epBrojOdluke.Clear();
        }
        private void ErrorProvider()
        {
            if (chbPosebnaZastita.Checked)
                errorBiljkaZastita();
            else
                errorBiljka();

        }
        private bool validacijaBiljka()
        {
            if (epLatinskiNaziv.GetError(tbxLatinskiNaziv) != "" ||
                epLokalniNaziv.GetError(tbxLokalniNaziv) != "")


                return false;
            else
                return true;
        }
        private bool validacijaBiljkaZastita()
        {
            if (epLatinskiNaziv.GetError(tbxLatinskiNaziv) != "" ||
                epLokalniNaziv.GetError(tbxLokalniNaziv) != "" ||
                epBrojOdluke.GetError(tbxBrojOdluke) != "")

                return false;
            else
                return true;
        }
        private bool ValidacijaKontrola()
        {
            if (chbPosebnaZastita.Checked)
                return this.validacijaBiljkaZastita();
            else
                return this.validacijaBiljka();
        }

        private void klikOk()
        {

            if(this.ValidacijaKontrola())
            {
                if (this.IdBiljke == 0)
                {
                    if (chbPosebnaZastita.Checked)
                        this.dodajBiljkuPosebnaZastita();
                    else
                        this.dodajBiljku();
                }
                else
                    this.AzurirajBiljku();
                this.Close();
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }

        }



        private void DodajBiljku_Load(object sender, EventArgs e)
        {
            this.ucitajKontrole();
        }

        private void ChbPosebnaZastita_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPosebnaZastita.Checked)
                this.UkljuciKontrole();
            else
                this.IskljuciKontrole();

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.ErrorProvider();
            this.klikOk();
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

        private void TbxBrojOdluke_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        #endregion
    }
}
