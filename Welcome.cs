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
    public partial class Welcome : Form
    {
        private Timer timer;
        public Welcome()
        {
            InitializeComponent();
            Welcometimer = new Timer();
            Welcometimer.Interval = 5100;
            Welcometimer.Tick += Welcometimer_Tick;
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            Welcometimer.Start();
        }

        private void Welcometimer_Tick(object sender, EventArgs e)
        {
            Welcometimer.Stop();
           
            Form moreForm = new Form1();
            moreForm.Show();
           // moreForm.Activate();
            this.Hide();

        }
    }
}
