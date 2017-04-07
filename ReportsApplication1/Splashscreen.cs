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

        private void Splashscreen_Load(object sender, EventArgs e)
        {
            UpdateCheckInfo info = null;

            
            

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
            }

            progressBar1.Step = 100;
            progressBar1.PerformStep();
            label3.Text = "Startar programmet";
            Form1 newfrm = new Form1();
            newfrm.Show();
            this.Hide();
        }
    }
}
