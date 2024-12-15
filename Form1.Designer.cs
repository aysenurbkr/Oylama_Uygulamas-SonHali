namespace WindowsFormsApp11
{
    partial class Form1
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
            this.listBoxSecenekler = new System.Windows.Forms.ListBox();
            this.btnOyVer = new System.Windows.Forms.Button();
            this.btnSonuclariGoster = new System.Windows.Forms.Button();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSecenekler
            // 
            this.listBoxSecenekler.FormattingEnabled = true;
            this.listBoxSecenekler.ItemHeight = 16;
            this.listBoxSecenekler.Items.AddRange(new object[] {
            "1.Çok iyi",
            "2.İdare eder",
            "3.Orta",
            "4.Berbat"});
            this.listBoxSecenekler.Location = new System.Drawing.Point(33, 24);
            this.listBoxSecenekler.Name = "listBoxSecenekler";
            this.listBoxSecenekler.Size = new System.Drawing.Size(120, 84);
            this.listBoxSecenekler.TabIndex = 0;
            // 
            // btnOyVer
            // 
            this.btnOyVer.Location = new System.Drawing.Point(230, 12);
            this.btnOyVer.Name = "btnOyVer";
            this.btnOyVer.Size = new System.Drawing.Size(101, 35);
            this.btnOyVer.TabIndex = 1;
            this.btnOyVer.Text = "Oy Ver";
            this.btnOyVer.UseVisualStyleBackColor = true;
            // 
            // btnSonuclariGoster
            // 
            this.btnSonuclariGoster.Location = new System.Drawing.Point(230, 53);
            this.btnSonuclariGoster.Name = "btnSonuclariGoster";
            this.btnSonuclariGoster.Size = new System.Drawing.Size(102, 39);
            this.btnSonuclariGoster.TabIndex = 2;
            this.btnSonuclariGoster.Text = "Sonuçlar:";
            this.btnSonuclariGoster.UseVisualStyleBackColor = true;
            // 
            // btnSifirla
            // 
            this.btnSifirla.Location = new System.Drawing.Point(230, 98);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(101, 41);
            this.btnSifirla.TabIndex = 3;
            this.btnSifirla.Text = "Sıfırla";
            this.btnSifirla.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.btnSonuclariGoster);
            this.Controls.Add(this.btnOyVer);
            this.Controls.Add(this.listBoxSecenekler);
            this.Name = "Form1";
            this.Text = "Anket_Oylama_Uygulamasi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSecenekler;
        private System.Windows.Forms.Button btnOyVer;
        private System.Windows.Forms.Button btnSonuclariGoster;
        private System.Windows.Forms.Button btnSifirla;
    }
}

