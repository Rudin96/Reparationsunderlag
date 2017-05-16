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
            System.Windows.Forms.Label artikelnummerLabel;
            System.Windows.Forms.Label benämningLabel;
            System.Windows.Forms.Label levartnrLabel;
            System.Windows.Forms.Label levnrLabel;
            System.Windows.Forms.Label eANLabel;
            System.Windows.Forms.Label maskinLabel;
            System.Windows.Forms.Label inprisLabel;
            System.Windows.Forms.Label utprisLabel;
            System.Windows.Forms.Label marginalLabel;
            System.Windows.Forms.Label varugruppLabel;
            System.Windows.Forms.Label lagerplatsLabel;
            System.Windows.Forms.Label marginalkalkylLabel;
            System.Windows.Forms.Label leverantörLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.artikelnummerTextBox = new System.Windows.Forms.TextBox();
            this.artiklarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kassasystem_DataSet = new Reparationsunderlag.Kassasystem_DataSet();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.benämningTextBox = new System.Windows.Forms.TextBox();
            this.marginalkalkylTextBox = new System.Windows.Forms.TextBox();
            this.levartnrTextBox = new System.Windows.Forms.TextBox();
            this.lagerplatsTextBox = new System.Windows.Forms.TextBox();
            this.levnrTextBox = new System.Windows.Forms.TextBox();
            this.varugruppTextBox = new System.Windows.Forms.TextBox();
            this.eANTextBox = new System.Windows.Forms.TextBox();
            this.marginalTextBox = new System.Windows.Forms.TextBox();
            this.maskinTextBox = new System.Windows.Forms.TextBox();
            this.utprisTextBox = new System.Windows.Forms.TextBox();
            this.inprisTextBox = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
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
            artikelnummerLabel = new System.Windows.Forms.Label();
            benämningLabel = new System.Windows.Forms.Label();
            levartnrLabel = new System.Windows.Forms.Label();
            levnrLabel = new System.Windows.Forms.Label();
            eANLabel = new System.Windows.Forms.Label();
            maskinLabel = new System.Windows.Forms.Label();
            inprisLabel = new System.Windows.Forms.Label();
            utprisLabel = new System.Windows.Forms.Label();
            marginalLabel = new System.Windows.Forms.Label();
            varugruppLabel = new System.Windows.Forms.Label();
            lagerplatsLabel = new System.Windows.Forms.Label();
            marginalkalkylLabel = new System.Windows.Forms.Label();
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
            this.tabPage3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artiklarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kassasystem_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
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
            // artikelnummerLabel
            // 
            artikelnummerLabel.AutoSize = true;
            artikelnummerLabel.Location = new System.Drawing.Point(71, 82);
            artikelnummerLabel.Name = "artikelnummerLabel";
            artikelnummerLabel.Size = new System.Drawing.Size(76, 13);
            artikelnummerLabel.TabIndex = 0;
            artikelnummerLabel.Text = "Artikelnummer:";
            // 
            // benämningLabel
            // 
            benämningLabel.AutoSize = true;
            benämningLabel.Location = new System.Drawing.Point(84, 125);
            benämningLabel.Name = "benämningLabel";
            benämningLabel.Size = new System.Drawing.Size(63, 13);
            benämningLabel.TabIndex = 2;
            benämningLabel.Text = "Benämning:";
            // 
            // levartnrLabel
            // 
            levartnrLabel.AutoSize = true;
            levartnrLabel.Location = new System.Drawing.Point(98, 168);
            levartnrLabel.Name = "levartnrLabel";
            levartnrLabel.Size = new System.Drawing.Size(49, 13);
            levartnrLabel.TabIndex = 4;
            levartnrLabel.Text = "Levartnr:";
            // 
            // levnrLabel
            // 
            levnrLabel.AutoSize = true;
            levnrLabel.Location = new System.Drawing.Point(110, 207);
            levnrLabel.Name = "levnrLabel";
            levnrLabel.Size = new System.Drawing.Size(37, 13);
            levnrLabel.TabIndex = 6;
            levnrLabel.Text = "Levnr:";
            // 
            // eANLabel
            // 
            eANLabel.AutoSize = true;
            eANLabel.Location = new System.Drawing.Point(115, 249);
            eANLabel.Name = "eANLabel";
            eANLabel.Size = new System.Drawing.Size(32, 13);
            eANLabel.TabIndex = 8;
            eANLabel.Text = "EAN:";
            // 
            // maskinLabel
            // 
            maskinLabel.AutoSize = true;
            maskinLabel.Location = new System.Drawing.Point(103, 290);
            maskinLabel.Name = "maskinLabel";
            maskinLabel.Size = new System.Drawing.Size(44, 13);
            maskinLabel.TabIndex = 10;
            maskinLabel.Text = "Maskin:";
            // 
            // inprisLabel
            // 
            inprisLabel.AutoSize = true;
            inprisLabel.Location = new System.Drawing.Point(112, 330);
            inprisLabel.Name = "inprisLabel";
            inprisLabel.Size = new System.Drawing.Size(35, 13);
            inprisLabel.TabIndex = 12;
            inprisLabel.Text = "Inpris:";
            // 
            // utprisLabel
            // 
            utprisLabel.AutoSize = true;
            utprisLabel.Location = new System.Drawing.Point(110, 369);
            utprisLabel.Name = "utprisLabel";
            utprisLabel.Size = new System.Drawing.Size(37, 13);
            utprisLabel.TabIndex = 14;
            utprisLabel.Text = "Utpris:";
            // 
            // marginalLabel
            // 
            marginalLabel.AutoSize = true;
            marginalLabel.Location = new System.Drawing.Point(97, 410);
            marginalLabel.Name = "marginalLabel";
            marginalLabel.Size = new System.Drawing.Size(50, 13);
            marginalLabel.TabIndex = 16;
            marginalLabel.Text = "Marginal:";
            // 
            // varugruppLabel
            // 
            varugruppLabel.AutoSize = true;
            varugruppLabel.Location = new System.Drawing.Point(88, 453);
            varugruppLabel.Name = "varugruppLabel";
            varugruppLabel.Size = new System.Drawing.Size(59, 13);
            varugruppLabel.TabIndex = 18;
            varugruppLabel.Text = "Varugrupp:";
            // 
            // lagerplatsLabel
            // 
            lagerplatsLabel.AutoSize = true;
            lagerplatsLabel.Location = new System.Drawing.Point(88, 496);
            lagerplatsLabel.Name = "lagerplatsLabel";
            lagerplatsLabel.Size = new System.Drawing.Size(59, 13);
            lagerplatsLabel.TabIndex = 20;
            lagerplatsLabel.Text = "Lagerplats:";
            // 
            // marginalkalkylLabel
            // 
            marginalkalkylLabel.AutoSize = true;
            marginalkalkylLabel.Location = new System.Drawing.Point(70, 536);
            marginalkalkylLabel.Name = "marginalkalkylLabel";
            marginalkalkylLabel.Size = new System.Drawing.Size(77, 13);
            marginalkalkylLabel.TabIndex = 22;
            marginalkalkylLabel.Text = "Marginalkalkyl:";
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
            this.tabControl1.Controls.Add(this.tabPage3);
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
            reportDataSource7.Name = "Reparationsdataset";
            reportDataSource7.Value = this.ReparationsunderlagBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControl2);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1070, 737);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Produkter(BETA)";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1070, 737);
            this.tabControl2.TabIndex = 25;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.artikelnummerTextBox);
            this.tabPage2.Controls.Add(this.bindingNavigator2);
            this.tabPage2.Controls.Add(artikelnummerLabel);
            this.tabPage2.Controls.Add(marginalkalkylLabel);
            this.tabPage2.Controls.Add(this.benämningTextBox);
            this.tabPage2.Controls.Add(this.marginalkalkylTextBox);
            this.tabPage2.Controls.Add(benämningLabel);
            this.tabPage2.Controls.Add(lagerplatsLabel);
            this.tabPage2.Controls.Add(this.levartnrTextBox);
            this.tabPage2.Controls.Add(this.lagerplatsTextBox);
            this.tabPage2.Controls.Add(levartnrLabel);
            this.tabPage2.Controls.Add(varugruppLabel);
            this.tabPage2.Controls.Add(this.levnrTextBox);
            this.tabPage2.Controls.Add(this.varugruppTextBox);
            this.tabPage2.Controls.Add(levnrLabel);
            this.tabPage2.Controls.Add(marginalLabel);
            this.tabPage2.Controls.Add(this.eANTextBox);
            this.tabPage2.Controls.Add(this.marginalTextBox);
            this.tabPage2.Controls.Add(eANLabel);
            this.tabPage2.Controls.Add(utprisLabel);
            this.tabPage2.Controls.Add(this.maskinTextBox);
            this.tabPage2.Controls.Add(this.utprisTextBox);
            this.tabPage2.Controls.Add(maskinLabel);
            this.tabPage2.Controls.Add(inprisLabel);
            this.tabPage2.Controls.Add(this.inprisTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1062, 711);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Enkel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // artikelnummerTextBox
            // 
            this.artikelnummerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklarBindingSource, "Artikelnummer", true));
            this.artikelnummerTextBox.Location = new System.Drawing.Point(153, 79);
            this.artikelnummerTextBox.Name = "artikelnummerTextBox";
            this.artikelnummerTextBox.Size = new System.Drawing.Size(215, 20);
            this.artikelnummerTextBox.TabIndex = 1;
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
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator2.BindingSource = this.artiklarBindingSource;
            this.bindingNavigator2.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator2.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripButton1,
            this.toolStripComboBox1});
            this.bindingNavigator2.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator2.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator2.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator2.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator2.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator2.Size = new System.Drawing.Size(1056, 25);
            this.bindingNavigator2.TabIndex = 24;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Add new";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(85, 22);
            this.toolStripButton2.Text = "Spara produkt";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AcceptsReturn = true;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(30, 22);
            this.toolStripButton1.Text = "Sök";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripTextBox1_Validated);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Artikelnummer",
            "Benämning",
            "Leverantörens artikelnummer",
            "Leverantörsnummer",
            "EAN",
            "Varugrupp",
            "Lagerplats"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(170, 25);
            // 
            // benämningTextBox
            // 
            this.benämningTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklarBindingSource, "Benämning", true));
            this.benämningTextBox.Location = new System.Drawing.Point(153, 122);
            this.benämningTextBox.Name = "benämningTextBox";
            this.benämningTextBox.Size = new System.Drawing.Size(215, 20);
            this.benämningTextBox.TabIndex = 3;
            // 
            // marginalkalkylTextBox
            // 
            this.marginalkalkylTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklarBindingSource, "Marginalkalkyl", true));
            this.marginalkalkylTextBox.Location = new System.Drawing.Point(153, 533);
            this.marginalkalkylTextBox.Name = "marginalkalkylTextBox";
            this.marginalkalkylTextBox.Size = new System.Drawing.Size(215, 20);
            this.marginalkalkylTextBox.TabIndex = 23;
            // 
            // levartnrTextBox
            // 
            this.levartnrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklarBindingSource, "Levartnr", true));
            this.levartnrTextBox.Location = new System.Drawing.Point(153, 165);
            this.levartnrTextBox.Name = "levartnrTextBox";
            this.levartnrTextBox.Size = new System.Drawing.Size(215, 20);
            this.levartnrTextBox.TabIndex = 5;
            // 
            // lagerplatsTextBox
            // 
            this.lagerplatsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklarBindingSource, "Lagerplats", true));
            this.lagerplatsTextBox.Location = new System.Drawing.Point(153, 493);
            this.lagerplatsTextBox.Name = "lagerplatsTextBox";
            this.lagerplatsTextBox.Size = new System.Drawing.Size(215, 20);
            this.lagerplatsTextBox.TabIndex = 21;
            // 
            // levnrTextBox
            // 
            this.levnrTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklarBindingSource, "Levnr", true));
            this.levnrTextBox.Location = new System.Drawing.Point(153, 204);
            this.levnrTextBox.Name = "levnrTextBox";
            this.levnrTextBox.Size = new System.Drawing.Size(215, 20);
            this.levnrTextBox.TabIndex = 7;
            // 
            // varugruppTextBox
            // 
            this.varugruppTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklarBindingSource, "Varugrupp", true));
            this.varugruppTextBox.Location = new System.Drawing.Point(153, 450);
            this.varugruppTextBox.Name = "varugruppTextBox";
            this.varugruppTextBox.Size = new System.Drawing.Size(215, 20);
            this.varugruppTextBox.TabIndex = 19;
            // 
            // eANTextBox
            // 
            this.eANTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklarBindingSource, "EAN", true));
            this.eANTextBox.Location = new System.Drawing.Point(153, 246);
            this.eANTextBox.Name = "eANTextBox";
            this.eANTextBox.Size = new System.Drawing.Size(215, 20);
            this.eANTextBox.TabIndex = 9;
            // 
            // marginalTextBox
            // 
            this.marginalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklarBindingSource, "Marginal", true));
            this.marginalTextBox.Location = new System.Drawing.Point(153, 407);
            this.marginalTextBox.Name = "marginalTextBox";
            this.marginalTextBox.Size = new System.Drawing.Size(215, 20);
            this.marginalTextBox.TabIndex = 17;
            // 
            // maskinTextBox
            // 
            this.maskinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklarBindingSource, "Maskin", true));
            this.maskinTextBox.Location = new System.Drawing.Point(153, 287);
            this.maskinTextBox.Name = "maskinTextBox";
            this.maskinTextBox.Size = new System.Drawing.Size(215, 20);
            this.maskinTextBox.TabIndex = 11;
            // 
            // utprisTextBox
            // 
            this.utprisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklarBindingSource, "Utpris", true));
            this.utprisTextBox.Location = new System.Drawing.Point(153, 366);
            this.utprisTextBox.Name = "utprisTextBox";
            this.utprisTextBox.Size = new System.Drawing.Size(215, 20);
            this.utprisTextBox.TabIndex = 15;
            // 
            // inprisTextBox
            // 
            this.inprisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.artiklarBindingSource, "Inpris", true));
            this.inprisTextBox.Location = new System.Drawing.Point(153, 327);
            this.inprisTextBox.Name = "inprisTextBox";
            this.inprisTextBox.Size = new System.Drawing.Size(215, 20);
            this.inprisTextBox.TabIndex = 13;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.bindingNavigator3);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1062, 711);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Avancerat";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // bindingNavigator3
            // 
            this.bindingNavigator3.AddNewItem = this.toolStripButton3;
            this.bindingNavigator3.BindingSource = this.artiklarBindingSource;
            this.bindingNavigator3.CountItem = this.toolStripLabel1;
            this.bindingNavigator3.DeleteItem = this.toolStripButton4;
            this.bindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator2,
            this.toolStripTextBox2,
            this.toolStripLabel1,
            this.toolStripSeparator3,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripSeparator4,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton9,
            this.toolStripSeparator5,
            this.toolStripTextBox3,
            this.toolStripButton10,
            this.toolStripComboBox2});
            this.bindingNavigator3.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator3.MoveFirstItem = this.toolStripButton5;
            this.bindingNavigator3.MoveLastItem = this.toolStripButton8;
            this.bindingNavigator3.MoveNextItem = this.toolStripButton7;
            this.bindingNavigator3.MovePreviousItem = this.toolStripButton6;
            this.bindingNavigator3.Name = "bindingNavigator3";
            this.bindingNavigator3.PositionItem = this.toolStripTextBox2;
            this.bindingNavigator3.Size = new System.Drawing.Size(1056, 25);
            this.bindingNavigator3.TabIndex = 25;
            this.bindingNavigator3.Text = "bindingNavigator3";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Add new";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Delete";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Move first";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Move previous";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Position";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Current position";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Move next";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "Move last";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(85, 22);
            this.toolStripButton9.Text = "Spara produkt";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(30, 22);
            this.toolStripButton10.Text = "Sök";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Items.AddRange(new object[] {
            "Artikelnummer",
            "Benämning",
            "Leverantörens artikelnummer",
            "Leverantörsnummer",
            "EAN",
            "Varugrupp",
            "Lagerplats"});
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(170, 25);
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
            this.label1.Size = new System.Drawing.Size(155, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reparationsunderlag";
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
            this.tabPage3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.artiklarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kassasystem_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
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
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.ReparationsunderlagTableAdapter ReparationsunderlagTableAdapter;
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
        private PengvinDataset pengvinDataset;
        private System.Windows.Forms.BindingSource tSALJAREBindingSource;
        private PengvinDatasetTableAdapters.T_SALJARETableAdapter t_SALJARETableAdapter;
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
        private System.Windows.Forms.TabPage tabPage3;
        private Kassasystem_DataSet kassasystem_DataSet;
        private System.Windows.Forms.BindingSource artiklarBindingSource;
        private Kassasystem_DataSetTableAdapters.ArtiklarTableAdapter artiklarTableAdapter;
        private Kassasystem_DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox marginalkalkylTextBox;
        private System.Windows.Forms.TextBox lagerplatsTextBox;
        private System.Windows.Forms.TextBox varugruppTextBox;
        private System.Windows.Forms.TextBox marginalTextBox;
        private System.Windows.Forms.TextBox utprisTextBox;
        private System.Windows.Forms.TextBox inprisTextBox;
        private System.Windows.Forms.TextBox maskinTextBox;
        private System.Windows.Forms.TextBox eANTextBox;
        private System.Windows.Forms.TextBox levnrTextBox;
        private System.Windows.Forms.TextBox levartnrTextBox;
        private System.Windows.Forms.TextBox benämningTextBox;
        private System.Windows.Forms.TextBox artikelnummerTextBox;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
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
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ComboBox SupplierTextBox;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.ServiceProcess.ServiceController serviceController2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.BindingNavigator bindingNavigator3;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
    }
}