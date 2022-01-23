using Hamburger.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            doldur();
        }
        void doldur()
        {
            comboBox1.Items.Add(new Burger()
            {
                burgerFiyati = 50,
                burgerAdi = "BigKing"
            });
            comboBox1.Items.Add(new Burger()
            {
                burgerFiyati = 45,
                burgerAdi = "KingChicken"
            });
            comboBox1.Items.Add(new Burger()
            {
                burgerFiyati = 65,
                burgerAdi = "TexasBurger"
            });
        }
        private MenuSecim MenuSecim()
        {
            if (radioButton1.Checked)
            {
                return new MenuSecim()
                {
                    menuAdi = "Büyük Boy",
                    menuBuyutmeFiyati = 5
                };
            }
            else if (radioButton2.Checked)
            {
                return new MenuSecim()
                {
                    menuAdi = "King Boy",
                    menuBuyutmeFiyati = 8
                };
            }
            else
            {
                return new MenuSecim()
                {
                    menuAdi = "Orta Boy",
                    menuBuyutmeFiyati = 0
                };
            }
        }
        /*
         public List<string> MalzemeleriBul()
        {
            List<string> secilenMalzemeler = new List<string>();
            foreach (CheckBox item in grpMalzeme.Controls)
            {
                if(item.Checked)
                {
                    secilenMalzemeler.Add(item.Text);
                }
            }

            return secilenMalzemeler.Count >= 0
                ? secilenMalzemeler
                : null;
        }
         */
        public List<string> Malzeme()
        {
            List<string> Malzeme = new List<string>();
            foreach(CheckBox item in groupBox1.Controls)
            {
                if (item.Checked)
                {
                    Malzeme.Add(item.Text);
                }
            }
            return Malzeme.Count >= 0 ? Malzeme : null;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            IstSepet.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(IstSepet.SelectedItem.ToString(), "Sipariş Onay Ekranı",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Siparis s = new Siparis();
            s.menuSecim = MenuSecim();
            s.burger = comboBox1.SelectedItem as Burger;
            s.icecek = comboBox2.SelectedItem;
            s.Malzeme = Malzeme();
            s.adet = numericUpDown1.Value;
            IstSepet.Items.Add(s);
        }
    }
}
////////////////////////////////////////////////////////////////////////

/*if (checkBox1.Checked)
{
    return new List<string>()
    {
        malzemeAdi = "Nugget",
        malzemeFiyati = 5
    };
}
else if (checkBox2.Checked)
{
    return new Malzeme()
    {
        malzemeAdi = "Çıtır Peynir",
        malzemeFiyati = 8
    };
}
else if (checkBox3.Checked)
{
    return new Malzeme()
    {
        malzemeAdi = "Soğan Halkası",
        malzemeFiyati = 4
    };
}
else
{
    return new Malzeme()
    {
        malzemeAdi = "",
        malzemeFiyati = 0
    };
}*/