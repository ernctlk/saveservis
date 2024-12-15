using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WpfApp1
{
    public partial class TedarikçiEkle : Form
    {
        public TedarikçiEkle()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tedarikçiVeriTabanıDataSet);

        }

        private void TedarikçiEkle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'tedarikçiVeriTabanıDataSet.Table' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tableTableAdapter.Fill(this.tedarikçiVeriTabanıDataSet.Table);

        }

        private void sektörüLabel_Click(object sender, EventArgs e)
        {

        }

        private void yetkiliKisiAdiLabel_Click(object sender, EventArgs e)
        {

        }

        private void telefonLabel_Click(object sender, EventArgs e)
        {

        }

        private void faxLabel_Click(object sender, EventArgs e)
        {

        }

        private void vergiDairesiLabel_Click(object sender, EventArgs e)
        {

        }

        private void adresLabel_Click(object sender, EventArgs e)
        {

        }

        private void aciklamaLabel_Click(object sender, EventArgs e)
        {

        }

        private void vergiNoLabel_Click(object sender, EventArgs e)
        {

        }

        private void eMailLabel_Click(object sender, EventArgs e)
        {

        }

        private void tedarikciAdiLabel_Click(object sender, EventArgs e)
        {

        }

        private void cepLabel_Click(object sender, EventArgs e)
        {

        }

        private void soyadiLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TedarikçiListele ff = new TedarikçiListele();
            ff.Show();
        }
    }
}
