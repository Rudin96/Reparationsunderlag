using System;

namespace Reparationsunderlag
{
    partial class Form1
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
            System.Windows.Forms.Label dokumentIDLabel;
            System.Windows.Forms.Label dokumentDatumLabel;
            System.Windows.Forms.Label kundIDLabel;
            System.Windows.Forms.Label kundkontaktLabel;
            System.Windows.Forms.Label telefonnummerLabel;
            System.Windows.Forms.Label felbeskrivningLabel;
            System.Windows.Forms.Label användareLabel;
            System.Windows.Forms.Label garantiLabel;
            System.Windows.Forms.Label epostLabel;
            System.Windows.Forms.Label serienummerLabel;
            System.Windows.Forms.Label märkeLabel;
            System.Windows.Forms.Label maskintypLabel;
            System.Windows.Forms.Label leverantörLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ReparationsunderlagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Reparationsunderlag.DataSet1();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SupplierTextBox = new System.Windows.Forms.ComboBox();
            this.maskintypTextBox = new System.Windows.Forms.TextBox();
            this.märkeTextBox = new System.Windows.Forms.TextBox();
            this.GarantiBox = new System.Windows.Forms.CheckBox();
            this.serienummerTextBox = new System.Windows.Forms.TextBox();
            this.epostTextBox = new System.Windows.Forms.TextBox();
            this.användareComboBox = new System.Windows.Forms.ComboBox();
            this.tSALJAREBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pengvinDataset = new Reparationsunderlag.PengvinDataset();
            this.felbeskrivningTextBox = new System.Windows.Forms.TextBox();
            this.telefonnummerTextBox = new System.Windows.Forms.TextBox();
            this.kundkontaktTextBox = new System.Windows.Forms.TextBox();
            this.kundIDTextBox = new System.Windows.Forms.TextBox();
            this.dokumentDatumDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dokumentIDTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dokumentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dokumentDatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leverantörDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kundIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kundkontaktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.felbeskrivningDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.användareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.garantiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serienummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.märkeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskintypDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artiklarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kassasystem_DataSet = new Reparationsunderlag.Kassasystem_DataSet();
            this.tSALJAREBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReparationsunderlagTableAdapter = new Reparationsunderlag.DataSet1TableAdapters.ReparationsunderlagTableAdapter();
            this.tableAdapterManager = new Reparationsunderlag.DataSet1TableAdapters.TableAdapterManager();
            this.t_SALJARETableAdapter = new Reparationsunderlag.PengvinDatasetTableAdapters.T_SALJARETableAdapter();
            this.reparationsunderlagBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reparationsunderlag_UrvalTableAdapter = new Reparationsunderlag.DataSet1TableAdapters.Reparationsunderlag_UrvalTableAdapter();
            this.ReportViewerContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.skrivUtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exporteraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arkivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sparaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skrivUtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.visaÄndringsloggToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.omToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avslutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artiklarTableAdapter = new Reparationsunderlag.Kassasystem_DataSetTableAdapters.ArtiklarTableAdapter();
            this.tableAdapterManager1 = new Reparationsunderlag.Kassasystem_DataSetTableAdapters.TableAdapterManager();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.serviceController2 = new System.ServiceProcess.ServiceController();
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            dokumentIDLabel = new System.Windows.Forms.Label();
            dokumentDatumLabel = new System.Windows.Forms.Label();
            kundIDLabel = new System.Windows.Forms.Label();
            kundkontaktLabel = new System.Windows.Forms.Label();
            telefonnummerLabel = new System.Windows.Forms.Label();
            felbeskrivningLabel = new System.Windows.Forms.Label();
            användareLabel = new System.Windows.Forms.Label();
            garantiLabel = new System.Windows.Forms.Label();
            epostLabel = new System.Windows.Forms.Label();
            serienummerLabel = new System.Windows.Forms.Label();
            märkeLabel = new System.Windows.Forms.Label();
            maskintypLabel = new System.Windows.Forms.Label();
            leverantörLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReparationsunderlagBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tSALJAREBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pengvinDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kassasystem_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSALJAREBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reparationsunderlagBindingSource1)).BeginInit();
            this.ReportViewerContextMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dokumentIDLabel
            // 
            dokumentIDLabel.AutoSize = true;
            dokumentIDLabel.Location = new System.Drawing.Point(106, 50);
            dokumentIDLabel.Name = "dokumentIDLabel";
            dokumentIDLabel.Size = new System.Drawing.Size(73, 13);
            dokumentIDLabel.TabIndex = 1;
            dokumentIDLabel.Text = "Dokument ID:";
            // 
            // dokumentDatumLabel
            // 
            dokumentDatumLabel.AutoSize = true;
            dokumentDatumLabel.Location = new System.Drawing.Point(86, 102);
            dokumentDatumLabel.Name = "dokumentDatumLabel";
            dokumentDatumLabel.Size = new System.Drawing.Size(93, 13);
            dokumentDatumLabel.TabIndex = 3;
            dokumentDatumLabel.Text = "Dokument Datum:";
            // 
            // kundIDLabel
            // 
            kundIDLabel.AutoSize = true;
            kundIDLabel.Location = new System.Drawing.Point(144, 193);
            kundIDLabel.Name = "kundIDLabel";
            kundIDLabel.Size = new System.Drawing.Size(35, 13);
            kundIDLabel.TabIndex = 7;
            kundIDLabel.Text = "Kund:";
            // 
            // kundkontaktLabel
            // 
            kundkontaktLabel.AutoSize = true;
            kundkontaktLabel.Location = new System.Drawing.Point(99, 235);
            kundkontaktLabel.Name = "kundkontaktLabel";
            kundkontaktLabel.Size = new System.Drawing.Size(79, 13);
            kundkontaktLabel.TabIndex = 9;
            kundkontaktLabel.Text = "Kontaktperson:";
            // 
            // telefonnummerLabel
            // 
            telefonnummerLabel.AutoSize = true;
            telefonnummerLabel.Location = new System.Drawing.Point(96, 325);
            telefonnummerLabel.Name = "telefonnummerLabel";
            telefonnummerLabel.Size = new System.Drawing.Size(83, 13);
            telefonnummerLabel.TabIndex = 11;
            telefonnummerLabel.Text = "Telefonnummer:";
            // 
            // felbeskrivningLabel
            // 
            felbeskrivningLabel.AutoSize = true;
            felbeskrivningLabel.Location = new System.Drawing.Point(101, 497);
            felbeskrivningLabel.Name = "felbeskrivningLabel";
            felbeskrivningLabel.Size = new System.Drawing.Size(78, 13);
            felbeskrivningLabel.TabIndex = 13;
            felbeskrivningLabel.Text = "Felbeskrivning:";
            // 
            // användareLabel
            // 
            användareLabel.AutoSize = true;
            användareLabel.Location = new System.Drawing.Point(117, 668);
            användareLabel.Name = "användareLabel";
            användareLabel.Size = new System.Drawing.Size(62, 13);
            användareLabel.TabIndex = 15;
            användareLabel.Text = "Användare:";
            // 
            // garantiLabel
            // 
            garantiLabel.AutoSize = true;
            garantiLabel.Location = new System.Drawing.Point(134, 628);
            garantiLabel.Name = "garantiLabel";
            garantiLabel.Size = new System.Drawing.Size(44, 13);
            garantiLabel.TabIndex = 17;
            garantiLabel.Text = "Garanti:";
            // 
            // epostLabel
            // 
            epostLabel.AutoSize = true;
            epostLabel.Location = new System.Drawing.Point(142, 368);
            epostLabel.Name = "epostLabel";
            epostLabel.Size = new System.Drawing.Size(37, 13);
            epostLabel.TabIndex = 19;
            epostLabel.Text = "Epost:";
            // 
            // serienummerLabel
            // 
            serienummerLabel.AutoSize = true;
            serienummerLabel.Location = new System.Drawing.Point(108, 410);
            serienummerLabel.Name = "serienummerLabel";
            serienummerLabel.Size = new System.Drawing.Size(71, 13);
            serienummerLabel.TabIndex = 21;
            serienummerLabel.Text = "Serienummer:";
            // 
            // märkeLabel
            // 
            märkeLabel.AutoSize = true;
            märkeLabel.Location = new System.Drawing.Point(125, 279);
            märkeLabel.Name = "märkeLabel";
            märkeLabel.Size = new System.Drawing.Size(54, 13);
            märkeLabel.TabIndex = 23;
            märkeLabel.Text = "Märkning:";
            // 
            // maskintypLabel
            // 
            maskintypLabel.AutoSize = true;
            maskintypLabel.Location = new System.Drawing.Point(121, 456);
            maskintypLabel.Name = "maskintypLabel";
            maskintypLabel.Size = new System.Drawing.Size(58, 13);
            maskintypLabel.TabIndex = 25;
            maskintypLabel.Text = "Maskintyp:";
            // 
            // leverantörLabel
            // 
            leverantörLabel.AutoSize = true;
            leverantörLabel.Location = new System.Drawing.Point(118, 148);
            leverantörLabel.Name = "leverantörLabel";
            leverantörLabel.Size = new System.Drawing.Size(61, 13);
            leverantörLabel.TabIndex = 26;
            leverantörLabel.Text = "Leverantör:";
            // 
            // ReparationsunderlagBindingSource
            // 
            this.ReparationsunderlagBindingSource.DataMember = "Reparationsunderlag";
            this.ReparationsunderlagBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(82, 25);
            this.tabControl1.Location = new System.Drawing.Point(0, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1078, 770);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1070, 737);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Skriv Underlag";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(leverantörLabel);
            this.splitContainer1.Panel1.Controls.Add(this.SupplierTextBox);
            this.splitContainer1.Panel1.Controls.Add(maskintypLabel);
            this.splitContainer1.Panel1.Controls.Add(this.maskintypTextBox);
            this.splitContainer1.Panel1.Controls.Add(märkeLabel);
            this.splitContainer1.Panel1.Controls.Add(this.märkeTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.GarantiBox);
            this.splitContainer1.Panel1.Controls.Add(serienummerLabel);
            this.splitContainer1.Panel1.Controls.Add(this.serienummerTextBox);
            this.splitContainer1.Panel1.Controls.Add(epostLabel);
            this.splitContainer1.Panel1.Controls.Add(this.epostTextBox);
            this.splitContainer1.Panel1.Controls.Add(garantiLabel);
            this.splitContainer1.Panel1.Controls.Add(användareLabel);
            this.splitContainer1.Panel1.Controls.Add(this.användareComboBox);
            this.splitContainer1.Panel1.Controls.Add(felbeskrivningLabel);
            this.splitContainer1.Panel1.Controls.Add(this.felbeskrivningTextBox);
            this.splitContainer1.Panel1.Controls.Add(telefonnummerLabel);
            this.splitContainer1.Panel1.Controls.Add(this.telefonnummerTextBox);
            this.splitContainer1.Panel1.Controls.Add(kundkontaktLabel);
            this.splitContainer1.Panel1.Controls.Add(this.kundkontaktTextBox);
            this.splitContainer1.Panel1.Controls.Add(kundIDLabel);
            this.splitContainer1.Panel1.Controls.Add(this.kundIDTextBox);
            this.splitContainer1.Panel1.Controls.Add(dokumentDatumLabel);
            this.splitContainer1.Panel1.Controls.Add(this.dokumentDatumDateTimePicker);
            this.splitContainer1.Panel1.Controls.Add(dokumentIDLabel);
            this.splitContainer1.Panel1.Controls.Add(this.dokumentIDTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.bindingNavigator1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer1.Size = new System.Drawing.Size(1064, 731);
            this.splitContainer1.SplitterDistance = 556;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // SupplierTextBox
            // 
            this.SupplierTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.SupplierTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SupplierTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ReparationsunderlagBindingSource, "Leverantör", true));
            this.SupplierTextBox.FormattingEnabled = true;
            this.SupplierTextBox.Items.AddRange(new object[] {
            "MEKINA(STIMUS)",
            "SLIPKLINIKEN"});
            this.SupplierTextBox.Location = new System.Drawing.Point(185, 145);
            this.SupplierTextBox.Name = "SupplierTextBox";
            this.SupplierTextBox.Size = new System.Drawing.Size(200, 21);
            this.SupplierTextBox.TabIndex = 6;
            this.SupplierTextBox.Leave += new System.EventHandler(this.saveToolStripButton_Click);
            this.SupplierTextBox.Validated += new System.EventHandler(this.UpdateReport);
            // 
            // maskintypTextBox
            // 
            this.maskintypTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ReparationsunderlagBindingSource, "Maskintyp", true));
            this.maskintypTextBox.Location = new System.Drawing.Point(185, 453);
            this.maskintypTextBox.Name = "maskintypTextBox";
            this.maskintypTextBox.Size = new System.Drawing.Size(200, 20);
            this.maskintypTextBox.TabIndex = 17;
            this.maskintypTextBox.Validated += new System.EventHandler(this.UpdateReport);
            // 
            // märkeTextBox
            // 
            this.märkeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ReparationsunderlagBindingSource, "Märke", true));
            this.märkeTextBox.Location = new System.Drawing.Point(185, 276);
            this.märkeTextBox.Name = "märkeTextBox";
            this.märkeTextBox.Size = new System.Drawing.Size(200, 20);
            this.märkeTextBox.TabIndex = 11;
            this.märkeTextBox.Leave += new System.EventHandler(this.saveToolStripButton_Click);
            this.märkeTextBox.Validated += new System.EventHandler(this.UpdateReport);
            // 
            // GarantiBox
            // 
            this.GarantiBox.AutoSize = true;
            this.GarantiBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.ReparationsunderlagBindingSource, "Garanti", true));
            this.GarantiBox.Location = new System.Drawing.Point(185, 628);
            this.GarantiBox.Name = "GarantiBox";
            this.GarantiBox.Size = new System.Drawing.Size(15, 14);
            this.GarantiBox.TabIndex = 21;
            this.GarantiBox.UseVisualStyleBackColor = true;
            this.GarantiBox.CheckedChanged += new System.EventHandler(this.UpdateReport);
            this.GarantiBox.CheckStateChanged += new System.EventHandler(this.UpdateReport);
            this.GarantiBox.Leave += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // serienummerTextBox
            // 
            this.serienummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ReparationsunderlagBindingSource, "Serienummer", true));
            this.serienummerTextBox.Location = new System.Drawing.Point(185, 407);
            this.serienummerTextBox.Name = "serienummerTextBox";
            this.serienummerTextBox.Size = new System.Drawing.Size(200, 20);
            this.serienummerTextBox.TabIndex = 15;
            this.serienummerTextBox.Leave += new System.EventHandler(this.saveToolStripButton_Click);
            this.serienummerTextBox.Validated += new System.EventHandler(this.UpdateReport);
            // 
            // epostTextBox
            // 
            this.epostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ReparationsunderlagBindingSource, "Epost", true));
            this.epostTextBox.Location = new System.Drawing.Point(185, 365);
            this.epostTextBox.Name = "epostTextBox";
            this.epostTextBox.Size = new System.Drawing.Size(200, 20);
            this.epostTextBox.TabIndex = 13;
            this.epostTextBox.Leave += new System.EventHandler(this.saveToolStripButton_Click);
            this.epostTextBox.Validated += new System.EventHandler(this.UpdateReport);
            // 
            // användareComboBox
            // 
            this.användareComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.användareComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.användareComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ReparationsunderlagBindingSource, "Användare", true));
            this.användareComboBox.DataSource = this.tSALJAREBindingSource1;
            this.användareComboBox.DisplayMember = "NAMN";
            this.användareComboBox.FormattingEnabled = true;
            this.användareComboBox.Location = new System.Drawing.Point(185, 665);
            this.användareComboBox.Name = "användareComboBox";
            this.användareComboBox.Size = new System.Drawing.Size(200, 21);
            this.användareComboBox.TabIndex = 23;
            this.användareComboBox.ValueMember = "SALJARE";
            this.användareComboBox.TextChanged += new System.EventHandler(this.UpdateReport);
            this.användareComboBox.Leave += new System.EventHandler(this.saveToolStripButton_Click);
            this.användareComboBox.Validated += new System.EventHandler(this.UpdateReport);
            // 
            // tSALJAREBindingSource1
            // 
            this.tSALJAREBindingSource1.DataMember = "T_SALJARE";
            this.tSALJAREBindingSource1.DataSource = this.pengvinDataset;
            // 
            // pengvinDataset
            // 
            this.pengvinDataset.DataSetName = "PengvinDataset";
            this.pengvinDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // felbeskrivningTextBox
            // 
            this.felbeskrivningTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ReparationsunderlagBindingSource, "Felbeskrivning", true));
            this.felbeskrivningTextBox.Location = new System.Drawing.Point(185, 494);
            this.felbeskrivningTextBox.Multiline = true;
            this.felbeskrivningTextBox.Name = "felbeskrivningTextBox";
            this.felbeskrivningTextBox.Size = new System.Drawing.Size(200, 108);
            this.felbeskrivningTextBox.TabIndex = 19;
            this.felbeskrivningTextBox.Leave += new System.EventHandler(this.saveToolStripButton_Click);
            this.felbeskrivningTextBox.Validated += new System.EventHandler(this.UpdateReport);
            // 
            // telefonnummerTextBox
            // 
            this.telefonnummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ReparationsunderlagBindingSource, "Telefonnummer", true));
            this.telefonnummerTextBox.Location = new System.Drawing.Point(185, 322);
            this.telefonnummerTextBox.Name = "telefonnummerTextBox";
            this.telefonnummerTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefonnummerTextBox.TabIndex = 12;
            this.telefonnummerTextBox.Leave += new System.EventHandler(this.saveToolStripButton_Click);
            this.telefonnummerTextBox.Validated += new System.EventHandler(this.UpdateReport);
            // 
            // kundkontaktTextBox
            // 
            this.kundkontaktTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ReparationsunderlagBindingSource, "Kundkontakt", true));
            this.kundkontaktTextBox.Location = new System.Drawing.Point(185, 235);
            this.kundkontaktTextBox.Name = "kundkontaktTextBox";
            this.kundkontaktTextBox.Size = new System.Drawing.Size(200, 20);
            this.kundkontaktTextBox.TabIndex = 10;
            this.kundkontaktTextBox.Leave += new System.EventHandler(this.saveToolStripButton_Click);
            this.kundkontaktTextBox.Validated += new System.EventHandler(this.UpdateReport);
            // 
            // kundIDTextBox
            // 
            this.kundIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ReparationsunderlagBindingSource, "KundID", true));
            this.kundIDTextBox.Location = new System.Drawing.Point(185, 190);
            this.kundIDTextBox.Name = "kundIDTextBox";
            this.kundIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.kundIDTextBox.TabIndex = 8;
            this.kundIDTextBox.Leave += new System.EventHandler(this.saveToolStripButton_Click);
            this.kundIDTextBox.Validated += new System.EventHandler(this.UpdateReport);
            // 
            // dokumentDatumDateTimePicker
            // 
            this.dokumentDatumDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ReparationsunderlagBindingSource, "DokumentDatum", true));
            this.dokumentDatumDateTimePicker.Location = new System.Drawing.Point(185, 98);
            this.dokumentDatumDateTimePicker.Name = "dokumentDatumDateTimePicker";
            this.dokumentDatumDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dokumentDatumDateTimePicker.TabIndex = 4;
            this.dokumentDatumDateTimePicker.ValueChanged += new System.EventHandler(this.UpdateReport);
            this.dokumentDatumDateTimePicker.Leave += new System.EventHandler(this.saveToolStripButton_Click);
            this.dokumentDatumDateTimePicker.Validated += new System.EventHandler(this.UpdateReport);
            // 
            // dokumentIDTextBox
            // 
            this.dokumentIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ReparationsunderlagBindingSource, "DokumentID", true));
            this.dokumentIDTextBox.Location = new System.Drawing.Point(185, 47);
            this.dokumentIDTextBox.Name = "dokumentIDTextBox";
            this.dokumentIDTextBox.ReadOnly = true;
            this.dokumentIDTextBox.Size = new System.Drawing.Size(62, 20);
            this.dokumentIDTextBox.TabIndex = 2;
            this.dokumentIDTextBox.TabStop = false;
            this.dokumentIDTextBox.TextChanged += new System.EventHandler(this.UpdateReport);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.ReparationsunderlagBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(556, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Antal poster";
            this.bindingNavigatorCountItem.Visible = false;
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(90, 22);
            this.bindingNavigatorDeleteItem.Text = "Ta bort post";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            this.bindingNavigatorSeparator.Visible = false;
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            this.bindingNavigatorPositionItem.Visible = false;
            this.bindingNavigatorPositionItem.TextChanged += new System.EventHandler(this.UpdateReport);
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            this.bindingNavigatorSeparator1.Visible = false;
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(110, 22);
            this.bindingNavigatorAddNewItem.Text = "Skriv nytt underlag";
            this.bindingNavigatorAddNewItem.ToolTipText = "Lägg till ny post";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Reparationsdataset";
            reportDataSource1.Value = this.ReparationsunderlagBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.reportViewer1.ServerReport.ReportPath = "/Reparationsunderlag/ReparationsUnderlag_Rapport";
            this.reportViewer1.ServerReport.ReportServerUrl = new System.Uri("http://192.168.0.117/reportserver", System.UriKind.Absolute);
            this.reportViewer1.ShowContextMenu = false;
            this.reportViewer1.ShowParameterPrompts = false;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(504, 731);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.reportViewer1.Print += new Microsoft.Reporting.WinForms.ReportPrintEventHandler(this.reportViewer1_SendPrintInfo);
            this.reportViewer1.PrintingBegin += new Microsoft.Reporting.WinForms.ReportPrintEventHandler(this.reportViewer1_SendPrintInfo);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1070, 737);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Historik";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dokumentIDDataGridViewTextBoxColumn,
            this.dokumentDatumDataGridViewTextBoxColumn,
            this.leverantörDataGridViewTextBoxColumn,
            this.kundIDDataGridViewTextBoxColumn,
            this.kundkontaktDataGridViewTextBoxColumn,
            this.telefonnummerDataGridViewTextBoxColumn,
            this.felbeskrivningDataGridViewTextBoxColumn,
            this.användareDataGridViewTextBoxColumn,
            this.garantiDataGridViewTextBoxColumn,
            this.epostDataGridViewTextBoxColumn,
            this.serienummerDataGridViewTextBoxColumn,
            this.märkeDataGridViewTextBoxColumn,
            this.maskintypDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ReparationsunderlagBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1070, 737);
            this.dataGridView1.TabIndex = 0;
            // 
            // dokumentIDDataGridViewTextBoxColumn
            // 
            this.dokumentIDDataGridViewTextBoxColumn.DataPropertyName = "DokumentID";
            this.dokumentIDDataGridViewTextBoxColumn.HeaderText = "DokumentID";
            this.dokumentIDDataGridViewTextBoxColumn.Name = "dokumentIDDataGridViewTextBoxColumn";
            this.dokumentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dokumentDatumDataGridViewTextBoxColumn
            // 
            this.dokumentDatumDataGridViewTextBoxColumn.DataPropertyName = "DokumentDatum";
            this.dokumentDatumDataGridViewTextBoxColumn.HeaderText = "DokumentDatum";
            this.dokumentDatumDataGridViewTextBoxColumn.Name = "dokumentDatumDataGridViewTextBoxColumn";
            this.dokumentDatumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // leverantörDataGridViewTextBoxColumn
            // 
            this.leverantörDataGridViewTextBoxColumn.DataPropertyName = "Leverantör";
            this.leverantörDataGridViewTextBoxColumn.HeaderText = "Leverantör";
            this.leverantörDataGridViewTextBoxColumn.Name = "leverantörDataGridViewTextBoxColumn";
            this.leverantörDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kundIDDataGridViewTextBoxColumn
            // 
            this.kundIDDataGridViewTextBoxColumn.DataPropertyName = "KundID";
            this.kundIDDataGridViewTextBoxColumn.HeaderText = "KundID";
            this.kundIDDataGridViewTextBoxColumn.Name = "kundIDDataGridViewTextBoxColumn";
            this.kundIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kundkontaktDataGridViewTextBoxColumn
            // 
            this.kundkontaktDataGridViewTextBoxColumn.DataPropertyName = "Kundkontakt";
            this.kundkontaktDataGridViewTextBoxColumn.HeaderText = "Kundkontakt";
            this.kundkontaktDataGridViewTextBoxColumn.Name = "kundkontaktDataGridViewTextBoxColumn";
            this.kundkontaktDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonnummerDataGridViewTextBoxColumn
            // 
            this.telefonnummerDataGridViewTextBoxColumn.DataPropertyName = "Telefonnummer";
            this.telefonnummerDataGridViewTextBoxColumn.HeaderText = "Telefonnummer";
            this.telefonnummerDataGridViewTextBoxColumn.Name = "telefonnummerDataGridViewTextBoxColumn";
            this.telefonnummerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // felbeskrivningDataGridViewTextBoxColumn
            // 
            this.felbeskrivningDataGridViewTextBoxColumn.DataPropertyName = "Felbeskrivning";
            this.felbeskrivningDataGridViewTextBoxColumn.HeaderText = "Felbeskrivning";
            this.felbeskrivningDataGridViewTextBoxColumn.Name = "felbeskrivningDataGridViewTextBoxColumn";
            this.felbeskrivningDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // användareDataGridViewTextBoxColumn
            // 
            this.användareDataGridViewTextBoxColumn.DataPropertyName = "Användare";
            this.användareDataGridViewTextBoxColumn.HeaderText = "Användare";
            this.användareDataGridViewTextBoxColumn.Name = "användareDataGridViewTextBoxColumn";
            this.användareDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // garantiDataGridViewTextBoxColumn
            // 
            this.garantiDataGridViewTextBoxColumn.DataPropertyName = "Garanti";
            this.garantiDataGridViewTextBoxColumn.HeaderText = "Garanti";
            this.garantiDataGridViewTextBoxColumn.Name = "garantiDataGridViewTextBoxColumn";
            this.garantiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // epostDataGridViewTextBoxColumn
            // 
            this.epostDataGridViewTextBoxColumn.DataPropertyName = "Epost";
            this.epostDataGridViewTextBoxColumn.HeaderText = "Epost";
            this.epostDataGridViewTextBoxColumn.Name = "epostDataGridViewTextBoxColumn";
            this.epostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serienummerDataGridViewTextBoxColumn
            // 
            this.serienummerDataGridViewTextBoxColumn.DataPropertyName = "Serienummer";
            this.serienummerDataGridViewTextBoxColumn.HeaderText = "Serienummer";
            this.serienummerDataGridViewTextBoxColumn.Name = "serienummerDataGridViewTextBoxColumn";
            this.serienummerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // märkeDataGridViewTextBoxColumn
            // 
            this.märkeDataGridViewTextBoxColumn.DataPropertyName = "Märke";
            this.märkeDataGridViewTextBoxColumn.HeaderText = "Märke";
            this.märkeDataGridViewTextBoxColumn.Name = "märkeDataGridViewTextBoxColumn";
            this.märkeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maskintypDataGridViewTextBoxColumn
            // 
            this.maskintypDataGridViewTextBoxColumn.DataPropertyName = "Maskintyp";
            this.maskintypDataGridViewTextBoxColumn.HeaderText = "Maskintyp";
            this.maskintypDataGridViewTextBoxColumn.Name = "maskintypDataGridViewTextBoxColumn";
            this.maskintypDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // artiklarBindingSource
            // 
            this.artiklarBindingSource.DataMember = "Artiklar";
            this.artiklarBindingSource.DataSource = this.kassasystem_DataSet;
            // 
            // kassasystem_DataSet
            // 
            this.kassasystem_DataSet.DataSetName = "Kassasystem_DataSet";
            this.kassasystem_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tSALJAREBindingSource
            // 
            this.tSALJAREBindingSource.DataMember = "T_SALJARE";
            this.tSALJAREBindingSource.DataSource = this.pengvinDataset;
            // 
            // ReparationsunderlagTableAdapter
            // 
            this.ReparationsunderlagTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AnvandareTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Reparationsunderlag_UrvalTableAdapter = null;
            this.tableAdapterManager.ReparationsunderlagTableAdapter = this.ReparationsunderlagTableAdapter;
            this.tableAdapterManager.UpdateOrder = Reparationsunderlag.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // t_SALJARETableAdapter
            // 
            this.t_SALJARETableAdapter.ClearBeforeFill = true;
            // 
            // reparationsunderlagBindingSource1
            // 
            this.reparationsunderlagBindingSource1.DataMember = "Reparationsunderlag";
            this.reparationsunderlagBindingSource1.DataSource = this.DataSet1;
            // 
            // reparationsunderlag_UrvalTableAdapter
            // 
            this.reparationsunderlag_UrvalTableAdapter.ClearBeforeFill = true;
            // 
            // ReportViewerContextMenu
            // 
            this.ReportViewerContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skrivUtToolStripMenuItem,
            this.exporteraToolStripMenuItem});
            this.ReportViewerContextMenu.Name = "ReportViewerContextMenu";
            this.ReportViewerContextMenu.Size = new System.Drawing.Size(124, 48);
            // 
            // skrivUtToolStripMenuItem
            // 
            this.skrivUtToolStripMenuItem.Name = "skrivUtToolStripMenuItem";
            this.skrivUtToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.skrivUtToolStripMenuItem.Text = "Skriv ut";
            // 
            // exporteraToolStripMenuItem
            // 
            this.exporteraToolStripMenuItem.Name = "exporteraToolStripMenuItem";
            this.exporteraToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exporteraToolStripMenuItem.Text = "Exportera";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Utskriften har skickats till skrivare.";
            this.notifyIcon1.BalloonTipTitle = "Utskrift";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Reparationsunderlag";
            this.notifyIcon1.Visible = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 799);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(975, -4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "_";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.minimeraToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(458, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reparationsunderlag - TEST";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1025, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.avslutaProgrammetToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkivToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1078, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            this.menuStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseUp);
            // 
            // arkivToolStripMenuItem
            // 
            this.arkivToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.arkivToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sparaToolStripMenuItem,
            this.skrivUtToolStripMenuItem1,
            this.visaÄndringsloggToolStripMenuItem,
            this.omToolStripMenuItem,
            this.avslutaToolStripMenuItem});
            this.arkivToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.arkivToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.arkivToolStripMenuItem.Name = "arkivToolStripMenuItem";
            this.arkivToolStripMenuItem.Size = new System.Drawing.Size(58, 25);
            this.arkivToolStripMenuItem.Text = "Arkiv";
            // 
            // sparaToolStripMenuItem
            // 
            this.sparaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sparaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sparaToolStripMenuItem.Name = "sparaToolStripMenuItem";
            this.sparaToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.sparaToolStripMenuItem.Text = "Spara";
            this.sparaToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // skrivUtToolStripMenuItem1
            // 
            this.skrivUtToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skrivUtToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.skrivUtToolStripMenuItem1.Name = "skrivUtToolStripMenuItem1";
            this.skrivUtToolStripMenuItem1.Size = new System.Drawing.Size(239, 26);
            this.skrivUtToolStripMenuItem1.Text = "Skriv ut";
            this.skrivUtToolStripMenuItem1.Click += new System.EventHandler(this.skrivUtToolStripMenuItem_Click);
            // 
            // visaÄndringsloggToolStripMenuItem
            // 
            this.visaÄndringsloggToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.visaÄndringsloggToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.visaÄndringsloggToolStripMenuItem.Name = "visaÄndringsloggToolStripMenuItem";
            this.visaÄndringsloggToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.visaÄndringsloggToolStripMenuItem.Text = "Visa Ändringslogg";
            this.visaÄndringsloggToolStripMenuItem.Click += new System.EventHandler(this.visaÄndringsloggToolStripMenuItem_Click);
            // 
            // omToolStripMenuItem
            // 
            this.omToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.omToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.omToolStripMenuItem.Name = "omToolStripMenuItem";
            this.omToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.omToolStripMenuItem.Text = "Fixa kontantinloggning";
            this.omToolStripMenuItem.Visible = false;
            this.omToolStripMenuItem.Click += new System.EventHandler(this.omToolStripMenuItem_Click);
            // 
            // avslutaToolStripMenuItem
            // 
            this.avslutaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.avslutaToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.avslutaToolStripMenuItem.Name = "avslutaToolStripMenuItem";
            this.avslutaToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.avslutaToolStripMenuItem.Text = "Avsluta";
            this.avslutaToolStripMenuItem.Click += new System.EventHandler(this.avslutaProgrammetToolStripMenuItem_Click);
            // 
            // artiklarTableAdapter
            // 
            this.artiklarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.ArtiklarTableAdapter = this.artiklarTableAdapter;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = Reparationsunderlag.Kassasystem_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // serviceController1
            // 
            this.serviceController1.MachineName = "SERVER2";
            this.serviceController1.ServiceName = "WAS";
            // 
            // serviceController2
            // 
            this.serviceController2.MachineName = "SERVER2";
            this.serviceController2.ServiceName = "W3SVC";
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1078, 799);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reparationsunderlag";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ReparationsunderlagBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tSALJAREBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pengvinDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.artiklarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kassasystem_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSALJAREBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reparationsunderlagBindingSource1)).EndInit();
            this.ReportViewerContextMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReparationsunderlagBindingSource;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
        private System.Windows.Forms.TextBox serienummerTextBox;
        private System.Windows.Forms.TextBox epostTextBox;
        private System.Windows.Forms.ComboBox användareComboBox;
        private System.Windows.Forms.TextBox felbeskrivningTextBox;
        private System.Windows.Forms.TextBox telefonnummerTextBox;
        private System.Windows.Forms.TextBox kundkontaktTextBox;
        private System.Windows.Forms.TextBox kundIDTextBox;
        private System.Windows.Forms.DateTimePicker dokumentDatumDateTimePicker;
        private System.Windows.Forms.TextBox dokumentIDTextBox;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tSALJAREBindingSource;
        private System.Windows.Forms.CheckBox GarantiBox;
        private System.Windows.Forms.BindingSource tSALJAREBindingSource1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.TextBox märkeTextBox;
        private System.Windows.Forms.BindingSource reparationsunderlagBindingSource1;
        private DataSet1TableAdapters.Reparationsunderlag_UrvalTableAdapter reparationsunderlag_UrvalTableAdapter;
        private System.Windows.Forms.TextBox maskintypTextBox;
        private System.Windows.Forms.ContextMenuStrip ReportViewerContextMenu;
        private System.Windows.Forms.ToolStripMenuItem skrivUtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exporteraToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arkivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sparaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visaÄndringsloggToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avslutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem omToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem skrivUtToolStripMenuItem1;
        private Kassasystem_DataSet kassasystem_DataSet;
        private System.Windows.Forms.BindingSource artiklarBindingSource;
        private Kassasystem_DataSetTableAdapters.ArtiklarTableAdapter artiklarTableAdapter;
        private Kassasystem_DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dokumentDatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leverantörDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kundIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kundkontaktDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn felbeskrivningDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn användareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn garantiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn epostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serienummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn märkeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maskintypDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox SupplierTextBox;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.ServiceProcess.ServiceController serviceController2;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        public DataSet1TableAdapters.ReparationsunderlagTableAdapter ReparationsunderlagTableAdapter;
        public PengvinDatasetTableAdapters.T_SALJARETableAdapter t_SALJARETableAdapter;
        public DataSet1 DataSet1;
        public PengvinDataset pengvinDataset;
    }
}