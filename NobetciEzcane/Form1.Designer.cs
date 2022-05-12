namespace NobetciEzcane
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SehirComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IlceComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tarih = new System.Windows.Forms.Label();
            this.saat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EczaneAdi = new System.Windows.Forms.ListBox();
            this.EczaneAdres = new System.Windows.Forms.ListBox();
            this.EczaneTelefon = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(347, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "NÖBETÇİ ECZANE PORTALI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(541, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şehir Seçiniz";
            // 
            // SehirComboBox
            // 
            this.SehirComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SehirComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SehirComboBox.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SehirComboBox.FormattingEnabled = true;
            this.SehirComboBox.Location = new System.Drawing.Point(515, 154);
            this.SehirComboBox.Name = "SehirComboBox";
            this.SehirComboBox.Size = new System.Drawing.Size(191, 26);
            this.SehirComboBox.TabIndex = 1;
            this.SehirComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(548, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "İlçe Seçiniz";
            // 
            // IlceComboBox
            // 
            this.IlceComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.IlceComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.IlceComboBox.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IlceComboBox.FormattingEnabled = true;
            this.IlceComboBox.Location = new System.Drawing.Point(515, 271);
            this.IlceComboBox.Name = "IlceComboBox";
            this.IlceComboBox.Size = new System.Drawing.Size(191, 26);
            this.IlceComboBox.TabIndex = 2;
            this.IlceComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(515, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Nöbetçi Ezcane Ara";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // tarih
            // 
            this.tarih.AutoSize = true;
            this.tarih.BackColor = System.Drawing.Color.Transparent;
            this.tarih.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tarih.ForeColor = System.Drawing.Color.White;
            this.tarih.Location = new System.Drawing.Point(1088, 653);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(53, 23);
            this.tarih.TabIndex = 8;
            this.tarih.Text = "Tarih";
            // 
            // saat
            // 
            this.saat.AutoSize = true;
            this.saat.BackColor = System.Drawing.Color.Transparent;
            this.saat.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saat.ForeColor = System.Drawing.Color.White;
            this.saat.Location = new System.Drawing.Point(1088, 677);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(47, 23);
            this.saat.TabIndex = 9;
            this.saat.Text = "Saat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(340, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(540, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Seçilen İl İle Göre Nöbetçi Eczanenin Bilgileri";
            // 
            // EczaneAdi
            // 
            this.EczaneAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EczaneAdi.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EczaneAdi.FormattingEnabled = true;
            this.EczaneAdi.ItemHeight = 18;
            this.EczaneAdi.Location = new System.Drawing.Point(114, 447);
            this.EczaneAdi.Name = "EczaneAdi";
            this.EczaneAdi.Size = new System.Drawing.Size(170, 252);
            this.EczaneAdi.TabIndex = 11;
            this.EczaneAdi.Visible = false;
            // 
            // EczaneAdres
            // 
            this.EczaneAdres.BackColor = System.Drawing.SystemColors.Window;
            this.EczaneAdres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EczaneAdres.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EczaneAdres.FormattingEnabled = true;
            this.EczaneAdres.HorizontalScrollbar = true;
            this.EczaneAdres.ItemHeight = 18;
            this.EczaneAdres.Location = new System.Drawing.Point(284, 447);
            this.EczaneAdres.Name = "EczaneAdres";
            this.EczaneAdres.Size = new System.Drawing.Size(602, 252);
            this.EczaneAdres.TabIndex = 12;
            this.EczaneAdres.Visible = false;
            // 
            // EczaneTelefon
            // 
            this.EczaneTelefon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EczaneTelefon.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EczaneTelefon.FormattingEnabled = true;
            this.EczaneTelefon.ItemHeight = 18;
            this.EczaneTelefon.Location = new System.Drawing.Point(886, 447);
            this.EczaneTelefon.Name = "EczaneTelefon";
            this.EczaneTelefon.Size = new System.Drawing.Size(170, 252);
            this.EczaneTelefon.TabIndex = 13;
            this.EczaneTelefon.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 152);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1020, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 152);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 676);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Birol Topal";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 709);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EczaneTelefon);
            this.Controls.Add(this.EczaneAdres);
            this.Controls.Add(this.EczaneAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.saat);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IlceComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SehirComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nöbetçi Eczane Portalı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox SehirComboBox;
        private Label label3;
        private ComboBox IlceComboBox;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Label tarih;
        private Label saat;
        private Label label6;
        private ListBox EczaneAdi;
        private ListBox EczaneAdres;
        private ListBox EczaneTelefon;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
    }
}