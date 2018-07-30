using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reparationsunderlag
{
    public partial class Splashscreen : Form
    {
        public Splashscreen()
        {
            InitializeComponent();
            label2.Text = "Reparationsunderlag";
            pictureBox1.Image = Properties.Resources.sandbergs_logo_e1456731172110;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        long sizeOfUpdate = 0;


        void UpdateApplication()
        {
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;
                ad.CheckForUpdateCompleted += new CheckForUpdateCompletedEventHandler(ad_CheckForUpdateCompleted);
                ad.CheckForUpdateProgressChanged += new DeploymentProgressChangedEventHandler(ad_CheckForUpdateProgressChanged);

                ad.CheckForUpdateAsync();
            }
            else
            {
                this.Hide();
                Form1 newfrm = new Form1();
                newfrm.Show();
            }
        }

        void ad_CheckForUpdateProgressChanged(object sender, DeploymentProgressChangedEventArgs e)
        {
            label3.Text = String.Format("Laddar ned: {0}. {1:D}K av {2:D}K .", GetProgressString(e.State), e.BytesCompleted / 1024, e.BytesTotal / 1024);
        }

        string GetProgressString(DeploymentProgressState state)
        {
            if (state == DeploymentProgressState.DownloadingApplicationFiles)
            {
                return "applikationsfiler";
            }
            else if (state == DeploymentProgressState.DownloadingApplicationInformation)
            {
                return "applikationsfiler";
            }
            else
            {
                return "applikationsfiler";
            }
        }

        void ad_CheckForUpdateCompleted(object sender, CheckForUpdateCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("ERROR: Could not retrieve new version of the application. Reason: \n" + e.Error.Message + "\nPlease report this error to the system administrator.");
                return;
            }
            else if (e.Cancelled == true)
            {
                MessageBox.Show("The update was cancelled.");
            }

            // Ask the user if they would like to update the application now.
            if (e.UpdateAvailable)
            {
                sizeOfUpdate = e.UpdateSizeBytes;

                if (!e.IsUpdateRequired)
                {
                    //DialogResult dr = MessageBox.Show("An update is available. Would you like to update the application now?\n\nEstimated Download Time: ", "Update Available", MessageBoxButtons.OKCancel);
                    //if (DialogResult.OK == dr)
                    {
                        BeginUpdate();
                    }
                }
                else
                {
                    //MessageBox.Show("A mandatory update is available for your application. We will install the update now, after which we will save all of your in-progress data and restart your application.");
                    BeginUpdate();
                }
            }
            else
            {
                this.Hide();
                Form1 newfrm = new Form1();
                newfrm.Show();


            }
        }

        void BeginUpdate()
        {
            ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;
            ad.UpdateCompleted += new AsyncCompletedEventHandler(ad_UpdateCompleted);

            // Indicate progress in the application's status bar.
            ad.UpdateProgressChanged += new DeploymentProgressChangedEventHandler(ad_UpdateProgressChanged);
            ad.UpdateAsync();
        }

        void ad_UpdateProgressChanged(object sender, DeploymentProgressChangedEventArgs e)
        {
            String progressText = String.Format("{0:D}K av {1:D}K nedladdat - {2:D}% färdigt", e.BytesCompleted / 1024, e.BytesTotal / 1024, e.ProgressPercentage);
            label3.Text = progressText;
            progressBar1.Value = e.ProgressPercentage;
        }

        void ad_UpdateCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("The update of the application's latest version was cancelled.");
                return;
            }
            else if (e.Error != null)
            {
                MessageBox.Show("ERROR: Could not install the latest version of the application. Reason: \n" + e.Error.Message + "\nPlease report this error to the system administrator.");
                return;
            }

            //DialogResult dr = MessageBox.Show("The application has been updated. Restart? (If you do not restart now, the new version will not take effect until after you quit and launch the application again.)", "Restart Application", MessageBoxButtons.OKCancel);
            //if (DialogResult.OK == dr)
            {
                Application.Restart();
            }
        }



        private void Splashscreen_Load(object sender, EventArgs e)
        {
            UpdateApplication();
            
            /*UpdateCheckInfo info = null;      
            

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;
                

                progressBar1.Step = 20;
                progressBar1.PerformStep();

                try
                {
                    info = ad.CheckForDetailedUpdate();
                    label3.Text = ("Kollar efter nya uppdateringar.");
                    progressBar1.Step = 20;
                    progressBar1.PerformStep();

                }
                catch (DeploymentDownloadException dde)
                {
                    label3.Text = ("Den nya versionen kan inte laddas ner för tillfället, vänligen försök igen senare. Felmeddelande: " + dde.Message);
                    Application.Exit();
                    return;
                }
                catch (InvalidDeploymentException ide)
                {
                    label3.Text = ("Kan inte kolla efter en ny version av programmet. ClickOnce programmet är korrupt, bygg om programmet. Felmeddelande: " + ide.Message);
                    Application.Exit();
                    return;
                }
                catch (InvalidOperationException ioe)
                {
                    label3.Text = ("Det här programmet kan inte uppdateras, det är troligen inget ClickOnce program. Felmeddelande: " + ioe.Message);
                    Application.Exit();
                    return;
                }

                if (info.UpdateAvailable)
                {
                    Boolean doUpdate = true;

                    if (doUpdate)
                    {
                        try
                        {
                            ad.Update();
                            label3.Text = ("Uppdaterar...");
                            progressBar1.Step = 100;
                            progressBar1.PerformStep();
                            Inställningar.Default.bHasSeenNotes = false;
                            Inställningar.Default.Save();
                            this.Hide();
                            Application.Restart();
                        }
                        catch (DeploymentDownloadException dde)
                        {
                            label3.Text = ("Den nya versionen kan inte laddas ner för tillfället, vänligen försök igen senare. Felmeddelande: " + dde);
                            Application.Exit();
                            return;
                            
                        }
                        
                    }
                }
            }*/

            //progressBar1.Step = 100;
            //progressBar1.PerformStep();
            /*label3.Text = "Startar programmet";
            Form1 newfrm = new Form1();
            newfrm.Show();
            this.Hide();*/
        }
    }
}
