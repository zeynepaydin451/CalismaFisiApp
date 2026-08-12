namespace CalismaFisiApp
{
    partial class IsKalemiDuzenleForm
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
            this.pnlTopHeader = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pnlMainCard = new System.Windows.Forms.Panel();
            this.pnlButtonlar = new System.Windows.Forms.Panel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.cmbCalismaTuru = new System.Windows.Forms.ComboBox();
            this.lblCalismaTuru = new System.Windows.Forms.Label();
            this.cmbProje = new System.Windows.Forms.ComboBox();
            this.lblProje = new System.Windows.Forms.Label();
            this.pnlTopHeader.SuspendLayout();
            this.pnlMainCard.SuspendLayout();
            this.pnlButtonlar.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopHeader
            // 
            this.pnlTopHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(137)))));
            this.pnlTopHeader.Controls.Add(this.btnKapat);
            this.pnlTopHeader.Controls.Add(this.lblFormTitle);
            this.pnlTopHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlTopHeader.Name = "pnlTopHeader";
            this.pnlTopHeader.Size = new System.Drawing.Size(600, 50);
            this.pnlTopHeader.TabIndex = 0;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnKapat.BackColor = System.Drawing.Color.Transparent;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnKapat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(555, 12);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(35, 29);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "×";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(12, 9);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(182, 24);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "✎ İş Kalemi Düzenle";
            // 
            // pnlMainCard
            // 
            this.pnlMainCard.BackColor = System.Drawing.Color.White;
            this.pnlMainCard.Controls.Add(this.pnlButtonlar);
            this.pnlMainCard.Controls.Add(this.pnlForm);
            this.pnlMainCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainCard.Location = new System.Drawing.Point(0, 50);
            this.pnlMainCard.Name = "pnlMainCard";
            this.pnlMainCard.Padding = new System.Windows.Forms.Padding(20);
            this.pnlMainCard.Size = new System.Drawing.Size(600, 350);
            this.pnlMainCard.TabIndex = 1;
            // 
            // pnlButtonlar
            // 
            this.pnlButtonlar.Controls.Add(this.btnKaydet);
            this.pnlButtonlar.Controls.Add(this.btnIptal);
            this.pnlButtonlar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtonlar.Location = new System.Drawing.Point(20, 280);
            this.pnlButtonlar.Name = "pnlButtonlar";
            this.pnlButtonlar.Size = new System.Drawing.Size(560, 50);
            this.pnlButtonlar.TabIndex = 1;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(137)))));
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(360, 10);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(95, 32);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnIptal.FlatAppearance.BorderSize = 0;
            this.btnIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.ForeColor = System.Drawing.Color.White;
            this.btnIptal.Location = new System.Drawing.Point(465, 10);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(95, 32);
            this.btnIptal.TabIndex = 0;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.txtAciklama);
            this.pnlForm.Controls.Add(this.lblAciklama);
            this.pnlForm.Controls.Add(this.cmbCalismaTuru);
            this.pnlForm.Controls.Add(this.lblCalismaTuru);
            this.pnlForm.Controls.Add(this.cmbProje);
            this.pnlForm.Controls.Add(this.lblProje);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(20, 20);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(560, 260);
            this.pnlForm.TabIndex = 0;
            // 
            // txtAciklama
            // 
            this.txtAciklama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(10, 160);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAciklama.Size = new System.Drawing.Size(540, 90);
            this.txtAciklama.TabIndex = 5;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblAciklama.Location = new System.Drawing.Point(10, 135);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(86, 15);
            this.lblAciklama.TabIndex = 4;
            this.lblAciklama.Text = "Açıklama (*)";
            // 
            // cmbCalismaTuru
            // 
            this.cmbCalismaTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCalismaTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCalismaTuru.FormattingEnabled = true;
            this.cmbCalismaTuru.Location = new System.Drawing.Point(10, 100);
            this.cmbCalismaTuru.Name = "cmbCalismaTuru";
            this.cmbCalismaTuru.Size = new System.Drawing.Size(540, 24);
            this.cmbCalismaTuru.TabIndex = 3;
            // 
            // lblCalismaTuru
            // 
            this.lblCalismaTuru.AutoSize = true;
            this.lblCalismaTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCalismaTuru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblCalismaTuru.Location = new System.Drawing.Point(10, 75);
            this.lblCalismaTuru.Name = "lblCalismaTuru";
            this.lblCalismaTuru.Size = new System.Drawing.Size(111, 15);
            this.lblCalismaTuru.TabIndex = 2;
            this.lblCalismaTuru.Text = "Çalışma Türü (*)";
            // 
            // cmbProje
            // 
            this.cmbProje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbProje.FormattingEnabled = true;
            this.cmbProje.Location = new System.Drawing.Point(10, 40);
            this.cmbProje.Name = "cmbProje";
            this.cmbProje.Size = new System.Drawing.Size(540, 24);
            this.cmbProje.TabIndex = 1;
            // 
            // lblProje
            // 
            this.lblProje.AutoSize = true;
            this.lblProje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblProje.Location = new System.Drawing.Point(10, 15);
            this.lblProje.Name = "lblProje";
            this.lblProje.Size = new System.Drawing.Size(67, 15);
            this.lblProje.TabIndex = 0;
            this.lblProje.Text = "Proje (*)";
            // 
            // IsKalemiDuzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.pnlMainCard);
            this.Controls.Add(this.pnlTopHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IsKalemiDuzenleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IsKalemiDuzenleForm";
            this.pnlTopHeader.ResumeLayout(false);
            this.pnlTopHeader.PerformLayout();
            this.pnlMainCard.ResumeLayout(false);
            this.pnlButtonlar.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopHeader;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Panel pnlMainCard;
        private System.Windows.Forms.Panel pnlButtonlar;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.ComboBox cmbCalismaTuru;
        private System.Windows.Forms.Label lblCalismaTuru;
        private System.Windows.Forms.ComboBox cmbProje;
        private System.Windows.Forms.Label lblProje;
    }
}
