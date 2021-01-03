using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParkPrirode2.Entiteti;
using ParkPrirode2.DTO;
using ParkPrirode2.DTOManangers;
using NHibernate;
using NHibernate.Linq;

namespace ParkPrirode2
{
    public partial class DodajOpstineUOblasti : Form
    {
        int IdOblasti { get; set; }
        int IdOpstineUOblasti { get; set; }
        public DodajOpstineUOblasti()
        {
            InitializeComponent();
        }
        public DodajOpstineUOblasti(int idOblasti)
        {
            InitializeComponent();
            this.IdOblasti = idOblasti;
        }
        public DodajOpstineUOblasti(int idOblasti, int idOpstineUOBlasti)
        {
            InitializeComponent();
            this.IdOblasti = idOblasti;
            this.IdOpstineUOblasti = idOpstineUOBlasti;
        }
        private void DodavanjeOpstineUOblasti()
        {
            OpstineUOblastiView o = new OpstineUOblastiView()
            {
                NazivOpstine = tbxNazivOpstine.Text,
            };
            DTOManangerOpstineUOblasti.SacuvajOpstineUOblasti(o, this.IdOblasti);
        }

        private void ErrorProvider()
        {
            if (String.IsNullOrEmpty(tbxNazivOpstine.Text))
                epNazivOpstine.SetError(tbxNazivOpstine, "Ovo polje ne sme biti prazno!");
            else
                epNazivOpstine.Clear();
        }

        private bool ValidacijaKontrola()
        {
            if (epNazivOpstine.GetError(tbxNazivOpstine) != "")
                return false;
            else
                return true;
        }
        private void klikOk()
        {
            if (this.ValidacijaKontrola())
            {

                if (this.IdOpstineUOblasti == 0)
                    this.DodavanjeOpstineUOblasti();

                this.Close();
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
        private void BtnOK_Click(object sender, EventArgs e)
        {
            ErrorProvider();
            klikOk();
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void TbxNazivOpstine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void TbxNazivOpstine_Leave(object sender, EventArgs e)
        {
            tbxNazivOpstine.Text = tbxNazivOpstine.Text.PostaviPrvoVelikoSlovo();
        }

        private void DodajOpstineUOblasti_Load(object sender, EventArgs e)
        {

        }
    }
}
