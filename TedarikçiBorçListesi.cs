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
    public partial class TedarikçiBorçListesi : Form
    {
        public TedarikçiBorçListesi()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tedarikçiBorçVeritabanıDataSet);

        }

        private void TedarikçiBorçListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'tedarikçiBorçVeritabanıDataSet.Table' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tableTableAdapter.Fill(this.tedarikçiBorçVeritabanıDataSet.Table);

        }

        private void tableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Tedarikçi_Borç_Ekle ff = new Tedarikçi_Borç_Ekle();
            ff.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Pdf Dosyası|*.pdf";
            save.OverwritePrompt = true;
            save.CreatePrompt = true;

            if (save.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
