namespace degiskenler_projesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            TxtBilet = new TextBox();
            Txtcay = new TextBox();
            TxtSu = new TextBox();
            TxtMisir = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            button2 = new Button();
            LblKasa = new Label();
            label12 = new Label();
            button1 = new Button();
            LblToplam = new Label();
            label9 = new Label();
            label13 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkGoldenrod;
            groupBox1.Controls.Add(TxtBilet);
            groupBox1.Controls.Add(Txtcay);
            groupBox1.Controls.Add(TxtSu);
            groupBox1.Controls.Add(TxtMisir);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = SystemColors.ActiveCaption;
            groupBox1.Location = new Point(49, 201);
            groupBox1.Margin = new Padding(2, 3, 2, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 3, 2, 3);
            groupBox1.Size = new Size(194, 404);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün Miktarı";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // TxtBilet
            // 
            TxtBilet.Location = new Point(62, 187);
            TxtBilet.Margin = new Padding(2, 3, 2, 3);
            TxtBilet.Name = "TxtBilet";
            TxtBilet.Size = new Size(98, 26);
            TxtBilet.TabIndex = 7;
            // 
            // Txtcay
            // 
            Txtcay.Location = new Point(62, 149);
            Txtcay.Margin = new Padding(2, 3, 2, 3);
            Txtcay.Name = "Txtcay";
            Txtcay.Size = new Size(98, 26);
            Txtcay.TabIndex = 6;
            // 
            // TxtSu
            // 
            TxtSu.Location = new Point(62, 112);
            TxtSu.Margin = new Padding(2, 3, 2, 3);
            TxtSu.Name = "TxtSu";
            TxtSu.Size = new Size(98, 26);
            TxtSu.TabIndex = 5;
            // 
            // TxtMisir
            // 
            TxtMisir.Location = new Point(62, 73);
            TxtMisir.Margin = new Padding(2, 3, 2, 3);
            TxtMisir.Name = "TxtMisir";
            TxtMisir.Size = new Size(98, 26);
            TxtMisir.TabIndex = 4;
            TxtMisir.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(9, 193);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(41, 19);
            label4.TabIndex = 3;
            label4.Text = "Bilet:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(9, 149);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(35, 19);
            label3.TabIndex = 2;
            label3.Text = "Çay:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(9, 112);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(28, 19);
            label2.TabIndex = 1;
            label2.Text = "Su:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(9, 73);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(43, 19);
            label1.TabIndex = 0;
            label1.Text = "Mısır:";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.BlueViolet;
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.ForeColor = SystemColors.ActiveCaption;
            groupBox2.Location = new Point(360, 201);
            groupBox2.Margin = new Padding(2, 3, 2, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 3, 2, 3);
            groupBox2.Size = new Size(194, 404);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ürün Fiyatı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(44, 194);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(58, 19);
            label5.TabIndex = 7;
            label5.Text = "Bilet: 10";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(44, 150);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(46, 19);
            label6.TabIndex = 6;
            label6.Text = "Çay: 3";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Black;
            label7.Location = new Point(44, 113);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(37, 19);
            label7.TabIndex = 5;
            label7.Text = "Su: 1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(44, 74);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(70, 19);
            label8.TabIndex = 4;
            label8.Text = "Mısır: 4 TL";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.LightCyan;
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(LblKasa);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(LblToplam);
            groupBox3.Controls.Add(label9);
            groupBox3.ForeColor = SystemColors.ActiveCaption;
            groupBox3.Location = new Point(633, 201);
            groupBox3.Margin = new Padding(2, 3, 2, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2, 3, 2, 3);
            groupBox3.Size = new Size(194, 404);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kasa";
            // 
            // button2
            // 
            button2.Location = new Point(39, 188);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "Temizle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // LblKasa
            // 
            LblKasa.AutoSize = true;
            LblKasa.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            LblKasa.ForeColor = SystemColors.ActiveCaptionText;
            LblKasa.Location = new Point(92, 237);
            LblKasa.Margin = new Padding(2, 0, 2, 0);
            LblKasa.Name = "LblKasa";
            LblKasa.Size = new Size(41, 19);
            LblKasa.TabIndex = 9;
            LblKasa.Text = "00 TL";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(36, 237);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(43, 19);
            label12.TabIndex = 8;
            label12.Tag = "Kasa:";
            label12.Text = "Kasa:";
            // 
            // button1
            // 
            button1.Location = new Point(39, 144);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LblToplam
            // 
            LblToplam.AutoSize = true;
            LblToplam.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            LblToplam.ForeColor = SystemColors.ActiveCaptionText;
            LblToplam.Location = new Point(99, 103);
            LblToplam.Margin = new Padding(2, 0, 2, 0);
            LblToplam.Name = "LblToplam";
            LblToplam.Size = new Size(41, 19);
            LblToplam.TabIndex = 6;
            LblToplam.Text = "00 TL";
            LblToplam.Click += label10_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(36, 103);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(59, 19);
            label9.TabIndex = 5;
            label9.Text = "Toplam:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Pristina", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(82, 71);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(392, 52);
            label13.TabIndex = 3;
            label13.Text = "Sinema & Büfe Satış Paneli";
            label13.Click += label13_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(649, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 130);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(891, 700);
            Controls.Add(pictureBox1);
            Controls.Add(label13);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            Text = "Büfe & Sinema";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox TxtSu;
        private TextBox TxtMisir;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private TextBox TxtBilet;
        private TextBox Txtcay;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label LblKasa;
        private Label label12;
        private Button button1;
        private Label LblToplam;
        private Label label9;
        private Button button2;
        private Label label13;
        private PictureBox pictureBox1;
    }
}
