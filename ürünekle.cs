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
    public partial class ürünekle : Form
    {
        public ürünekle()
        {
            InitializeComponent();
        }

        private void ürünekle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'üründatabaseDataSet.Table' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tableTableAdapter.Fill(this.üründatabaseDataSet.Table);

        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.üründatabaseDataSet);

        }

        private void alisFiyatMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void alisFiyatLabel_Click(object sender, EventArgs e)
        {

        }

        private void birimDomainUpDown_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void birimLabel_Click(object sender, EventArgs e)
        {

        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void oem_noTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void oem_noLabel_Click(object sender, EventArgs e)
        {

        }

        private void alisFiyatLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.FillBy(this.üründatabaseDataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.Fill(this.üründatabaseDataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void aramaToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.arama(this.üründatabaseDataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ürünlistele ff = new ürünlistele();
            ff.Show();
        }
    }
}
