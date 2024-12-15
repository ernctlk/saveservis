
namespace WpfApp1
{
    partial class Tedarikçi_Borç_Ekle
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
            System.Windows.Forms.Label firmaLabel;
            System.Windows.Forms.Label firmaSorumluAdLabel;
            System.Windows.Forms.Label soyadLabel;
            System.Windows.Forms.Label eMailLabel;
            System.Windows.Forms.Label cepLabel;
            System.Windows.Forms.Label faxLabel;
            System.Windows.Forms.Label borcBilgisiLabel;
            System.Windows.Forms.Label borcTutariLabel;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tedarikçi_Borç_Ekle));
            this.tedarikçiBorçVeritabanıDataSet = new WpfApp1.TedarikçiBorçVeritabanıDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new WpfApp1.TedarikçiBorçVeritabanıDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new WpfApp1.TedarikçiBorçVeritabanıDataSetTableAdapters.TableAdapterManager();
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
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.firmaTextBox = new System.Windows.Forms.TextBox();
            this.firmaSorumluAdTextBox = new System.Windows.Forms.TextBox();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.eMailTextBox = new System.Windows.Forms.TextBox();
            this.cepTextBox = new System.Windows.Forms.TextBox();
            this.faxTextBox = new System.Windows.Forms.TextBox();
            this.borcBilgisiTextBox = new System.Windows.Forms.TextBox();
            this.borcTutariTextBox = new System.Windows.Forms.TextBox();
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            firmaLabel = new System.Windows.Forms.Label();
            firmaSorumluAdLabel = new System.Windows.Forms.Label();
            soyadLabel = new System.Windows.Forms.Label();
            eMailLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            borcBilgisiLabel = new System.Windows.Forms.Label();
            borcTutariLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tedarikçiBorçVeritabanıDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).BeginInit();
            this.tableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // firmaLabel
            // 
            firmaLabel.AutoSize = true;
            firmaLabel.BackColor = System.Drawing.Color.Transparent;
            firmaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            firmaLabel.Location = new System.Drawing.Point(228, 149);
            firmaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            firmaLabel.Name = "firmaLabel";
            firmaLabel.Size = new System.Drawing.Size(63, 24);
            firmaLabel.TabIndex = 3;
            firmaLabel.Text = "Firma";
            firmaLabel.Click += new System.EventHandler(this.firmaLabel_Click);
            // 
            // firmaSorumluAdLabel
            // 
            firmaSorumluAdLabel.AutoSize = true;
            firmaSorumluAdLabel.BackColor = System.Drawing.Color.Transparent;
            firmaSorumluAdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            firmaSorumluAdLabel.Location = new System.Drawing.Point(112, 221);
            firmaSorumluAdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            firmaSorumluAdLabel.Name = "firmaSorumluAdLabel";
            firmaSorumluAdLabel.Size = new System.Drawing.Size(179, 24);
            firmaSorumluAdLabel.TabIndex = 5;
            firmaSorumluAdLabel.Text = "Firma Sorumlu Ad";
            firmaSorumluAdLabel.Click += new System.EventHandler(this.firmaSorumluAdLabel_Click);
            // 
            // soyadLabel
            // 
            soyadLabel.AutoSize = true;
            soyadLabel.BackColor = System.Drawing.Color.Transparent;
            soyadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            soyadLabel.Location = new System.Drawing.Point(572, 221);
            soyadLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            soyadLabel.Name = "soyadLabel";
            soyadLabel.Size = new System.Drawing.Size(68, 24);
            soyadLabel.TabIndex = 7;
            soyadLabel.Text = "Soyad";
            soyadLabel.Click += new System.EventHandler(this.soyadLabel_Click);
            // 
            // eMailLabel
            // 
            eMailLabel.AutoSize = true;
            eMailLabel.BackColor = System.Drawing.Color.Transparent;
            eMailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            eMailLabel.Location = new System.Drawing.Point(222, 261);
            eMailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            eMailLabel.Name = "eMailLabel";
            eMailLabel.Size = new System.Drawing.Size(69, 24);
            eMailLabel.TabIndex = 9;
            eMailLabel.Text = "E-Mail";
            eMailLabel.Click += new System.EventHandler(this.eMailLabel_Click);
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.BackColor = System.Drawing.Color.Transparent;
            cepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            cepLabel.Location = new System.Drawing.Point(243, 302);
            cepLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(48, 24);
            cepLabel.TabIndex = 11;
            cepLabel.Text = "Cep";
            cepLabel.Click += new System.EventHandler(this.cepLabel_Click);
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.BackColor = System.Drawing.Color.Transparent;
            faxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            faxLabel.Location = new System.Drawing.Point(595, 261);
            faxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(45, 24);
            faxLabel.TabIndex = 13;
            faxLabel.Text = "Fax";
            faxLabel.Click += new System.EventHandler(this.faxLabel_Click);
            // 
            // borcBilgisiLabel
            // 
            borcBilgisiLabel.AutoSize = true;
            borcBilgisiLabel.BackColor = System.Drawing.Color.Transparent;
            borcBilgisiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            borcBilgisiLabel.Location = new System.Drawing.Point(177, 342);
            borcBilgisiLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            borcBilgisiLabel.Name = "borcBilgisiLabel";
            borcBilgisiLabel.Size = new System.Drawing.Size(114, 24);
            borcBilgisiLabel.TabIndex = 15;
            borcBilgisiLabel.Text = "Broç Bilgisi";
            borcBilgisiLabel.Click += new System.EventHandler(this.borcBilgisiLabel_Click);
            // 
            // borcTutariLabel
            // 
            borcTutariLabel.AutoSize = true;
            borcTutariLabel.BackColor = System.Drawing.Color.Transparent;
            borcTutariLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            borcTutariLabel.Location = new System.Drawing.Point(528, 302);
            borcTutariLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            borcTutariLabel.Name = "borcTutariLabel";
            borcTutariLabel.Size = new System.Drawing.Size(112, 24);
            borcTutariLabel.TabIndex = 17;
            borcTutariLabel.Text = "Borç Tutarı";
            borcTutariLabel.Click += new System.EventHandler(this.borcTutariLabel_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label2.Location = new System.Drawing.Point(433, 59);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(321, 37);
            label2.TabIndex = 20;
            label2.Text = "Tedarikçi Borç Ekle ";
            // 
            // tedarikçiBorçVeritabanıDataSet
            // 
            this.tedarikçiBorçVeritabanıDataSet.DataSetName = "TedarikçiBorçVeritabanıDataSet";
            this.tedarikçiBorçVeritabanıDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.tedarikçiBorçVeritabanıDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = WpfApp1.TedarikçiBorçVeritabanıDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.toolStripSeparator2,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator1,
            this.tableBindingNavigatorSaveItem,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripSeparator4});
            this.tableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tableBindingNavigator.Name = "tableBindingNavigator";
            this.tableBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tableBindingNavigator.Size = new System.Drawing.Size(1198, 25);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 23);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(148, 22);
            this.toolStripButton1.Text = "Tedarikçi Borç Listesi";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // firmaTextBox
            // 
            this.firmaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "firma", true));
            this.firmaTextBox.Location = new System.Drawing.Point(299, 149);
            this.firmaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firmaTextBox.Multiline = true;
            this.firmaTextBox.Name = "firmaTextBox";
            this.firmaTextBox.Size = new System.Drawing.Size(615, 62);
            this.firmaTextBox.TabIndex = 4;
            // 
            // firmaSorumluAdTextBox
            // 
            this.firmaSorumluAdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "firmaSorumluAd", true));
            this.firmaSorumluAdTextBox.Location = new System.Drawing.Point(299, 221);
            this.firmaSorumluAdTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firmaSorumluAdTextBox.Multiline = true;
            this.firmaSorumluAdTextBox.Name = "firmaSorumluAdTextBox";
            this.firmaSorumluAdTextBox.Size = new System.Drawing.Size(218, 30);
            this.firmaSorumluAdTextBox.TabIndex = 6;
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "soyad", true));
            this.soyadTextBox.Location = new System.Drawing.Point(648, 221);
            this.soyadTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.soyadTextBox.Multiline = true;
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(266, 30);
            this.soyadTextBox.TabIndex = 8;
            // 
            // eMailTextBox
            // 
            this.eMailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "eMail", true));
            this.eMailTextBox.Location = new System.Drawing.Point(299, 261);
            this.eMailTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eMailTextBox.Multiline = true;
            this.eMailTextBox.Name = "eMailTextBox";
            this.eMailTextBox.Size = new System.Drawing.Size(218, 31);
            this.eMailTextBox.TabIndex = 10;
            // 
            // cepTextBox
            // 
            this.cepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "cep", true));
            this.cepTextBox.Location = new System.Drawing.Point(299, 302);
            this.cepTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cepTextBox.Multiline = true;
            this.cepTextBox.Name = "cepTextBox";
            this.cepTextBox.Size = new System.Drawing.Size(218, 30);
            this.cepTextBox.TabIndex = 12;
            // 
            // faxTextBox
            // 
            this.faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "fax", true));
            this.faxTextBox.Location = new System.Drawing.Point(648, 261);
            this.faxTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.faxTextBox.Multiline = true;
            this.faxTextBox.Name = "faxTextBox";
            this.faxTextBox.Size = new System.Drawing.Size(266, 31);
            this.faxTextBox.TabIndex = 14;
            // 
            // borcBilgisiTextBox
            // 
            this.borcBilgisiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "borcBilgisi", true));
            this.borcBilgisiTextBox.Location = new System.Drawing.Point(299, 342);
            this.borcBilgisiTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.borcBilgisiTextBox.Multiline = true;
            this.borcBilgisiTextBox.Name = "borcBilgisiTextBox";
            this.borcBilgisiTextBox.Size = new System.Drawing.Size(615, 85);
            this.borcBilgisiTextBox.TabIndex = 16;
            // 
            // borcTutariTextBox
            // 
            this.borcTutariTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "borcTutari", true));
            this.borcTutariTextBox.Location = new System.Drawing.Point(648, 302);
            this.borcTutariTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.borcTutariTextBox.Multiline = true;
            this.borcTutariTextBox.Name = "borcTutariTextBox";
            this.borcTutariTextBox.Size = new System.Drawing.Size(266, 30);
            this.borcTutariTextBox.TabIndex = 18;
            // 
            // tableDataGridView
            // 
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
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn8});
            this.tableDataGridView.DataSource = this.tableBindingSource;
            this.tableDataGridView.Location = new System.Drawing.Point(0, 468);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.ReadOnly = true;
            this.tableDataGridView.Size = new System.Drawing.Size(1200, 252);
            this.tableDataGridView.TabIndex = 20;
            this.tableDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.FillWeight = 60F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Id No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "firma";
            this.dataGridViewTextBoxColumn2.FillWeight = 150F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Firma";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "firmaSorumluAd";
            this.dataGridViewTextBoxColumn3.FillWeight = 120F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Firma Sorumlu Adı";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "soyad";
            this.dataGridViewTextBoxColumn4.FillWeight = 120F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Soyad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "eMail";
            this.dataGridViewTextBoxColumn5.FillWeight = 120F;
            this.dataGridViewTextBoxColumn5.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "cep";
            this.dataGridViewTextBoxColumn6.FillWeight = 120F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Cep";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "fax";
            this.dataGridViewTextBoxColumn7.FillWeight = 120F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Fax";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 120;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "borcTutari";
            this.dataGridViewTextBoxColumn9.FillWeight = 150F;
            this.dataGridViewTextBoxColumn9.HeaderText = "BorçTutarı";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "borcBilgisi";
            this.dataGridViewTextBoxColumn8.FillWeight = 220F;
            this.dataGridViewTextBoxColumn8.HeaderText = "Borç Bilgisi";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 220;
            // 
            // Tedarikçi_Borç_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1198, 718);
            this.Controls.Add(this.tableDataGridView);
            this.Controls.Add(label2);
            this.Controls.Add(firmaLabel);
            this.Controls.Add(this.firmaTextBox);
            this.Controls.Add(firmaSorumluAdLabel);
            this.Controls.Add(this.firmaSorumluAdTextBox);
            this.Controls.Add(soyadLabel);
            this.Controls.Add(this.soyadTextBox);
            this.Controls.Add(eMailLabel);
            this.Controls.Add(this.eMailTextBox);
            this.Controls.Add(cepLabel);
            this.Controls.Add(this.cepTextBox);
            this.Controls.Add(faxLabel);
            this.Controls.Add(this.faxTextBox);
            this.Controls.Add(borcBilgisiLabel);
            this.Controls.Add(this.borcBilgisiTextBox);
            this.Controls.Add(borcTutariLabel);
            this.Controls.Add(this.borcTutariTextBox);
            this.Controls.Add(this.tableBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Tedarikçi_Borç_Ekle";
            this.Text = "Tedarikçi Borç Ekle";
            this.Load += new System.EventHandler(this.Tedarikçi_Borç_Listesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tedarikçiBorçVeritabanıDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingNavigator)).EndInit();
            this.tableBindingNavigator.ResumeLayout(false);
            this.tableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TedarikçiBorçVeritabanıDataSet tedarikçiBorçVeritabanıDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private TedarikçiBorçVeritabanıDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private TedarikçiBorçVeritabanıDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private System.Windows.Forms.TextBox firmaTextBox;
        private System.Windows.Forms.TextBox firmaSorumluAdTextBox;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.TextBox eMailTextBox;
        private System.Windows.Forms.TextBox cepTextBox;
        private System.Windows.Forms.TextBox faxTextBox;
        private System.Windows.Forms.TextBox borcBilgisiTextBox;
        private System.Windows.Forms.TextBox borcTutariTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}