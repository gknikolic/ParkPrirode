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
    public partial class AddOblast : Form
    {
        int IdOblastUpdate { get; set; }
        public AddOblast()
        {
            InitializeComponent();
            this.IdOblastUpdate = 0;
            this.postaviKontrole();
        }
        public AddOblast(int id)
        {
            InitializeComponent();
            IdOblastUpdate = id;
            this.postaviKontrole();
            tbxIme.Enabled = false;
        }

        private void postaviKontrole()
        {
            if(IdOblastUpdate==0)
            {
                tbxId.Visible = false;
                lblId.Visible = false;
                cbxTipZastite.Location =new Point(341, 29);
                lblTip.Location = new Point(338, 9);
            }
            else
            {
                cbxTipZastite.Visible = false;
                lblTip.Visible = false;
                tbxId.Location = new Point(341, 29);
                lblId.Location = new Point(338, 9);
                OblastBasic o = DTOManangerOblast.VratiOblast(IdOblastUpdate);
                tbxId.Text = o.OblastId.ToString();
                tbxId.Enabled = false;
                tbxIme.Text = o.JedinstvenoIme;
                tbxPovrsina.Text = o.Povrsina.ToString();
            }
        }

        private void proslediPodatke()
        {
            if (this.IdOblastUpdate == 0)
                this.Dodaj();
            else
                this.Update();            

            
            

        }

        public void Dodaj()
        {
            OblastBasic o = new OblastBasic()
            {
                JedinstvenoIme = tbxIme.Text,
                Povrsina = int.Parse(tbxPovrsina.Text),
                TipZastite = cbxTipZastite.Text


            };
            int i = DTOManangerOblast.DodajOblast(o);
            if (i == 0)
                MessageBox.Show("Vec postoji oblast sa tim imenom");
            else if (i == 2)
                MessageBox.Show("Doslo je do greske");
            else
            {
                this.Close();
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }


        public void Update()
        {
            OblastBasic o = new OblastBasic()
            {
                JedinstvenoIme = tbxIme.Text,
                Povrsina = int.Parse(tbxPovrsina.Text),
                OblastId = IdOblastUpdate
            };

            int i = DTOManangerOblast.UpdateOblastBasic(o);
            if (i == 0)
                MessageBox.Show("Vec postoji oblast sa tim imenom");
            else if (i == 2)
                MessageBox.Show("Doslo je do greske");
            else
            {
                this.Close();
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private bool Validacija()
        {
            if (tbxIme.Text == "")
            {
                tbxIme.BackColor = Color.Red;
                MessageBox.Show("Popuni polje 'Unesi ime oblasti'");
                return false;
            }
            else if(tbxPovrsina.Text=="" || Int32.Parse(tbxPovrsina.Text) < 1)
            {
                tbxPovrsina.BackColor = Color.Red;
                MessageBox.Show("Polje Povrsina ne sme da ima negativnu vrednost ili da bude prazno");
                return false;

            }
            return true;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if(this.Validacija())
                this.proslediPodatke();
        }

        private void AddOblast_Load(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
