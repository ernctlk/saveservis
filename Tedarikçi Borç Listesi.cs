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
    public partial class Tedarikçi_Borç_Ekle : Form
    {
        public Tedarikçi_Borç_Ekle()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tedarikçiBorçVeritabanıDataSet);

        }

        private void Tedarikçi_Borç_Listesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'tedarikçiBorçVeritabanıDataSet.Table' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tableTableAdapter.Fill(this.tedarikçiBorçVeritabanıDataSet.Table);

        }

        private void firmaLabel_Click(object sender, EventArgs e)
        {

        }

        private void firmaSorumluAdLabel_Click(object sender, EventArgs e)
        {

        }

        private void eMailLabel_Click(object sender, EventArgs e)
        {

        }

        private void cepLabel_Click(object sender, EventArgs e)
        {

        }

        private void borcBilgisiLabel_Click(object sender, EventArgs e)
        {

        }

        private void soyadLabel_Click(object sender, EventArgs e)
        {

        }

        private void faxLabel_Click(object sender, EventArgs e)
        {

        }

        private void borcTutariLabel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TedarikçiBorçListesi ff = new TedarikçiBorçListesi();
            ff.Show();
        }

        private void tableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
