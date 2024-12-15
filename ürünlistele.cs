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
    public partial class ürünlistele : Form
    {
        public ürünlistele()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.üründatabaseDataSet);

        }

        private void ürünlistele_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'üründatabaseDataSet.Table' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tableTableAdapter.Fill(this.üründatabaseDataSet.Table);

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.FillBy1(this.üründatabaseDataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ürünekle ff = new ürünekle();
            ff.Show();
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
