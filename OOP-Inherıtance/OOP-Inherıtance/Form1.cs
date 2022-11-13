using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Inherıtance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ınsan ıns=new ınsan();
            ıns.ad = "M.emin";
            ıns.soyad = "Tok";
            ıns.kilo = 65;
            ıns.yaş = 20;

            Personel pers = new Personel();
            pers.departman = "Egitim";
            pers.boy = 175;
            pers.yer = "Manisa";
            pers.kilo = 72;
            pers.ad = "Mehmet Emin";
            label1.Text=pers.departman;
            label2.Text = pers.kilo.ToString();
            label3.Text = pers.boy.ToString();
            label4.Text = pers.yer.ToString();
            label5.Text = pers.ad.ToString();

        }
        
    }
}
