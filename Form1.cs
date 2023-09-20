using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TulisanBerjalan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runningLabel_Click(object sender, EventArgs e)
        { }

        private void timer1_Tick(object sender, EventArgs e)
        {
            runningLabel.Left -= 10;
            if (runningLabel.Left < -runningLabel.Width) runningLabel.Left = this.Width;
        }

        private void buttonExit_Click(object sender, EventArgs e) => this.Close();
    }
}
