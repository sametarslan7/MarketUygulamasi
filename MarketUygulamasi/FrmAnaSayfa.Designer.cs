﻿namespace MarketUygulamasi
{
    partial class FrmAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaSayfa));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnUrun = new Button();
            btnKategori = new Button();
            btnMarka = new Button();
            btnAlisVeris = new Button();
            btnCikis = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(359, 105);
            label1.Name = "label1";
            label1.Size = new Size(490, 27);
            label1.TabIndex = 0;
            label1.Text = "winMarket Otomasyon Sistemine Hoşgeldiniz";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(32, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnUrun
            // 
            btnUrun.BackColor = Color.MediumSeaGreen;
            btnUrun.BackgroundImage = (Image)resources.GetObject("btnUrun.BackgroundImage");
            btnUrun.BackgroundImageLayout = ImageLayout.Stretch;
            btnUrun.Location = new Point(64, 329);
            btnUrun.Name = "btnUrun";
            btnUrun.Size = new Size(177, 175);
            btnUrun.TabIndex = 2;
            btnUrun.UseVisualStyleBackColor = false;
            btnUrun.Click += btnUrun_Click;
            // 
            // btnKategori
            // 
            btnKategori.BackColor = Color.CornflowerBlue;
            btnKategori.BackgroundImage = (Image)resources.GetObject("btnKategori.BackgroundImage");
            btnKategori.BackgroundImageLayout = ImageLayout.Stretch;
            btnKategori.Location = new Point(312, 329);
            btnKategori.Name = "btnKategori";
            btnKategori.Size = new Size(177, 175);
            btnKategori.TabIndex = 3;
            btnKategori.UseVisualStyleBackColor = false;
            // 
            // btnMarka
            // 
            btnMarka.BackColor = Color.Khaki;
            btnMarka.BackgroundImage = (Image)resources.GetObject("btnMarka.BackgroundImage");
            btnMarka.BackgroundImageLayout = ImageLayout.Stretch;
            btnMarka.Location = new Point(562, 329);
            btnMarka.Name = "btnMarka";
            btnMarka.Size = new Size(177, 175);
            btnMarka.TabIndex = 4;
            btnMarka.UseVisualStyleBackColor = false;
            // 
            // btnAlisVeris
            // 
            btnAlisVeris.BackColor = Color.Orange;
            btnAlisVeris.BackgroundImage = (Image)resources.GetObject("btnAlisVeris.BackgroundImage");
            btnAlisVeris.BackgroundImageLayout = ImageLayout.Stretch;
            btnAlisVeris.Location = new Point(824, 329);
            btnAlisVeris.Name = "btnAlisVeris";
            btnAlisVeris.Size = new Size(177, 175);
            btnAlisVeris.TabIndex = 5;
            btnAlisVeris.UseVisualStyleBackColor = false;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.OldLace;
            btnCikis.BackgroundImage = (Image)resources.GetObject("btnCikis.BackgroundImage");
            btnCikis.BackgroundImageLayout = ImageLayout.Stretch;
            btnCikis.Location = new Point(909, 642);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(92, 98);
            btnCikis.TabIndex = 6;
            btnCikis.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 528);
            label2.Name = "label2";
            label2.Size = new Size(93, 32);
            label2.TabIndex = 7;
            label2.Text = "Ürünler";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(334, 528);
            label3.Name = "label3";
            label3.Size = new Size(130, 32);
            label3.TabIndex = 8;
            label3.Text = "Kategoriler";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(593, 528);
            label4.Name = "label4";
            label4.Size = new Size(106, 32);
            label4.TabIndex = 9;
            label4.Text = "Markalar";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(863, 528);
            label5.Name = "label5";
            label5.Size = new Size(100, 32);
            label5.TabIndex = 10;
            label5.Text = "Alışveriş";
            // 
            // FrmAnaSayfa
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1071, 752);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCikis);
            Controls.Add(btnAlisVeris);
            Controls.Add(btnMarka);
            Controls.Add(btnKategori);
            Controls.Add(btnUrun);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAnaSayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ana Sayfa";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button btnUrun;
        private Button btnKategori;
        private Button btnMarka;
        private Button btnAlisVeris;
        private Button btnCikis;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
