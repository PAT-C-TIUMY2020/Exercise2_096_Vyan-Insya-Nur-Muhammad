using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientRest_096_Vyan_Insya_Nur_Muhammad
{
    public partial class Form1 : Form
    {
        ClassData cData = new ClassData();


        public Form1()
        {
            InitializeComponent();
        }

        private void TampilData()
        {
            var daftar = cData.getAllData();
            dtMahasiswa.DataSource = daftar;
        }

        private void JumlahData()
        {
            var jmlh = cData.sumData();
            jmlhMahasiswa.Text = "Data mahasiswa saat ini adalah : "+ jmlh;

        }

        private void Clear()
        {
            textBoxNIM.Clear();
            textBoxNama.Clear();
            textBoxProdi.Clear();
            textBoxSrch.Clear();
            textBoxAngkatan.Clear();

            textBoxNIM.Enabled = true;

            btSimpan.Enabled = true;
            btUpdate.Enabled = false;
            btHapus.Enabled = false;

        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            Mahasiswa data = new Mahasiswa();
            data.nim = textBoxNIM.Text;
            data.nama = textBoxNama.Text;
            data.prodi = textBoxProdi.Text;
            data.angkatan = textBoxAngkatan.Text;

            var a = cData.createData(data);
            MessageBox.Show(a);
            TampilData();
            JumlahData();
            Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TampilData();
            JumlahData();

            btHapus.Enabled = false;
            btUpdate.Enabled = false;
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            Mahasiswa data = new Mahasiswa();
            data.nim = textBoxNIM.Text;
            data.nama = textBoxNama.Text;
            data.prodi = textBoxProdi.Text;
            data.angkatan = textBoxAngkatan.Text;

            var a = cData.updateData(data);
            MessageBox.Show(a);
            TampilData();
            JumlahData();
            Clear();
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            var a = cData.deleteData(textBoxNIM.Text);
            MessageBox.Show(a);
            TampilData();
            JumlahData();
            Clear();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void buttonSrch_Click(object sender, EventArgs e)
        {
            if (textBoxSrch.Text.Equals(""))
            {
                MessageBox.Show("Tolong data Diisi");
            }
            else
            {
                var data = cData.getDatabyNIM(textBoxSrch.Text);

                textBoxNIM.Text = data.nim;
                textBoxNama.Text = data.nama;
                textBoxProdi.Text = data.prodi;
                textBoxAngkatan.Text = data.angkatan;


                textBoxNIM.Enabled = false;

                btSimpan.Enabled = false;

                btHapus.Enabled = true;
                btUpdate.Enabled = true;
            }
            
        }
    }
}
