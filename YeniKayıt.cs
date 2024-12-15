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
    public partial class YeniKayıt : Form
    {
        private string placeholder ;

        public YeniKayıt()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database2DataSet);

        }

        private void YeniKayıt_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'database2DataSet.Table' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tableTableAdapter.Fill(this.database2DataSet.Table);

        }

        private void markaLabel_Click(object sender, EventArgs e)
        {

        }

        private void modelLabel_Click(object sender, EventArgs e)
        {

        }

        private void yilLabel_Click(object sender, EventArgs e)
        {

        }

        private void gsmLabel_Click(object sender, EventArgs e)
        {

        }

        private void kmLabel_Click(object sender, EventArgs e)
        {

        }

        private void adLabel_Click(object sender, EventArgs e)
        {

        }

        private void soyadLabel_Click(object sender, EventArgs e)
        {

        }

        private void plakaLabel_Click(object sender, EventArgs e)
        {

        }

        private void grupLabel_Click(object sender, EventArgs e)
        {

        }

        private void motorNoLabel_Click(object sender, EventArgs e)
        {

        }

        private void sasiNoLabel_Click(object sender, EventArgs e)
        {

        }

        private void aciklamaLabel_Click(object sender, EventArgs e)
        {

        }

        private void fiyatLabel_Click(object sender, EventArgs e)
        {

        }

        private void adTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void modelTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.FillBy(this.database2DataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void tableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void KayıtListeleButon_Click(object sender, EventArgs e)
        {
            KayıtListele2 ff = new KayıtListele2();
            ff.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            {
              
            }
        }

        private void gsmTextBox_TextChanged(object sender, EventArgs e)
        {
           
            

            }
    }
}
