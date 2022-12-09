using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdevDizi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String[] kullanicigirisleri = new String[4];
        private void button1_Click(object sender, EventArgs e)
        {
            String[] kullanicigirisleri = new String[4];
            kullanicigirisleri[0] = "Fatma";
            kullanicigirisleri[1] = "123";
            kullanicigirisleri[2] = "Kayra";
            kullanicigirisleri[3] = "456";

            if (kullaniciaditxt.Text == "Fatma" && sifretxt.Text == "123")
            {
                kullaniciaditxt.Clear();
                sifretxt.Clear();
                MessageBox.Show("Giriş Başarılı");
            }
            else if (kullaniciaditxt.Text == "Kayra" && sifretxt.Text == "456")
            {
                kullaniciaditxt.Clear();
                sifretxt.Clear();
                MessageBox.Show("Giriş Başarılı");
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı yok lütfen kayıt olunuz.");
            }

        }
        
        

        public void Form1_Load(object sender, EventArgs e)
        {
         
        }
    }
}
