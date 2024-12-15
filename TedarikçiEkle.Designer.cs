
namespace WpfApp1
{
    partial class TedarikçiEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label tedarikciAdiLabel;
            System.Windows.Forms.Label sektörüLabel;
            System.Windows.Forms.Label yetkiliKisiAdiLabel;
            System.Windows.Forms.Label soyadiLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.Label faxLabel;
            System.Windows.Forms.Label eMailLabel;
            System.Windows.Forms.Label vergiDairesiLabel;
            System.Windows.Forms.Label vergiNoLabel;
            System.Windows.Forms.Label adresLabel;
            System.Windows.Forms.Label aciklamaLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TedarikçiEkle));
            this.tedarikçiVeriTabanıDataSet = new WpfApp1.TedarikçiVeriTabanıDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new WpfApp1.TedarikçiVeriTabanıDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new WpfApp1.TedarikçiVeriTabanıDataSetTableAdapters.TableAdapterManager();
            this.tableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tedarikciAdiTextBox = new System.Windows.Forms.TextBox();
            this.sektörüTextBox = new System.Windows.Forms.TextBox();
            this.yetkiliKisiAdiTextBox = new System.Windows.Forms.TextBox();
            this.soyadiTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.cepTextBox = new System.Windows.Forms.TextBox();
            this.faxTextBox = new System.Windows.Forms.TextBox();
            this.eMailTextBox = new System.Windows.Forms.TextBox();
            this.vergiDairesiTextBox = new System.Windows.Forms.TextBox();
            this.vergiNoTextBox = new System.Windows.Forms.TextBox();
            this.adresTextBox = new System.Windows.Forms.TextBox();
            this.aciklamaTextBox = new System.Windows.Forms.TextBox();
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tedarikciAdiLabel = new System.Windows.Forms.Label();
            sektörüLabel = new System.Windows.Forms.Label();
            yetkiliKisiAdiLabel = new System.Windows.Forms.Label();
            soyadiLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            eMailLabel = new System.Windows.Forms.Label();
            vergiDairesiLabel = new System.Windows.Forms.Label();
            vergiNoLabel = new System.Windows.Forms.Label();
            adresLabel = new System.Windows.Forms.Label();
            aciklamaLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tedarikçiVeriTabanıDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).BeginInit();
            this.tableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tedarikciAdiLabel
            // 
            tedarikciAdiLabel.AutoSize = true;
            tedarikciAdiLabel.BackColor = System.Drawing.Color.Transparent;
            tedarikciAdiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            tedarikciAdiLabel.ForeColor = System.Drawing.Color.Black;
            tedarikciAdiLabel.Location = new System.Drawing.Point(212, 104);
            tedarikciAdiLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            tedarikciAdiLabel.Name = "tedarikciAdiLabel";
            tedarikciAdiLabel.Size = new System.Drawing.Size(133, 24);
            tedarikciAdiLabel.TabIndex = 3;
            tedarikciAdiLabel.Text = "Tedarikçi Adı";
            tedarikciAdiLabel.Click += new System.EventHandler(this.tedarikciAdiLabel_Click);
            // 
            // sektörüLabel
            // 
            sektörüLabel.AutoSize = true;
            sektörüLabel.BackColor = System.Drawing.Color.Transparent;
            sektörüLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            sektörüLabel.ForeColor = System.Drawing.Color.Black;
            sektörüLabel.Location = new System.Drawing.Point(264, 156);
            sektörüLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            sektörüLabel.Name = "sektörüLabel";
            sektörüLabel.Size = new System.Drawing.Size(81, 24);
            sektörüLabel.TabIndex = 5;
            sektörüLabel.Text = "Sektörü";
            sektörüLabel.Click += new System.EventHandler(this.sektörüLabel_Click);
            // 
            // yetkiliKisiAdiLabel
            // 
            yetkiliKisiAdiLabel.AutoSize = true;
            yetkiliKisiAdiLabel.BackColor = System.Drawing.Color.Transparent;
            yetkiliKisiAdiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            yetkiliKisiAdiLabel.ForeColor = System.Drawing.Color.Black;
            yetkiliKisiAdiLabel.Location = new System.Drawing.Point(204, 204);
            yetkiliKisiAdiLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            yetkiliKisiAdiLabel.Name = "yetkiliKisiAdiLabel";
            yetkiliKisiAdiLabel.Size = new System.Drawing.Size(141, 24);
            yetkiliKisiAdiLabel.TabIndex = 7;
            yetkiliKisiAdiLabel.Text = "Yetkili Kişi Adı";
            yetkiliKisiAdiLabel.Click += new System.EventHandler(this.yetkiliKisiAdiLabel_Click);
            // 
            // soyadiLabel
            // 
            soyadiLabel.AutoSize = true;
            soyadiLabel.BackColor = System.Drawing.Color.Transparent;
            soyadiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            soyadiLabel.ForeColor = System.Drawing.Color.Black;
            soyadiLabel.Location = new System.Drawing.Point(735, 200);
            soyadiLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            soyadiLabel.Name = "soyadiLabel";
            soyadiLabel.Size = new System.Drawing.Size(73, 24);
            soyadiLabel.TabIndex = 9;
            soyadiLabel.Text = "Soyadı";
            soyadiLabel.Click += new System.EventHandler(this.soyadiLabel_Click);
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.BackColor = System.Drawing.Color.Transparent;
            telefonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            telefonLabel.ForeColor = System.Drawing.Color.Black;
            telefonLabel.Location = new System.Drawing.Point(261, 242);
            telefonLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(81, 24);
            telefonLabel.TabIndex = 11;
            telefonLabel.Text = "Telefon";
            telefonLabel.Click += new System.EventHandler(this.telefonLabel_Click);
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.BackColor = System.Drawing.Color.Transparent;
            cepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            cepLabel.ForeColor = System.Drawing.Color.Black;
            cepLabel.Location = new System.Drawing.Point(754, 255);
            cepLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(48, 24);
            cepLabel.TabIndex = 13;
            cepLabel.Text = "Cep";
            cepLabel.Click += new System.EventHandler(this.cepLabel_Click);
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.BackColor = System.Drawing.Color.Transparent;
            faxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            faxLabel.ForeColor = System.Drawing.Color.Black;
            faxLabel.Location = new System.Drawing.Point(297, 290);
            faxLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(45, 24);
            faxLabel.TabIndex = 15;
            faxLabel.Text = "Fax";
            faxLabel.Click += new System.EventHandler(this.faxLabel_Click);
            // 
            // eMailLabel
            // 
            eMailLabel.AutoSize = true;
            eMailLabel.BackColor = System.Drawing.Color.Transparent;
            eMailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            eMailLabel.ForeColor = System.Drawing.Color.Black;
            eMailLabel.Location = new System.Drawing.Point(738, 302);
            eMailLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            eMailLabel.Name = "eMailLabel";
            eMailLabel.Size = new System.Drawing.Size(69, 24);
            eMailLabel.TabIndex = 17;
            eMailLabel.Text = "E-mail";
            eMailLabel.Click += new System.EventHandler(this.eMailLabel_Click);
            // 
            // vergiDairesiLabel
            // 
            vergiDairesiLabel.AutoSize = true;
            vergiDairesiLabel.BackColor = System.Drawing.Color.Transparent;
            vergiDairesiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            vergiDairesiLabel.ForeColor = System.Drawing.Color.Black;
            vergiDairesiLabel.Location = new System.Drawing.Point(215, 338);
            vergiDairesiLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            vergiDairesiLabel.Name = "vergiDairesiLabel";
            vergiDairesiLabel.Size = new System.Drawing.Size(130, 24);
            vergiDairesiLabel.TabIndex = 19;
            vergiDairesiLabel.Text = "Vergi Dairesi";
            vergiDairesiLabel.Click += new System.EventHandler(this.vergiDairesiLabel_Click);
            // 
            // vergiNoLabel
            // 
            vergiNoLabel.AutoSize = true;
            vergiNoLabel.BackColor = System.Drawing.Color.Transparent;
            vergiNoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            vergiNoLabel.ForeColor = System.Drawing.Color.Black;
            vergiNoLabel.Location = new System.Drawing.Point(720, 350);
            vergiNoLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            vergiNoLabel.Name = "vergiNoLabel";
            vergiNoLabel.Size = new System.Drawing.Size(93, 24);
            vergiNoLabel.TabIndex = 21;
            vergiNoLabel.Text = "Vergi No";
            vergiNoLabel.Click += new System.EventHandler(this.vergiNoLabel_Click);
            // 
            // adresLabel
            // 
            adresLabel.AutoSize = true;
            adresLabel.BackColor = System.Drawing.Color.Transparent;
            adresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            adresLabel.ForeColor = System.Drawing.Color.Black;
            adresLabel.Location = new System.Drawing.Point(280, 386);
            adresLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            adresLabel.Name = "adresLabel";
            adresLabel.Size = new System.Drawing.Size(65, 24);
            adresLabel.TabIndex = 23;
            adresLabel.Text = "Adres";
            adresLabel.Click += new System.EventHandler(this.adresLabel_Click);
            // 
            // aciklamaLabel
            // 
            aciklamaLabel.AutoSize = true;
            aciklamaLabel.BackColor = System.Drawing.Color.Transparent;
            aciklamaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            aciklamaLabel.ForeColor = System.Drawing.Color.Black;
            aciklamaLabel.Location = new System.Drawing.Point(251, 471);
            aciklamaLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            aciklamaLabel.Name = "aciklamaLabel";
            aciklamaLabel.Size = new System.Drawing.Size(94, 24);
            aciklamaLabel.TabIndex = 25;
            aciklamaLabel.Text = "Açıklama";
            aciklamaLabel.Click += new System.EventHandler(this.aciklamaLabel_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(613, 38);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(292, 39);
            label1.TabIndex = 27;
            label1.Text = "Tedarikçi Kaydet";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tedarikçiVeriTabanıDataSet
            // 
            this.tedarikçiVeriTabanıDataSet.DataSetName = "TedarikçiVeriTabanıDataSet";
            this.tedarikçiVeriTabanıDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.tedarikçiVeriTabanıDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = WpfApp1.TedarikçiVeriTabanıDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableBindingNavigator
            // 
            this.tableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tableBindingNavigator.BindingSource = this.tableBindingSource;
            this.tableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.toolStripSeparator1,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator2,
            this.tableBindingNavigatorSaveItem,
            this.toolStripSeparator3,
            this.toolStripButton1});
            this.tableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableBindingNavigator.Name = "tableBindingNavigator";
            this.tableBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableBindingNavigator.Size = new System.Drawing.Size(1496, 25);
            this.tableBindingNavigator.TabIndex = 0;
            this.tableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(73, 22);
            this.bindingNavigatorAddNewItem.Text = "Yeni ekle";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Toplam öğe sayısı";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(39, 22);
            this.bindingNavigatorDeleteItem.Text = "Sil";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Başa taşı";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Öne taşı";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Konum";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(88, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Geçerli konum";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Arkaya taşı";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Sona taşı";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tableBindingNavigatorSaveItem
            // 
            this.tableBindingNavigatorSaveItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tableBindingNavigatorSaveItem.Image")));
            this.tableBindingNavigatorSaveItem.Name = "tableBindingNavigatorSaveItem";
            this.tableBindingNavigatorSaveItem.Size = new System.Drawing.Size(63, 22);
            this.tableBindingNavigatorSaveItem.Text = "Kaydet";
            this.tableBindingNavigatorSaveItem.Click += new System.EventHandler(this.tableBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(109, 22);
            this.toolStripButton1.Text = "Tedarikçi Listele";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tedarikciAdiTextBox
            // 
            this.tedarikciAdiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "tedarikciAdi", true));
            this.tedarikciAdiTextBox.Location = new System.Drawing.Point(357, 98);
            this.tedarikciAdiTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tedarikciAdiTextBox.Multiline = true;
            this.tedarikciAdiTextBox.Name = "tedarikciAdiTextBox";
            this.tedarikciAdiTextBox.Size = new System.Drawing.Size(814, 34);
            this.tedarikciAdiTextBox.TabIndex = 4;
            // 
            // sektörüTextBox
            // 
            this.sektörüTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "sektörü", true));
            this.sektörüTextBox.Location = new System.Drawing.Point(357, 146);
            this.sektörüTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.sektörüTextBox.Multiline = true;
            this.sektörüTextBox.Name = "sektörüTextBox";
            this.sektörüTextBox.Size = new System.Drawing.Size(814, 34);
            this.sektörüTextBox.TabIndex = 6;
            // 
            // yetkiliKisiAdiTextBox
            // 
            this.yetkiliKisiAdiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "yetkiliKisiAdi", true));
            this.yetkiliKisiAdiTextBox.Location = new System.Drawing.Point(357, 194);
            this.yetkiliKisiAdiTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.yetkiliKisiAdiTextBox.Multiline = true;
            this.yetkiliKisiAdiTextBox.Name = "yetkiliKisiAdiTextBox";
            this.yetkiliKisiAdiTextBox.Size = new System.Drawing.Size(361, 34);
            this.yetkiliKisiAdiTextBox.TabIndex = 8;
            // 
            // soyadiTextBox
            // 
            this.soyadiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "soyadi", true));
            this.soyadiTextBox.Location = new System.Drawing.Point(818, 194);
            this.soyadiTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.soyadiTextBox.Multiline = true;
            this.soyadiTextBox.Name = "soyadiTextBox";
            this.soyadiTextBox.Size = new System.Drawing.Size(354, 34);
            this.soyadiTextBox.TabIndex = 10;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "telefon", true));
            this.telefonTextBox.Location = new System.Drawing.Point(357, 242);
            this.telefonTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.telefonTextBox.Multiline = true;
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(361, 34);
            this.telefonTextBox.TabIndex = 12;
            // 
            // cepTextBox
            // 
            this.cepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "cep", true));
            this.cepTextBox.Location = new System.Drawing.Point(815, 242);
            this.cepTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cepTextBox.Multiline = true;
            this.cepTextBox.Name = "cepTextBox";
            this.cepTextBox.Size = new System.Drawing.Size(356, 34);
            this.cepTextBox.TabIndex = 14;
            // 
            // faxTextBox
            // 
            this.faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "fax", true));
            this.faxTextBox.Location = new System.Drawing.Point(357, 290);
            this.faxTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.faxTextBox.Multiline = true;
            this.faxTextBox.Name = "faxTextBox";
            this.faxTextBox.Size = new System.Drawing.Size(361, 34);
            this.faxTextBox.TabIndex = 16;
            // 
            // eMailTextBox
            // 
            this.eMailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "eMail", true));
            this.eMailTextBox.Location = new System.Drawing.Point(815, 296);
            this.eMailTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.eMailTextBox.Multiline = true;
            this.eMailTextBox.Name = "eMailTextBox";
            this.eMailTextBox.Size = new System.Drawing.Size(356, 34);
            this.eMailTextBox.TabIndex = 18;
            // 
            // vergiDairesiTextBox
            // 
            this.vergiDairesiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "vergiDairesi", true));
            this.vergiDairesiTextBox.Location = new System.Drawing.Point(357, 338);
            this.vergiDairesiTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.vergiDairesiTextBox.Multiline = true;
            this.vergiDairesiTextBox.Name = "vergiDairesiTextBox";
            this.vergiDairesiTextBox.Size = new System.Drawing.Size(361, 34);
            this.vergiDairesiTextBox.TabIndex = 20;
            // 
            // vergiNoTextBox
            // 
            this.vergiNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "vergiNo", true));
            this.vergiNoTextBox.Location = new System.Drawing.Point(815, 344);
            this.vergiNoTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.vergiNoTextBox.Multiline = true;
            this.vergiNoTextBox.Name = "vergiNoTextBox";
            this.vergiNoTextBox.Size = new System.Drawing.Size(356, 34);
            this.vergiNoTextBox.TabIndex = 22;
            // 
            // adresTextBox
            // 
            this.adresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "adres", true));
            this.adresTextBox.Location = new System.Drawing.Point(357, 386);
            this.adresTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.adresTextBox.Multiline = true;
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.Size = new System.Drawing.Size(814, 73);
            this.adresTextBox.TabIndex = 24;
            // 
            // aciklamaTextBox
            // 
            this.aciklamaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "aciklama", true));
            this.aciklamaTextBox.Location = new System.Drawing.Point(357, 471);
            this.aciklamaTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.aciklamaTextBox.Multiline = true;
            this.aciklamaTextBox.Name = "aciklamaTextBox";
            this.aciklamaTextBox.Size = new System.Drawing.Size(814, 71);
            this.aciklamaTextBox.TabIndex = 26;
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.AllowUserToOrderColumns = true;
            this.tableDataGridView.AutoGenerateColumns = false;
            this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.tableDataGridView.DataSource = this.tableBindingSource;
            this.tableDataGridView.Location = new System.Drawing.Point(0, 557);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.ReadOnly = true;
            this.tableDataGridView.Size = new System.Drawing.Size(1496, 220);
            this.tableDataGridView.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tedarikciAdi";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tedarikçi Adı";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sektörü";
            this.dataGridViewTextBoxColumn3.HeaderText = "Sektörü";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "yetkiliKisiAdi";
            this.dataGridViewTextBoxColumn4.HeaderText = "Yetkili Kişi";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "soyadi";
            this.dataGridViewTextBoxColumn5.HeaderText = "Soyadı";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "telefon";
            this.dataGridViewTextBoxColumn6.HeaderText = "Telefon";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "cep";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cep";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "fax";
            this.dataGridViewTextBoxColumn8.HeaderText = "Fax";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "eMail";
            this.dataGridViewTextBoxColumn9.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "vergiDairesi";
            this.dataGridViewTextBoxColumn10.HeaderText = "Vergi Dairesi";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "vergiNo";
            this.dataGridViewTextBoxColumn11.HeaderText = "Vergi No";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "adres";
            this.dataGridViewTextBoxColumn12.FillWeight = 150F;
            this.dataGridViewTextBoxColumn12.HeaderText = "Adres";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "aciklama";
            this.dataGridViewTextBoxColumn13.FillWeight = 200F;
            this.dataGridViewTextBoxColumn13.HeaderText = "Açıklama";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 200;
            // 
            // TedarikçiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1496, 746);
            this.Controls.Add(label1);
            this.Controls.Add(this.tableDataGridView);
            this.Controls.Add(tedarikciAdiLabel);
            this.Controls.Add(this.tedarikciAdiTextBox);
            this.Controls.Add(sektörüLabel);
            this.Controls.Add(this.sektörüTextBox);
            this.Controls.Add(yetkiliKisiAdiLabel);
            this.Controls.Add(this.yetkiliKisiAdiTextBox);
            this.Controls.Add(soyadiLabel);
            this.Controls.Add(this.soyadiTextBox);
            this.Controls.Add(telefonLabel);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(cepLabel);
            this.Controls.Add(this.cepTextBox);
            this.Controls.Add(faxLabel);
            this.Controls.Add(this.faxTextBox);
            this.Controls.Add(eMailLabel);
            this.Controls.Add(this.eMailTextBox);
            this.Controls.Add(vergiDairesiLabel);
            this.Controls.Add(this.vergiDairesiTextBox);
            this.Controls.Add(vergiNoLabel);
            this.Controls.Add(this.vergiNoTextBox);
            this.Controls.Add(adresLabel);
            this.Controls.Add(this.adresTextBox);
            this.Controls.Add(aciklamaLabel);
            this.Controls.Add(this.aciklamaTextBox);
            this.Controls.Add(this.tableBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TedarikçiEkle";
            this.Text = "Tedarikçi Ekle";
            this.Load += new System.EventHandler(this.TedarikçiEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tedarikçiVeriTabanıDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).EndInit();
            this.tableBindingNavigator.ResumeLayout(false);
            this.tableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TedarikçiVeriTabanıDataSet tedarikçiVeriTabanıDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private TedarikçiVeriTabanıDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private TedarikçiVeriTabanıDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tableBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox tedarikciAdiTextBox;
        private System.Windows.Forms.TextBox sektörüTextBox;
        private System.Windows.Forms.TextBox yetkiliKisiAdiTextBox;
        private System.Windows.Forms.TextBox soyadiTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox cepTextBox;
        private System.Windows.Forms.TextBox faxTextBox;
        private System.Windows.Forms.TextBox eMailTextBox;
        private System.Windows.Forms.TextBox vergiDairesiTextBox;
        private System.Windows.Forms.TextBox vergiNoTextBox;
        private System.Windows.Forms.TextBox adresTextBox;
        private System.Windows.Forms.TextBox aciklamaTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}