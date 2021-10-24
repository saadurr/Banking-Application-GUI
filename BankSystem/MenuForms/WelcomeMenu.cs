using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ABCSystem
{
    public partial class WelcomeMenu : Form
    {
        public WelcomeMenu()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 1500;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }
        void Timer_Tick(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
