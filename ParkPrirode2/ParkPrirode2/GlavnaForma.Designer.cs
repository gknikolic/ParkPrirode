namespace ParkPrirode2
{
    partial class GlavnaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnaForma));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chbStalnazastita = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.chbPrikaziAktivna = new System.Windows.Forms.CheckBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.chbPrikaziPre = new System.Windows.Forms.CheckBox();
            this.chbPrikaziPtice = new System.Windows.Forms.CheckBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(905, 500);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::ParkPrirode2.Properties.Resources.glavnaslika3;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.chbStalnazastita);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(897, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Oblasti";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // chbStalnazastita
            // 
            this.chbStalnazastita.AutoSize = true;
            this.chbStalnazastita.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbStalnazastita.ForeColor = System.Drawing.Color.Black;
            this.chbStalnazastita.Location = new System.Drawing.Point(666, 229);
            this.chbStalnazastita.Name = "chbStalnazastita";
            this.chbStalnazastita.Size = new System.Drawing.Size(160, 22);
            this.chbStalnazastita.TabIndex = 11;
            this.chbStalnazastita.Text = "Filtriraj stalna zastita";
            this.chbStalnazastita.UseVisualStyleBackColor = true;
            this.chbStalnazastita.CheckedChanged += new System.EventHandler(this.ChbStalnazastita_CheckedChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(647, 174);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(197, 30);
            this.button5.TabIndex = 9;
            this.button5.Text = "Ostale informacije";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(647, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 30);
            this.button3.TabIndex = 8;
            this.button3.Text = "Izmeni";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(809, 704);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(644, 704);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ukupan broj oblasti:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(647, 59);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(197, 30);
            this.button4.TabIndex = 4;
            this.button4.Text = "Obrisi oblast";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(647, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Dodaj oblast";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(615, 468);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.BackgroundImage = global::ParkPrirode2.Properties.Resources.glavnaslika3;
            this.tabPage5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage5.Controls.Add(this.groupBox1);
            this.tabPage5.Controls.Add(this.button6);
            this.tabPage5.Controls.Add(this.chbPrikaziAktivna);
            this.tabPage5.Controls.Add(this.dataGridView2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(897, 474);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Hranilista";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Enter += new System.EventHandler(this.TabPage5_Enter);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(589, 68);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(197, 31);
            this.button6.TabIndex = 6;
            this.button6.Text = "Prikazi sve zivotinje";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // chbPrikaziAktivna
            // 
            this.chbPrikaziAktivna.AutoSize = true;
            this.chbPrikaziAktivna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPrikaziAktivna.Location = new System.Drawing.Point(589, 30);
            this.chbPrikaziAktivna.Name = "chbPrikaziAktivna";
            this.chbPrikaziAktivna.Size = new System.Drawing.Size(206, 20);
            this.chbPrikaziAktivna.TabIndex = 5;
            this.chbPrikaziAktivna.Text = "Prikazi samo aktivna hranilista";
            this.chbPrikaziAktivna.UseVisualStyleBackColor = true;
            this.chbPrikaziAktivna.CheckedChanged += new System.EventHandler(this.ChbPrikaziAktivna_CheckedChanged);
            // 
            // dtpDatum
            // 
            this.dtpDatum.CustomFormat = "dd:MM:yyy";
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatum.Location = new System.Drawing.Point(36, 71);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(75, 20);
            this.dtpDatum.TabIndex = 4;
            // 
            // chbPrikaziPre
            // 
            this.chbPrikaziPre.AutoSize = true;
            this.chbPrikaziPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPrikaziPre.Location = new System.Drawing.Point(11, 45);
            this.chbPrikaziPre.Name = "chbPrikaziPre";
            this.chbPrikaziPre.Size = new System.Drawing.Size(251, 20);
            this.chbPrikaziPre.TabIndex = 3;
            this.chbPrikaziPre.Text = "Prikazi primecene pre prvi put datuma";
            this.chbPrikaziPre.UseVisualStyleBackColor = true;
            this.chbPrikaziPre.CheckedChanged += new System.EventHandler(this.ChbPrikaziPre_CheckedChanged);
            // 
            // chbPrikaziPtice
            // 
            this.chbPrikaziPtice.AutoSize = true;
            this.chbPrikaziPtice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPrikaziPtice.Location = new System.Drawing.Point(11, 19);
            this.chbPrikaziPtice.Name = "chbPrikaziPtice";
            this.chbPrikaziPtice.Size = new System.Drawing.Size(99, 20);
            this.chbPrikaziPtice.TabIndex = 2;
            this.chbPrikaziPtice.Text = "Prikazi ptice";
            this.chbPrikaziPtice.UseVisualStyleBackColor = true;
            this.chbPrikaziPtice.CheckedChanged += new System.EventHandler(this.ChbPrikaziPtice_CheckedChanged);
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(11, 105);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(197, 31);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikazi zivotinje na hranilistu";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.BtnPrikazi_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(551, 474);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpDatum);
            this.groupBox1.Controls.Add(this.chbPrikaziPre);
            this.groupBox1.Controls.Add(this.chbPrikaziPtice);
            this.groupBox1.Controls.Add(this.btnPrikazi);
            this.groupBox1.Location = new System.Drawing.Point(578, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 142);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zivotinje na hranilistima";
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 500);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GlavnaForma";
            this.Text = "GlavnaForma";
            this.Load += new System.EventHandler(this.GlavnaForma_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.CheckBox chbPrikaziPre;
        private System.Windows.Forms.CheckBox chbPrikaziPtice;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.CheckBox chbPrikaziAktivna;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox chbStalnazastita;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}