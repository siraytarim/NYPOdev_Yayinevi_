namespace Hafta8_Odev
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.butyEviEkle = new System.Windows.Forms.Button();
            this.butKitapEkle = new System.Windows.Forms.Button();
            this.butKitapSil = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.butEditorEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.butYEviKitaplar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.butYeviEditorler = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.26957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yayınevi Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.26957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(188, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kitap Adı:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(9, 56);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 41);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(188, 56);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(192, 41);
            this.textBox2.TabIndex = 3;
            // 
            // butyEviEkle
            // 
            this.butyEviEkle.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butyEviEkle.Location = new System.Drawing.Point(9, 103);
            this.butyEviEkle.Name = "butyEviEkle";
            this.butyEviEkle.Size = new System.Drawing.Size(150, 69);
            this.butyEviEkle.TabIndex = 4;
            this.butyEviEkle.Text = "Yayınevi Ekle";
            this.butyEviEkle.UseVisualStyleBackColor = true;
            this.butyEviEkle.Click += new System.EventHandler(this.butyEviEkle_Click);
            // 
            // butKitapEkle
            // 
            this.butKitapEkle.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butKitapEkle.Location = new System.Drawing.Point(188, 103);
            this.butKitapEkle.Name = "butKitapEkle";
            this.butKitapEkle.Size = new System.Drawing.Size(99, 69);
            this.butKitapEkle.TabIndex = 5;
            this.butKitapEkle.Text = "Yayınevine Kitap Ekle";
            this.butKitapEkle.UseVisualStyleBackColor = true;
            this.butKitapEkle.Click += new System.EventHandler(this.butKitapEkle_Click);
            // 
            // butKitapSil
            // 
            this.butKitapSil.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butKitapSil.Location = new System.Drawing.Point(277, 103);
            this.butKitapSil.Name = "butKitapSil";
            this.butKitapSil.Size = new System.Drawing.Size(103, 69);
            this.butKitapSil.TabIndex = 6;
            this.butKitapSil.Text = "Yayınevinden Kitap Sil";
            this.butKitapSil.UseVisualStyleBackColor = true;
            this.butKitapSil.Click += new System.EventHandler(this.butKitapSil_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 201);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 27);
            this.comboBox1.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.765218F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(14, 333);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(165, 140);
            this.listBox1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.26957F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(415, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Editor Adı:";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(415, 56);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 41);
            this.textBox3.TabIndex = 10;
            // 
            // butEditorEkle
            // 
            this.butEditorEkle.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butEditorEkle.Location = new System.Drawing.Point(415, 103);
            this.butEditorEkle.Name = "butEditorEkle";
            this.butEditorEkle.Size = new System.Drawing.Size(139, 69);
            this.butEditorEkle.TabIndex = 11;
            this.butEditorEkle.Text = "Yayınevine Editor Ekle";
            this.butEditorEkle.UseVisualStyleBackColor = true;
            this.butEditorEkle.Click += new System.EventHandler(this.butEditorEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(376, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "label4";
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.765218F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 17;
            this.listBox2.Location = new System.Drawing.Point(376, 333);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(117, 140);
            this.listBox2.TabIndex = 17;
            // 
            // butYEviKitaplar
            // 
            this.butYEviKitaplar.Location = new System.Drawing.Point(9, 234);
            this.butYEviKitaplar.Name = "butYEviKitaplar";
            this.butYEviKitaplar.Size = new System.Drawing.Size(150, 59);
            this.butYEviKitaplar.TabIndex = 18;
            this.butYEviKitaplar.Text = "Seçili Yayınevi\r\n Kitaplarını Göster";
            this.butYEviKitaplar.UseVisualStyleBackColor = true;
            this.butYEviKitaplar.Click += new System.EventHandler(this.butYEviKitaplar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(14, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 21);
            this.label5.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(14, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "label6";
            // 
            // listBox3
            // 
            this.listBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.765218F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 17;
            this.listBox3.Location = new System.Drawing.Point(559, 333);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(123, 140);
            this.listBox3.TabIndex = 21;
            // 
            // butYeviEditorler
            // 
            this.butYeviEditorler.Location = new System.Drawing.Point(165, 234);
            this.butYeviEditorler.Name = "butYeviEditorler";
            this.butYeviEditorler.Size = new System.Drawing.Size(150, 59);
            this.butYeviEditorler.TabIndex = 22;
            this.butYeviEditorler.Text = "Seçili Yayınevi\r\n Editörlerini Göster";
            this.butYeviEditorler.UseVisualStyleBackColor = true;
            this.butYeviEditorler.Click += new System.EventHandler(this.butYeviEditorler_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(559, 305);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "label7";
            // 
            // listBox4
            // 
            this.listBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.765218F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 17;
            this.listBox4.Location = new System.Drawing.Point(188, 333);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(167, 140);
            this.listBox4.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(188, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 21);
            this.label8.TabIndex = 25;
            this.label8.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 492);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.butYeviEditorler);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.butYEviKitaplar);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.butEditorEkle);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.butKitapSil);
            this.Controls.Add(this.butKitapEkle);
            this.Controls.Add(this.butyEviEkle);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "fd";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button butyEviEkle;
        private Button butKitapEkle;
        private Button butKitapSil;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private Label label3;
        private TextBox textBox3;
        private Button butEditorEkle;
        private Label label4;
        private ListBox listBox2;
        private Button butYEviKitaplar;
        private Label label5;
        private Label label6;
        private ListBox listBox3;
        private Button butYeviEditorler;
        private Label label7;
        private ListBox listBox4;
        private Label label8;
    }
}