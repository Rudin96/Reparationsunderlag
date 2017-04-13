using Microsoft.Reporting.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;



namespace Reparationsunderlag
{
    public partial class Form1 : Form
        
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kassasystem_DataSet.Artiklar' table. You can move, or remove it, as needed.
            

            if (Inställningar.Default.bHasSeenNotes == true)
            {

                this.t_SALJARETableAdapter.Fill(pengvinDataset.T_SALJARE);

                this.ReparationsunderlagTableAdapter.Fill(DataSet1.Reparationsunderlag);

                this.ReparationsunderlagTableAdapter.Adapter.SelectCommand.CommandText = "Select TOP 1 * From dbo.Reparationsunderlag Order By DokumentID ASC";

                //this.artiklarTableAdapter.Fill(this.kassasystem_DataSet.Artiklar);

                string DokumentID = dokumentIDTextBox.Text;
                string CurrentDate = dokumentDatumDateTimePicker.Text;
                string Supplier = SupplierTextBox.Text;
                string CustomerID = kundIDTextBox.Text;
                string CustomerContact = kundkontaktTextBox.Text;
                string Phonenumber = telefonnummerTextBox.Text;
                string Serialnumber = serienummerTextBox.Text;
                string Errordesc = felbeskrivningTextBox.Text;
                string Email = epostTextBox.Text;

                if (GarantiBox.Checked == true)
                {

                    GlobalVariables.GarantiChecked = "Ja";

                } else
                {

                    GlobalVariables.GarantiChecked = "Nej";

                }
                
                string User = användareComboBox.Text;
                string Mark = märkeTextBox.Text;
                string MachineType = maskintypTextBox.Text;

                ReportParameter r1 = new ReportParameter("SelectedDokID", DokumentID);
                ReportParameter r2 = new ReportParameter("SelectedDate", CurrentDate);
                ReportParameter r3 = new ReportParameter("SelectedSupplier", Supplier);
                ReportParameter r4 = new ReportParameter("SelectedCustomer", CustomerID);
                ReportParameter r5 = new ReportParameter("SelectedContact", CustomerContact);
                ReportParameter r6 = new ReportParameter("SelectedPhonenumber", Phonenumber);
                ReportParameter r7 = new ReportParameter("SelectedSerialnumber", Serialnumber);
                ReportParameter r8 = new ReportParameter("SelectedErrorDescription", Errordesc);
                ReportParameter r9 = new ReportParameter("SelectedEmail", Email);
                ReportParameter r10 = new ReportParameter("SelectedWarranty", GlobalVariables.GarantiChecked);
                ReportParameter r11 = new ReportParameter("SelectedStaffID", User);
                ReportParameter r12 = new ReportParameter("SelectedMark", Mark);
                ReportParameter r13 = new ReportParameter("SelectedMachinetype", MachineType);
                reportViewer1.ServerReport.SetParameters(new ReportParameter[] { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13 });

                

                this.reportViewer1.RefreshReport();
                this.ReparationsunderlagBindingSource.MoveLast();

                

                

            } else if (Inställningar.Default.bHasSeenNotes == false)
            {

                this.t_SALJARETableAdapter.Fill(this.pengvinDataset.T_SALJARE);

                this.ReparationsunderlagTableAdapter.Fill(this.DataSet1.Reparationsunderlag);



                //this.artiklarTableAdapter.Fill(this.kassasystem_DataSet.Artiklar);


                string DokumentID = dokumentIDTextBox.Text;
                string CurrentDate = dokumentDatumDateTimePicker.Text;
                string Supplier = SupplierTextBox.Text;
                string CustomerID = kundIDTextBox.Text;
                string CustomerContact = kundkontaktTextBox.Text;
                string Phonenumber = telefonnummerTextBox.Text;
                string Serialnumber = serienummerTextBox.Text;
                string Errordesc = felbeskrivningTextBox.Text;
                string Email = epostTextBox.Text;
                if (GarantiBox.Checked == true)
                {

                    GlobalVariables.GarantiChecked = "Ja";

                }
                else
                {

                    GlobalVariables.GarantiChecked = "Nej";

                }
                string User = användareComboBox.Text;
                string Mark = märkeTextBox.Text;
                string MachineType = maskintypTextBox.Text;

                ReportParameter r1 = new ReportParameter("SelectedDokID", DokumentID);
                ReportParameter r2 = new ReportParameter("SelectedDate", CurrentDate);
                ReportParameter r3 = new ReportParameter("SelectedSupplier", Supplier);
                ReportParameter r4 = new ReportParameter("SelectedCustomer", CustomerID);
                ReportParameter r5 = new ReportParameter("SelectedContact", CustomerContact);
                ReportParameter r6 = new ReportParameter("SelectedPhonenumber", Phonenumber);
                ReportParameter r7 = new ReportParameter("SelectedSerialnumber", Serialnumber);
                ReportParameter r8 = new ReportParameter("SelectedErrorDescription", Errordesc);
                ReportParameter r9 = new ReportParameter("SelectedEmail", Email);
                ReportParameter r10 = new ReportParameter("SelectedWarranty", GlobalVariables.GarantiChecked);
                ReportParameter r11 = new ReportParameter("SelectedStaffID", User);
                ReportParameter r12 = new ReportParameter("SelectedMark", Mark);
                ReportParameter r13 = new ReportParameter("SelectedMachinetype", MachineType);
                reportViewer1.ServerReport.SetParameters(new ReportParameter[] { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13 });

                

                this.reportViewer1.RefreshReport();
                this.ReparationsunderlagBindingSource.MoveLast();

                

                ChangelogForm tempfrm = new ChangelogForm();
                tempfrm.Show();

            }

        }

        private void UpdateReport(object sender, EventArgs e)
        {
            string DokumentID = dokumentIDTextBox.Text;
            string CurrentDate = dokumentDatumDateTimePicker.Text;
            string Supplier = SupplierTextBox.Text;
            string CustomerID = kundIDTextBox.Text;
            string CustomerContact = kundkontaktTextBox.Text;
            string Phonenumber = telefonnummerTextBox.Text;
            string Serialnumber = serienummerTextBox.Text;
            string Errordesc = felbeskrivningTextBox.Text;
            string Email = epostTextBox.Text;
            if (GarantiBox.Checked == true)
            {

                GlobalVariables.GarantiChecked = "Ja";
 
                }
            else
            {

                GlobalVariables.GarantiChecked = "Nej";

                }
            string User = användareComboBox.Text;
            string Mark = märkeTextBox.Text;
            string Machinetype = maskintypTextBox.Text;

            ReportParameter r1 = new ReportParameter("SelectedDokID", DokumentID);
            ReportParameter r2 = new ReportParameter("SelectedDate", CurrentDate);
            ReportParameter r3 = new ReportParameter("SelectedSupplier", Supplier);
            ReportParameter r4 = new ReportParameter("SelectedCustomer", CustomerID);
            ReportParameter r5 = new ReportParameter("SelectedContact", CustomerContact);
            ReportParameter r6 = new ReportParameter("SelectedPhonenumber", Phonenumber);
            ReportParameter r7 = new ReportParameter("SelectedSerialnumber", Serialnumber);
            ReportParameter r8 = new ReportParameter("SelectedErrorDescription", Errordesc);
            ReportParameter r9 = new ReportParameter("SelectedEmail", Email);
            ReportParameter r10 = new ReportParameter("SelectedWarranty", GlobalVariables.GarantiChecked);
            ReportParameter r11 = new ReportParameter("SelectedStaffID", User);
            ReportParameter r12 = new ReportParameter("SelectedMark", Mark);
            ReportParameter r13 = new ReportParameter("SelectedMachinetype", Machinetype);
            reportViewer1.ServerReport.SetParameters(new ReportParameter[] { r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13 });

            

            this.reportViewer1.RefreshReport();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (användareComboBox.SelectedIndex <= 0)
            {

                notifyIcon1.ShowBalloonTip(5, "Varning", "Dokumentet saknar ifylld användare och kommer därför inte att sparas.", ToolTipIcon.Warning);
                
               

            } else
            {

                this.Validate();
                this.ReparationsunderlagBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.DataSet1);

            }
            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            
            this.ReparationsunderlagTableAdapter.Fill(this.DataSet1.Reparationsunderlag);
            this.ReparationsunderlagBindingSource.AddNew();
            this.ReparationsunderlagBindingSource.MoveLast();

            Int32 CurrentRow = this.DataSet1.Reparationsunderlag.Rows.Count;
            CurrentRow = CurrentRow + GlobalVariables.RowVar;

            string CurrentRowText = (Convert.ToString(CurrentRow));

            dokumentIDTextBox.Text = CurrentRowText;

            dokumentDatumDateTimePicker.Value = System.DateTime.Today;

            GarantiBox.Checked = false;

            if (användareComboBox.SelectedIndex <= 0)
            {

                notifyIcon1.ShowBalloonTip(5, "Varning", "Dokumentet saknar ifylld användare och kommer därför inte att sparas.", ToolTipIcon.Warning);



            }
            else
            {

                this.Validate();
                this.ReparationsunderlagBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.DataSet1);

            }

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

            

            this.Validate();
            this.ReparationsunderlagBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DataSet1);
        }

        private void skrivUtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (användareComboBox.SelectedIndex <= 0)
            {

                notifyIcon1.ShowBalloonTip(5, "Varning", "Dokumentet saknar ifylld användare och kommer därför inte att skrivas ut.", ToolTipIcon.Warning);
                


            }
            else
            {
                if (CopyCheckbox.Checked != true)
                {
                    this.Validate();
                    this.ReparationsunderlagBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.DataSet1);
                    reportViewer1.PrinterSettings.Copies = 2;
                    reportViewer1.PrintDialog();
                }
                else
                {
                    this.Validate();
                    this.ReparationsunderlagBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.DataSet1);
                    reportViewer1.PrinterSettings.Copies = 2;
                    reportViewer1.PrintDialog();
                    //reportViewer1.LocalReport.ReportEmbeddedResource = "Reparationsunderlag.Reparationsunderlag_Rapport - Copy.rdlc";
                    //reportViewer1.PrinterSettings.Copies = 1;
                    //reportViewer1.PrintDialog();
                }

                
            }
            
            
            
        }

        private void reportViewer1_SendPrintInfo(object sender, ReportPrintEventArgs e)
        {
            notifyIcon1.ShowBalloonTip(5, "Information", "Utskriften har skickats till skrivaren.",ToolTipIcon.Info);
            WindowState = FormWindowState.Minimized;
        }

        private void visaÄndringsloggToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangelogForm tempfrm = new ChangelogForm();
            tempfrm.Show();
        }

        private void avslutaProgrammetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void minimeraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void menuStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void omToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serviceController1.Stop();
            serviceController1.Start();
            serviceController2.Stop();
            serviceController2.Start();
            
        }

        private void toolStripTextBox1_Validated(object sender, EventArgs e)
        {
            artiklarTableAdapter.Adapter.SelectCommand.CommandText = "SELECT Artikelnummer, Benämning, Levartnr, Levnr, EAN, Maskin, Inpris, Utpris, Marginal, Varugrupp, Lagerplats, Marginalkalkyl FROM dbo.Artiklar Where Artikelnummer LIKE '%" + toolStripTextBox1.Text + "%' OR BENÄMNING LIKE '%" + toolStripTextBox1.Text + "%' OR Levartnr LIKE '%" + toolStripTextBox1.Text + "%' OR EAN LIKE '%" + toolStripTextBox1.Text + "%'";


            this.artiklarTableAdapter.Fill(this.kassasystem_DataSet.Artiklar);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.artiklarBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.kassasystem_DataSet);
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if  (DokIDSearchBox.Text.Contains("") && DokumentDatumSearchBox.Text.Contains("") && LeverantorSearchBox.Text.Contains("") && KundIDSearchbox.Text.Contains("") && KundkontaktSearchBox.Text.Contains("") && TelefonnummerSearchBox.Text.Contains("") && FelbeskrivningSearchBox.Text.Contains("") && AnvandareSearchBox.Text.Contains("") && GarantiSearchBox.Text.Contains("") && EpostSearchBox.Text.Contains("") && SerienummerSearchBox.Text.Contains("") && MarkeSearchBox.Text.Contains("") && MaskintypSearchBox.Text.Contains("") && KlarSearchBox.Text.Contains(""))
            {
                this.ReparationsunderlagTableAdapter.Adapter.SelectCommand.CommandText = "Select * From dbo.Reparationsunderlag Order By DokumentID ASC";
                this.ReparationsunderlagTableAdapter.Fill(DataSet1.Reparationsunderlag);

            } else
            {

                this.ReparationsunderlagTableAdapter.Adapter.SelectCommand.CommandText = "Select * From dbo.Reparationsunderlag WHERE DokumentID Like '%" + DokIDSearchBox.Text + /*"%' OR DokumentDatum LIKE '%" + DokumentDatumSearchBox.Text + "%' OR DokumentDatum LIKE '%" + LeverantorSearchBox.Text + "%' OR DokumentDatum LIKE '%" + KundIDSearchbox.Text + "%' OR DokumentDatum LIKE '%" + KundkontaktSearchBox.Text + "%' OR DokumentDatum LIKE '%" + TelefonnummerSearchBox.Text + "%' OR DokumentDatum LIKE '%" + FelbeskrivningSearchBox.Text + "%' OR DokumentDatum LIKE '%" + AnvandareSearchBox.Text + "%' OR DokumentDatum LIKE '%" + GarantiSearchBox.Text + "%' OR DokumentDatum LIKE '%" + EpostSearchBox.Text + "%' OR DokumentDatum LIKE '%" + SerienummerSearchBox.Text + "%' OR DokumentDatum LIKE '%" + MarkeSearchBox.Text + "%' OR DokumentDatum LIKE '%" + MaskintypSearchBox.Text + "%' OR DokumentDatum LIKE '%" + MaskintypSearchBox.Text + "%' OR DokumentDatum LIKE '%" + KlarSearchBox.Text + "%'*/ "Order By DokumentID ASC";
                this.ReparationsunderlagTableAdapter.Fill(DataSet1.Reparationsunderlag);
            }
        }
    }
}
