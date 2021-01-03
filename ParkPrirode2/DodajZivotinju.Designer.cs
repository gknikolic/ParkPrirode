namespace ParkPrirode2
{
    partial class DodajZivotinju
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajZivotinju));
            this.chbFleg = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.tbxSBP = new System.Windows.Forms.TextBox();
            this.tbxLokalniNaziv = new System.Windows.Forms.TextBox();
            this.tbxLatinskiNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.epLatinskiNaziv = new System.Windows.Forms.ErrorProvider(this.components);
            this.epLokalniNaziv = new System.Windows.Forms.ErrorProvider(this.components);
            this.epSBP = new System.Windows.Forms.ErrorProvider(this.components);
            this.pcbPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.epLatinskiNaziv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLokalniNaziv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSBP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // chbFleg
            // 
            this.chbFleg.AutoSize = true;
            this.chbFleg.BackColor = System.Drawing.Color.Transparent;
            this.chbFleg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbFleg.ForeColor = System.Drawing.Color.Black;
            this.chbFleg.Location = new System.Drawing.Point(167, 92);
            this.chbFleg.Name = "chbFleg";
            this.chbFleg.Size = new System.Drawing.Size(128, 22);
            this.chbFleg.TabIndex = 18;
            this.chbFleg.Text = "PticaSelicaFleg";
            this.chbFleg.UseVisualStyleBackColor = false;
            this.chbFleg.CheckedChanged += new System.EventHandler(this.ChbFleg_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(167, 261);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(82, 261);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // tbxSBP
            // 
            this.tbxSBP.Location = new System.Drawing.Point(207, 217);
            this.tbxSBP.MaxLength = 5;
            this.tbxSBP.Name = "tbxSBP";
            this.tbxSBP.Size = new System.Drawing.Size(100, 20);
            this.tbxSBP.TabIndex = 15;
            this.tbxSBP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxSBP_KeyPress);
            // 
            // tbxLokalniNaziv
            // 
            this.tbxLokalniNaziv.Location = new System.Drawing.Point(116, 184);
            this.tbxLokalniNaziv.MaxLength = 30;
            this.tbxLokalniNaziv.Name = "tbxLokalniNaziv";
            this.tbxLokalniNaziv.Size = new System.Drawing.Size(191, 20);
            this.tbxLokalniNaziv.TabIndex = 14;
            this.tbxLokalniNaziv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxLokalniNaziv_KeyPress);
            this.tbxLokalniNaziv.Leave += new System.EventHandler(this.TbxLokalniNaziv_Leave);
            // 
            // tbxLatinskiNaziv
            // 
            this.tbxLatinskiNaziv.Location = new System.Drawing.Point(116, 151);
            this.tbxLatinskiNaziv.MaxLength = 30;
            this.tbxLatinskiNaziv.Name = "tbxLatinskiNaziv";
            this.tbxLatinskiNaziv.Size = new System.Drawing.Size(191, 20);
            this.tbxLatinskiNaziv.TabIndex = 13;
            this.tbxLatinskiNaziv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxLatinskiNaziv_KeyPress);
            this.tbxLatinskiNaziv.Leave += new System.EventHandler(this.TbxLatinskiNaziv_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Serijski broj prstena (SBP)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Lokalni naziv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Latinski naziv";
            // 
            // epLatinskiNaziv
            // 
            this.epLatinskiNaziv.ContainerControl = this;
            // 
            // epLokalniNaziv
            // 
            this.epLokalniNaziv.ContainerControl = this;
            // 
            // epSBP
            // 
            this.epSBP.ContainerControl = this;
            // 
            // pcbPhoto
            // 
            this.pcbPhoto.BackColor = System.Drawing.Color.Transparent;
            this.pcbPhoto.Location = new System.Drawing.Point(26, 22);
            this.pcbPhoto.Name = "pcbPhoto";
            this.pcbPhoto.Size = new System.Drawing.Size(113, 108);
            this.pcbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPhoto.TabIndex = 19;
            this.pcbPhoto.TabStop = false;
            // 
            // DodajZivotinju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ParkPrirode2.Properties.Resources.zivotinjaenv;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(334, 301);
            this.Controls.Add(this.pcbPhoto);
            this.Controls.Add(this.chbFleg);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbxSBP);
            this.Controls.Add(this.tbxLokalniNaziv);
            this.Controls.Add(this.tbxLatinskiNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DodajZivotinju";
            this.Text = "DodajZivotinju";
            this.Load += new System.EventHandler(this.DodajZivotinju_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epLatinskiNaziv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLokalniNaziv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epSBP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbPhoto;
        private System.Windows.Forms.CheckBox chbFleg;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox tbxSBP;
        private System.Windows.Forms.TextBox tbxLokalniNaziv;
        private System.Windows.Forms.TextBox tbxLatinskiNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider epLatinskiNaziv;
        private System.Windows.Forms.ErrorProvider epLokalniNaziv;
        private System.Windows.Forms.ErrorProvider epSBP;
    }
}