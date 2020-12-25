using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerConfigRest_096_Vyan_Insya_Nur_Muhammad
{
    public partial class Form1 : Form
    {

        Perintah perintah = new Perintah();


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonON_Click(object sender, EventArgs e)
        {
            buttonON.Enabled = false;
            buttonOFF.Enabled = true;

            label2.Text = "Server ON";
            label3.Text = "klik ON untuk Menjalankan Server";

            perintah.aktifkan();
        }

        private void buttonOFF_Click(object sender, EventArgs e)
        {
            buttonOFF.Enabled = false;
            buttonON.Enabled = true;

            label2.Text = "Server OFF";
            label3.Text = "klik OFF untuk Mematikan Server";

            perintah.matikan();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonOFF.Enabled = false;
            buttonON.Enabled = true;
        }
    }
}
