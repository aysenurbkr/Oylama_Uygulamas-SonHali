using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> secenekler;

        public Form1()
        {
            InitializeComponent();
            secenekler = new Dictionary<string, int>
            {
                { "Seçenek 1", 0 },
                { "Seçenek 2", 0 },
                { "Seçenek 3", 0 },
                { "Seçenek 4", 0 }
            };
            GuncelleListe();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btnOyVer.Click += new EventHandler(this.btnOyVer_Click);
            this.btnSonuclariGoster.Click += new EventHandler(this.btnSonuclariGoster_Click);
            this.btnSifirla.Click += new EventHandler(this.btnSifirla_Click);

            GuncelleListe();
        }

        private void GuncelleListe()
        {
            listBoxSecenekler.Items.Clear();
            foreach (var secenek in secenekler)
            {
                listBoxSecenekler.Items.Add($"{secenek.Key}: {secenek.Value} oy");
            }
        }

        private void btnOyVer_Click(object sender, EventArgs e)
        {
            if (listBoxSecenekler.SelectedIndex >= 0)
            {
                string secilenSecenek = listBoxSecenekler.SelectedItem.ToString().Split(':')[0].Trim();
                if (secilenSecenek != "")
                {
                    secenekler[secilenSecenek]++;
                    GuncelleListe();
                    MessageBox.Show($"{secilenSecenek} için oyunuz kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir seçenek seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSonuclariGoster_Click(object sender, EventArgs e)
        {
            string sonucMetni = "Sonuçlar:\n";
            foreach (var secenek in secenekler)
            {
                sonucMetni += $"{secenek.Key}: {secenek.Value} oy\n";
            }
            MessageBox.Show(sonucMetni, "Sonuçlar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            // Anahtarların bir kopyasını alarak işlem yapın
            var anahtarlar = secenekler.Keys.ToList();

            foreach (var secenek in anahtarlar)
            {
                secenekler[secenek] = 0;
            }

            GuncelleListe();
            MessageBox.Show("Tüm oylar sıfırlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
