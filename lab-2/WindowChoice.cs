using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2
{
    public partial class WindowChoice : Form
    {
        public WindowChoice()
        {
            InitializeComponent();
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            this.Hide();
            WindowSend windowSend = new WindowSend();
            windowSend.Show();
        }

        private void bReceive_Click(object sender, EventArgs e)
        {
            this.Hide();
            WindowReceive windowReceive = new WindowReceive();
            windowReceive.Show();
        }
    }
}
