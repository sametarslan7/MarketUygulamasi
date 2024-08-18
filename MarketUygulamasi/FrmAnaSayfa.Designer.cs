namespace MarketUygulamasi
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
            btnMarka = new Button();
            btnAlisVeris = new Button();
            btnCikis = new Button();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(359, 105);
            label1.Name = "label1";
            label1.Size = new Size(490, 27);
            label1.TabIndex = 0;
            label1.Text = "winMarket Otomasyon Sistemine Hoşgeldiniz";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
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
            // btnMarka
            // 
            btnMarka.BackColor = Color.Khaki;
            btnMarka.BackgroundImage = (Image)resources.GetObject("btnMarka.BackgroundImage");
            btnMarka.BackgroundImageLayout = ImageLayout.Stretch;
            btnMarka.Location = new Point(443, 329);
            btnMarka.Name = "btnMarka";
            btnMarka.Size = new Size(177, 175);
            btnMarka.TabIndex = 4;
            btnMarka.UseVisualStyleBackColor = false;
            btnMarka.Click += btnMarka_Click;
            // 
            // btnAlisVeris
            // 
            btnAlisVeris.BackColor = Color.Orange;
            btnAlisVeris.BackgroundImage = (Image)resources.GetObject("btnAlisVeris.BackgroundImage");
            btnAlisVeris.BackgroundImageLayout = ImageLayout.Stretch;
            btnAlisVeris.Location = new Point(793, 329);
            btnAlisVeris.Name = "btnAlisVeris";
            btnAlisVeris.Size = new Size(177, 175);
            btnAlisVeris.TabIndex = 5;
            btnAlisVeris.UseVisualStyleBackColor = false;
            btnAlisVeris.Click += btnAlisVeris_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.Transparent;
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
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(106, 528);
            label2.Name = "label2";
            label2.Size = new Size(93, 32);
            label2.TabIndex = 7;
            label2.Text = "Ürünler";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.Snow;
            label5.Location = new Point(832, 528);
            label5.Name = "label5";
            label5.Size = new Size(100, 32);
            label5.TabIndex = 10;
            label5.Text = "Alışveriş";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(443, 528);
            label4.Name = "label4";
            label4.Size = new Size(180, 32);
            label4.TabIndex = 9;
            label4.Text = "Marka Yönetimi";
            // 
            // FrmAnaSayfa
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightSteelBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1071, 752);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnCikis);
            Controls.Add(btnAlisVeris);
            Controls.Add(btnMarka);
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
        private Button btnMarka;
        private Button btnAlisVeris;
        private Button btnCikis;
        private Label label2;
        private Label label5;
        private Label label4;
    }
}
