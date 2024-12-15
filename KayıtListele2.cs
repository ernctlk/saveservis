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

    public partial class KayıtListele2 : Form
    {
        public static object xls { get; internal set; }
        public static object txt { get; internal set; }

        public KayıtListele2()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database2DataSet);

        }

        private void KayıtListele2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'database2DataSet.Table' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tableTableAdapter.Fill(this.database2DataSet.Table);

        }

        private void tableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            YeniKayıt ff = new YeniKayıt();
            ff.Show();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {


        }

        internal static void WriteAllText(string fileName, object xls, Encoding uTF8)
        {
            throw new NotImplementedException();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {




        }

        private void toolStripTextBox1_Click_1(object sender, EventArgs e)
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

        private void aRA___ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tableTableAdapter.ARA___(this.database2DataSet.Table);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
