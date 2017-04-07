using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reparationsunderlag
{
    public partial class ChangelogForm : Form
    {
        public ChangelogForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void ChangelogForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Inställningar.Default.bHasSeenNotes = true;
            Inställningar.Default.Save();
            
        }
    }
}
