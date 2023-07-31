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
    public partial class MainInterface : Form
    {
        public MainInterface()
        {
            InitializeComponent();
        }

        private void InstructionsBTn_Click(object sender, EventArgs e)
        {
            InstructionsForm frm = new InstructionsForm(this);
            frm.Show();

            this.Hide();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you want to close the Game ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            Welcome welcome = new Welcome();
            welcome.Show();
            this.Hide();
        }
    }
}
