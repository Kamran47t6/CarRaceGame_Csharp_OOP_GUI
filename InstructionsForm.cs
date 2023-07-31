using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZoneOfCarRace
{
    public partial class InstructionsForm : Form
    {
        private Form previousform;
        public InstructionsForm(MainInterface previousform)
        {
            InitializeComponent();
            this.previousform = previousform;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you want to close the Game ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void movebackpicbox_Click(object sender, EventArgs e)
        {
            this.Hide();
            previousform.Show();

        }
    }
}
