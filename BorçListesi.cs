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
    public partial class BorçListesi : Form
    {
        public BorçListesi()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tedarikçiBorçVeritabanıDataSet);

        }

        private void BorçListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'tedarikçiBorçVeritabanıDataSet.Table' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tableTableAdapter.Fill(this.tedarikçiBorçVeritabanıDataSet.Table);

        }
    }
}
