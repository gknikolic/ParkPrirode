namespace ParkPrirode2
{
    partial class AddOblast
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOblast));
            this.tbxIme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPovrsina = new System.Windows.Forms.TextBox();
            this.cbxTipZastite = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblTip = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxIme
            // 
            this.tbxIme.Location = new System.Drawing.Point(12, 29);
            this.tbxIme.Name = "tbxIme";
            this.tbxIme.Size = new System.Drawing.Size(161, 20);
            this.tbxIme.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesi ime oblasti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Povrsina";
            // 
            // tbxPovrsina
            // 
            this.tbxPovrsina.Location = new System.Drawing.Point(202, 29);
            this.tbxPovrsina.Name = "tbxPovrsina";
            this.tbxPovrsina.Size = new System.Drawing.Size(100, 20);
            this.tbxPovrsina.TabIndex = 3;
            // 
            // cbxTipZastite
            // 
            this.cbxTipZastite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTipZastite.FormattingEnabled = true;
            this.cbxTipZastite.Items.AddRange(new object[] {
            "Stalna zastita",
            "Monitoring",
            "Povremena intervencija"});
            this.cbxTipZastite.Location = new System.Drawing.Point(12, 80);
            this.cbxTipZastite.Name = "cbxTipZastite";
            this.cbxTipZastite.Size = new System.Drawing.Size(121, 24);
            this.cbxTipZastite.TabIndex = 6;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(285, 81);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 7;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.Location = new System.Drawing.Point(12, 61);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(69, 16);
            this.lblTip.TabIndex = 9;
            this.lblTip.Text = "Tip zastite";
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(341, 29);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(100, 20);
            this.tbxId.TabIndex = 10;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(338, 9);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(64, 16);
            this.lblId.TabIndex = 11;
            this.lblId.Text = "Id Oblasti";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(366, 81);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // AddOblast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(462, 122);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cbxTipZastite);
            this.Controls.Add(this.tbxPovrsina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxIme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddOblast";
            this.Text = "Dodavanje oblasti";
            this.Load += new System.EventHandler(this.AddOblast_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPovrsina;
        private System.Windows.Forms.ComboBox cbxTipZastite;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button btnClose;
    }
}