using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientProxy_P4_073_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try {
                ServiceReference1.MatematikaClient obj = new ServiceReference1.MatematikaClient();

                double hasilTambah = obj.Tambah(1, 2);

                label1.Text = (("Hasil Tambah ") + ("1 + 2 = ") + hasilTambah.ToString());

                double hasilKurang = obj.Kurang(3, 2);

                label2.Text = (("Hasil Kurang ") + ("3 - 2 = ") + hasilKurang.ToString());

                double hasilKali = obj.Kali(2, 2);

                label3.Text = (("Hasil Kali ") + ("2 x 2 = ") + hasilKali.ToString());

                double hasilBagi = obj.Bagi(2, 2);

                label4.Text = (("Hasil Bagi ") + ("2 : 2 = ") + hasilBagi.ToString());


                ServiceReference1.Koordinat a = new ServiceReference1.Koordinat();
                ServiceReference1.Koordinat b = new ServiceReference1.Koordinat();

                a.X = 7;
                a.Y = 8;

                b.X = 5;
                b.Y = 6;

                double selisihX = a.X - b.X;
                double selisihY = a.Y - b.Y;

                double jarak = Math.Sqrt(Math.Pow(selisihX, 2) + Math.Pow(selisihY, 2));
                label5.Text = (("Hasil Koordinat = ") + jarak.ToString());
            }
            catch (FaultException<ServiceReference1.MathFault> mf)
            {
                Console.WriteLine(mf.Detail.Kode);
                Console.WriteLine(mf.Detail.Pesan);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
