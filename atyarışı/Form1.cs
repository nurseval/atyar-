using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atyarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatsolauzaklik, ikinciatsolauzaklik, ucuncuatsolauzaklik;
        Random rastgele = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int birinciatgenislik = pictureBox1.Width;
            int ikinciatgenislik = pictureBox2.Width;
            int ucuncuatgenislik = pictureBox3.Width;

            int bitisuzaklik = label5.Left;
            pictureBox1.Left = pictureBox1.Left + rastgele.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rastgele.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rastgele.Next(5, 15);

            if (birinciatgenislik+ birinciatsolauzaklik +  pictureBox1.Left >= bitisuzaklik)
            {
                timer1.Enabled=false;
                MessageBox.Show("1 Numaralı at yarışı kazandı!!!");
            }
            if(ikinciatgenislik + ikinciatsolauzaklik + pictureBox2.Left>= bitisuzaklik)
            {
                timer1.Enabled = false;
                MessageBox.Show("2 numaralı at yarışı kazandı!!!");
            }
            if(ucuncuatgenislik+ucuncuatsolauzaklik+pictureBox3.Left >= bitisuzaklik)
            {
                timer1.Enabled = false;
                MessageBox.Show("3 numaralı at yarışı kazandı!!!");
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsolauzaklik = pictureBox1.Left;
            ikinciatsolauzaklik = pictureBox2.Left;
            ucuncuatsolauzaklik = pictureBox3.Left;
        }
    }
}
