namespace VP_Project1
{
    partial class Uplatuvanje
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
            this.tb_ime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboKonj = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_koeficient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_vkupno = new System.Windows.Forms.TextBox();
            this.tb_uplata = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_ime
            // 
            this.tb_ime.Location = new System.Drawing.Point(108, 11);
            this.tb_ime.Name = "tb_ime";
            this.tb_ime.Size = new System.Drawing.Size(121, 20);
            this.tb_ime.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Име на уплаќач";
            // 
            // comboKonj
            // 
            this.comboKonj.FormattingEnabled = true;
            this.comboKonj.Items.AddRange(new object[] {
            "Примариус",
            "Секундус",
            "Терциус",
            "Кватро"});
            this.comboKonj.Location = new System.Drawing.Point(108, 64);
            this.comboKonj.Name = "comboKonj";
            this.comboKonj.Size = new System.Drawing.Size(121, 21);
            this.comboKonj.TabIndex = 2;
            this.comboKonj.TextChanged += new System.EventHandler(this.comboKonj_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Избери Коњ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Коефициент";
            // 
            // tb_koeficient
            // 
            this.tb_koeficient.Enabled = false;
            this.tb_koeficient.Location = new System.Drawing.Point(187, 109);
            this.tb_koeficient.Name = "tb_koeficient";
            this.tb_koeficient.Size = new System.Drawing.Size(51, 20);
            this.tb_koeficient.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Износ на уплатата";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Уплати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Вкупно";
            // 
            // tb_vkupno
            // 
            this.tb_vkupno.Enabled = false;
            this.tb_vkupno.Location = new System.Drawing.Point(149, 197);
            this.tb_vkupno.Name = "tb_vkupno";
            this.tb_vkupno.Size = new System.Drawing.Size(100, 20);
            this.tb_vkupno.TabIndex = 9;
            // 
            // tb_uplata
            // 
            this.tb_uplata.Location = new System.Drawing.Point(149, 153);
            this.tb_uplata.Name = "tb_uplata";
            this.tb_uplata.Size = new System.Drawing.Size(100, 20);
            this.tb_uplata.TabIndex = 6;
            this.tb_uplata.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_uplata_KeyPress);
            this.tb_uplata.Leave += new System.EventHandler(this.tb_uplata_Leave);
            // 
            // Uplatuvanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_vkupno);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_uplata);
            this.Controls.Add(this.tb_koeficient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboKonj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ime);
            this.Name = "Uplatuvanje";
            this.Text = "Уплата";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_ime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboKonj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_koeficient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_vkupno;
        private System.Windows.Forms.TextBox tb_uplata;
    }
}