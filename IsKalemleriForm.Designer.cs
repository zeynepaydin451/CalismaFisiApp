namespace CalismaFisiApp
{
    partial class IsKalemleriForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTopHeader = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pnlMainCard = new System.Windows.Forms.Panel();
            this.pnlPagination = new System.Windows.Forms.Panel();
            this.flpSayfalar = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.dgvIsKalemleri = new System.Windows.Forms.DataGridView();
            this.pnlFilterBar = new System.Windows.Forms.Panel();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.cmbKayitSayisi = new System.Windows.Forms.ComboBox();
            this.lblKayitSayisi = new System.Windows.Forms.Label();
            this.lblHizliFiltre = new System.Windows.Forms.Label();
            this.pnlCardHeader = new System.Windows.Forms.Panel();
            this.btnYeniIskalemi = new System.Windows.Forms.Button();
            this.lblListeBaslik = new System.Windows.Forms.Label();
            this.pnlTopHeader.SuspendLayout();
            this.pnlMainCard.SuspendLayout();
            this.pnlPagination.SuspendLayout();
            this.flpSayfalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsKalemleri)).BeginInit();
            this.pnlFilterBar.SuspendLayout();
            this.pnlCardHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopHeader
            // 
            this.pnlTopHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(184)))), ((int)(((byte)(137)))));
            this.pnlTopHeader.Controls.Add(this.btnClose);
            this.pnlTopHeader.Controls.Add(this.lblFormTitle);
            this.pnlTopHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlTopHeader.Name = "pnlTopHeader";
            this.pnlTopHeader.Size = new System.Drawing.Size(782, 50);
            this.pnlTopHeader.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(720, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(59, 29);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(12, 9);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(163, 24);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "⏱ İş Kalemlerim";
            // 
            // pnlMainCard
            // 
            this.pnlMainCard.BackColor = System.Drawing.Color.White;
            this.pnlMainCard.Controls.Add(this.pnlPagination);
            this.pnlMainCard.Controls.Add(this.dgvIsKalemleri);
            this.pnlMainCard.Controls.Add(this.pnlFilterBar);
            this.pnlMainCard.Controls.Add(this.pnlCardHeader);
            this.pnlMainCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainCard.Location = new System.Drawing.Point(0, 50);
            this.pnlMainCard.Name = "pnlMainCard";
            this.pnlMainCard.Padding = new System.Windows.Forms.Padding(15);
            this.pnlMainCard.Size = new System.Drawing.Size(782, 490);
            this.pnlMainCard.TabIndex = 1;
            // 
            // pnlPagination
            // 
            this.pnlPagination.Controls.Add(this.flpSayfalar);
            this.pnlPagination.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPagination.Location = new System.Drawing.Point(15, 409);
            this.pnlPagination.Name = "pnlPagination";
            this.pnlPagination.Size = new System.Drawing.Size(752, 63);
            this.pnlPagination.TabIndex = 3;
            // 
            // flpSayfalar
            // 
            this.flpSayfalar.AutoSize = false;
            this.flpSayfalar.Controls.Add(this.button1);
            this.flpSayfalar.Controls.Add(this.button2);
            this.flpSayfalar.Controls.Add(this.button3);
            this.flpSayfalar.Controls.Add(this.button4);
            this.flpSayfalar.Controls.Add(this.button5);
            this.flpSayfalar.Controls.Add(this.button6);
            this.flpSayfalar.Controls.Add(this.button7);
            this.flpSayfalar.Controls.Add(this.button8);
            this.flpSayfalar.Controls.Add(this.button9);
            this.flpSayfalar.Location = new System.Drawing.Point(176, 6);
            this.flpSayfalar.Name = "flpSayfalar";
            this.flpSayfalar.Size = new System.Drawing.Size(400, 42);
            this.flpSayfalar.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(49, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(95, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "1";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.SayfaButton_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(141, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 28);
            this.button4.TabIndex = 3;
            this.button4.Text = "2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.SayfaButton_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(187, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 28);
            this.button5.TabIndex = 4;
            this.button5.Text = "3";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.SayfaButton_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(233, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 28);
            this.button6.TabIndex = 5;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.SayfaButton_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(279, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(40, 28);
            this.button7.TabIndex = 6;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.SayfaButton_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(325, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(40, 28);
            this.button8.TabIndex = 7;
            this.button8.Text = ">>";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(371, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(40, 28);
            this.button9.TabIndex = 8;
            this.button9.Text = ">";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // dgvIsKalemleri
            // 
            this.dgvIsKalemleri.AllowUserToAddRows = false;
            this.dgvIsKalemleri.BackgroundColor = System.Drawing.Color.White;
            this.dgvIsKalemleri.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIsKalemleri.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIsKalemleri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIsKalemleri.ColumnHeadersHeight = 40;
            this.dgvIsKalemleri.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvIsKalemleri.EnableHeadersVisualStyles = false;
            this.dgvIsKalemleri.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.dgvIsKalemleri.Location = new System.Drawing.Point(15, 155);
            this.dgvIsKalemleri.Name = "dgvIsKalemleri";
            this.dgvIsKalemleri.RowHeadersVisible = false;
            this.dgvIsKalemleri.RowHeadersWidth = 51;
            this.dgvIsKalemleri.RowTemplate.Height = 55;
            this.dgvIsKalemleri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIsKalemleri.Size = new System.Drawing.Size(752, 254);
            this.dgvIsKalemleri.TabIndex = 2;
            this.dgvIsKalemleri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIsKalemleri_CellContentClick);
            // 
            // pnlFilterBar
            // 
            this.pnlFilterBar.Controls.Add(this.txtArama);
            this.pnlFilterBar.Controls.Add(this.cmbKayitSayisi);
            this.pnlFilterBar.Controls.Add(this.lblKayitSayisi);
            this.pnlFilterBar.Controls.Add(this.lblHizliFiltre);
            this.pnlFilterBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilterBar.Location = new System.Drawing.Point(15, 75);
            this.pnlFilterBar.Name = "pnlFilterBar";
            this.pnlFilterBar.Size = new System.Drawing.Size(752, 80);
            this.pnlFilterBar.TabIndex = 1;
            // 
            // txtArama
            // 
            this.txtArama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtArama.Location = new System.Drawing.Point(128, 24);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(150, 28);
            this.txtArama.TabIndex = 3;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // cmbKayitSayisi
            // 
            this.cmbKayitSayisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKayitSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKayitSayisi.FormattingEnabled = true;
            this.cmbKayitSayisi.Items.AddRange(new object[] {
            5,
            10,
            20,
            50});
            this.cmbKayitSayisi.Location = new System.Drawing.Point(688, 25);
            this.cmbKayitSayisi.Name = "cmbKayitSayisi";
            this.cmbKayitSayisi.Size = new System.Drawing.Size(50, 28);
            this.cmbKayitSayisi.TabIndex = 2;
            // 
            // lblKayitSayisi
            // 
            this.lblKayitSayisi.AutoSize = true;
            this.lblKayitSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayitSayisi.Location = new System.Drawing.Point(591, 29);
            this.lblKayitSayisi.Name = "lblKayitSayisi";
            this.lblKayitSayisi.Size = new System.Drawing.Size(91, 18);
            this.lblKayitSayisi.TabIndex = 1;
            this.lblKayitSayisi.Text = "Kayıt Sayısı :";
            // 
            // lblHizliFiltre
            // 
            this.lblHizliFiltre.AutoSize = true;
            this.lblHizliFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHizliFiltre.Location = new System.Drawing.Point(14, 28);
            this.lblHizliFiltre.Name = "lblHizliFiltre";
            this.lblHizliFiltre.Size = new System.Drawing.Size(112, 18);
            this.lblHizliFiltre.TabIndex = 0;
            this.lblHizliFiltre.Text = "Hızlı Filtreleme :";
            // 
            // pnlCardHeader
            // 
            this.pnlCardHeader.Controls.Add(this.btnYeniIskalemi);
            this.pnlCardHeader.Controls.Add(this.lblListeBaslik);
            this.pnlCardHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCardHeader.Location = new System.Drawing.Point(15, 15);
            this.pnlCardHeader.Name = "pnlCardHeader";
            this.pnlCardHeader.Size = new System.Drawing.Size(752, 60);
            this.pnlCardHeader.TabIndex = 0;
            // 
            // btnYeniIskalemi
            // 
            this.btnYeniIskalemi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnYeniIskalemi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniIskalemi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniIskalemi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnYeniIskalemi.Location = new System.Drawing.Point(619, 16);
            this.btnYeniIskalemi.Name = "btnYeniIskalemi";
            this.btnYeniIskalemi.Size = new System.Drawing.Size(120, 29);
            this.btnYeniIskalemi.TabIndex = 1;
            this.btnYeniIskalemi.Text = "Yeni İş Kalemi";
            this.btnYeniIskalemi.UseVisualStyleBackColor = true;
            this.btnYeniIskalemi.Click += new System.EventHandler(this.btnYeniIsKalemi_Click);
            // 
            // lblListeBaslik
            // 
            this.lblListeBaslik.AutoSize = true;
            this.lblListeBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblListeBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblListeBaslik.Location = new System.Drawing.Point(22, 16);
            this.lblListeBaslik.Name = "lblListeBaslik";
            this.lblListeBaslik.Size = new System.Drawing.Size(150, 20);
            this.lblListeBaslik.TabIndex = 0;
            this.lblListeBaslik.Text = "▦ İş Kalemi Listesi";
            // 
            // IsKalemleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(782, 540);
            this.Controls.Add(this.pnlMainCard);
            this.Controls.Add(this.pnlTopHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IsKalemleriForm";
            this.Text = "Form1";
            this.pnlTopHeader.ResumeLayout(false);
            this.pnlTopHeader.PerformLayout();
            this.pnlMainCard.ResumeLayout(false);
            this.pnlPagination.ResumeLayout(false);
            this.flpSayfalar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsKalemleri)).EndInit();
            this.pnlFilterBar.ResumeLayout(false);
            this.pnlFilterBar.PerformLayout();
            this.pnlCardHeader.ResumeLayout(false);
            this.pnlCardHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopHeader;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlMainCard;
        private System.Windows.Forms.Panel pnlCardHeader;
        private System.Windows.Forms.Button btnYeniIskalemi;
        private System.Windows.Forms.Label lblListeBaslik;
        private System.Windows.Forms.Panel pnlFilterBar;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.ComboBox cmbKayitSayisi;
        private System.Windows.Forms.Label lblKayitSayisi;
        private System.Windows.Forms.Label lblHizliFiltre;
        private System.Windows.Forms.DataGridView dgvIsKalemleri;
        private System.Windows.Forms.Panel pnlPagination;
        private System.Windows.Forms.FlowLayoutPanel flpSayfalar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}