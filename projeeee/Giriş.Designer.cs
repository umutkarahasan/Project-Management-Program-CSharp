namespace projeeee
{
    partial class Giriş
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.nightLabel1 = new ReaLTaiizor.Controls.NightLabel();
            this.nightLabel2 = new ReaLTaiizor.Controls.NightLabel();
            this.thunderButton1 = new ReaLTaiizor.Controls.ThunderButton();
            this.aloneTextBox1 = new ReaLTaiizor.Controls.AloneTextBox();
            this.aloneTextBox2 = new ReaLTaiizor.Controls.AloneTextBox();
            this.SuspendLayout();
            // 
            // nightLabel1
            // 
            this.nightLabel1.AutoSize = true;
            this.nightLabel1.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nightLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.nightLabel1.Location = new System.Drawing.Point(28, 111);
            this.nightLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nightLabel1.Name = "nightLabel1";
            this.nightLabel1.Size = new System.Drawing.Size(87, 15);
            this.nightLabel1.TabIndex = 1;
            this.nightLabel1.Text = "KULLANICI ADI";
            // 
            // nightLabel2
            // 
            this.nightLabel2.AutoSize = true;
            this.nightLabel2.BackColor = System.Drawing.Color.Transparent;
            this.nightLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nightLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.nightLabel2.Location = new System.Drawing.Point(28, 197);
            this.nightLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nightLabel2.Name = "nightLabel2";
            this.nightLabel2.Size = new System.Drawing.Size(35, 15);
            this.nightLabel2.TabIndex = 3;
            this.nightLabel2.Text = "ŞİFRE";
            // 
            // thunderButton1
            // 
            this.thunderButton1.BackColor = System.Drawing.Color.Transparent;
            this.thunderButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thunderButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.thunderButton1.Location = new System.Drawing.Point(317, 291);
            this.thunderButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.thunderButton1.Name = "thunderButton1";
            this.thunderButton1.Size = new System.Drawing.Size(221, 46);
            this.thunderButton1.TabIndex = 4;
            this.thunderButton1.Text = "GİRİŞ";
            this.thunderButton1.Click += new System.EventHandler(this.thunderButton1_Click);
            // 
            // aloneTextBox1
            // 
            this.aloneTextBox1.BackColor = System.Drawing.Color.White;
            this.aloneTextBox1.EnabledCalc = true;
            this.aloneTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.aloneTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.aloneTextBox1.Location = new System.Drawing.Point(168, 98);
            this.aloneTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aloneTextBox1.MaxLength = 32767;
            this.aloneTextBox1.MultiLine = false;
            this.aloneTextBox1.Name = "aloneTextBox1";
            this.aloneTextBox1.ReadOnly = false;
            this.aloneTextBox1.Size = new System.Drawing.Size(247, 29);
            this.aloneTextBox1.TabIndex = 6;
            this.aloneTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.aloneTextBox1.UseSystemPasswordChar = false;
            // 
            // aloneTextBox2
            // 
            this.aloneTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.aloneTextBox2.BackColor = System.Drawing.Color.White;
            this.aloneTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.aloneTextBox2.EnabledCalc = true;
            this.aloneTextBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.aloneTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(133)))), ((int)(((byte)(142)))));
            this.aloneTextBox2.Location = new System.Drawing.Point(168, 183);
            this.aloneTextBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aloneTextBox2.MaxLength = 32767;
            this.aloneTextBox2.MultiLine = false;
            this.aloneTextBox2.Name = "aloneTextBox2";
            this.aloneTextBox2.ReadOnly = false;
            this.aloneTextBox2.Size = new System.Drawing.Size(247, 29);
            this.aloneTextBox2.TabIndex = 7;
            this.aloneTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.aloneTextBox2.UseSystemPasswordChar = true;
            // 
            // Giriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 366);
            this.Controls.Add(this.aloneTextBox2);
            this.Controls.Add(this.aloneTextBox1);
            this.Controls.Add(this.thunderButton1);
            this.Controls.Add(this.nightLabel2);
            this.Controls.Add(this.nightLabel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Giriş";
            this.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.Giriş_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.NightLabel nightLabel1;
        private ReaLTaiizor.Controls.NightLabel nightLabel2;
        private ReaLTaiizor.Controls.ThunderButton thunderButton1;
        private ReaLTaiizor.Controls.AloneTextBox aloneTextBox1;
        private ReaLTaiizor.Controls.AloneTextBox aloneTextBox2;
    }
}

