namespace ParkPrirode2
{
    partial class DodajBiljku
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajBiljku));
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxLatinskiNaziv = new System.Windows.Forms.TextBox();
            this.tbxLokalniNaziv = new System.Windows.Forms.TextBox();
            this.tbxBrojOdluke = new System.Windows.Forms.TextBox();
            this.chbPosebnaZastita = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pcbBiljka = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.epLatinskiNaziv = new System.Windows.Forms.ErrorProvider(this.components);
            this.epLokalniNaziv = new System.Windows.Forms.ErrorProvider(this.components);
            this.epBrojOdluke = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBiljka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLatinskiNaziv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLokalniNaziv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBrojOdluke)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(242, 193);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Latinski naziv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lokalni naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Broj odluke";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Datum postavljanja";
            // 
            // tbxLatinskiNaziv
            // 
            this.tbxLatinskiNaziv.Location = new System.Drawing.Point(122, 30);
            this.tbxLatinskiNaziv.MaxLength = 30;
            this.tbxLatinskiNaziv.Name = "tbxLatinskiNaziv";
            this.tbxLatinskiNaziv.Size = new System.Drawing.Size(122, 20);
            this.tbxLatinskiNaziv.TabIndex = 5;
            this.tbxLatinskiNaziv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxLatinskiNaziv_KeyPress);
            this.tbxLatinskiNaziv.Leave += new System.EventHandler(this.TbxLatinskiNaziv_Leave);
            // 
            // tbxLokalniNaziv
            // 
            this.tbxLokalniNaziv.Location = new System.Drawing.Point(122, 65);
            this.tbxLokalniNaziv.MaxLength = 30;
            this.tbxLokalniNaziv.Name = "tbxLokalniNaziv";
            this.tbxLokalniNaziv.Size = new System.Drawing.Size(122, 20);
            this.tbxLokalniNaziv.TabIndex = 6;
            this.tbxLokalniNaziv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxLokalniNaziv_KeyPress);
            this.tbxLokalniNaziv.Leave += new System.EventHandler(this.TbxLokalniNaziv_Leave);
            // 
            // tbxBrojOdluke
            // 
            this.tbxBrojOdluke.Location = new System.Drawing.Point(122, 99);
            this.tbxBrojOdluke.MaxLength = 3;
            this.tbxBrojOdluke.Name = "tbxBrojOdluke";
            this.tbxBrojOdluke.Size = new System.Drawing.Size(122, 20);
            this.tbxBrojOdluke.TabIndex = 7;
            this.tbxBrojOdluke.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxBrojOdluke_KeyPress);
            // 
            // chbPosebnaZastita
            // 
            this.chbPosebnaZastita.AutoSize = true;
            this.chbPosebnaZastita.BackColor = System.Drawing.Color.Transparent;
            this.chbPosebnaZastita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPosebnaZastita.ForeColor = System.Drawing.Color.White;
            this.chbPosebnaZastita.Location = new System.Drawing.Point(279, 31);
            this.chbPosebnaZastita.Name = "chbPosebnaZastita";
            this.chbPosebnaZastita.Size = new System.Drawing.Size(133, 22);
            this.chbPosebnaZastita.TabIndex = 9;
            this.chbPosebnaZastita.Text = "Posebna zastita";
            this.chbPosebnaZastita.UseVisualStyleBackColor = false;
            this.chbPosebnaZastita.CheckedChanged += new System.EventHandler(this.ChbPosebnaZastita_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd:MM:yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(19, 174);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(122, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // pcbBiljka
            // 
            this.pcbBiljka.BackColor = System.Drawing.Color.Transparent;
            this.pcbBiljka.Location = new System.Drawing.Point(297, 69);
            this.pcbBiljka.Name = "pcbBiljka";
            this.pcbBiljka.Size = new System.Drawing.Size(101, 96);
            this.pcbBiljka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBiljka.TabIndex = 12;
            this.pcbBiljka.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(323, 193);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // epLatinskiNaziv
            // 
            this.epLatinskiNaziv.ContainerControl = this;
            // 
            // epLokalniNaziv
            // 
            this.epLokalniNaziv.ContainerControl = this;
            // 
            // epBrojOdluke
            // 
            this.epBrojOdluke.ContainerControl = this;
            // 
            // DodajBiljku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ParkPrirode2.Properties.Resources.biljkaslika;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 232);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pcbBiljka);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.chbPosebnaZastita);
            this.Controls.Add(this.tbxBrojOdluke);
            this.Controls.Add(this.tbxLokalniNaziv);
            this.Controls.Add(this.tbxLatinskiNaziv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajBiljku";
            this.Text = "DodajBiljku";
            this.Load += new System.EventHandler(this.DodajBiljku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBiljka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLatinskiNaziv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLokalniNaziv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBrojOdluke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxLatinskiNaziv;
        private System.Windows.Forms.TextBox tbxLokalniNaziv;
        private System.Windows.Forms.TextBox tbxBrojOdluke;
        private System.Windows.Forms.CheckBox chbPosebnaZastita;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pcbBiljka;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider epLatinskiNaziv;
        private System.Windows.Forms.ErrorProvider epLokalniNaziv;
        private System.Windows.Forms.ErrorProvider epBrojOdluke;
    }
}