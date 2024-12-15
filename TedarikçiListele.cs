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
    public partial class TedarikçiListele : Form
    {
        public TedarikçiListele()
        {
            InitializeComponent();
        }

        public object Kayit { get; private set; }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tedarikçiVeriTabanıDataSet);

        }

        private void TedarikçiListele_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'tedarikçiVeriTabanıDataSet.Table' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tableTableAdapter.Fill(this.tedarikçiVeriTabanıDataSet.Table);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TedarikçiEkle ff = new TedarikçiEkle();
            ff.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
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

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.FillBy(this.tedarikçiVeriTabanıDataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.FillBy1(this.tedarikçiVeriTabanıDataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
