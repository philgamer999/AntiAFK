using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntiAFK
{
    public partial class MainWindow : Form
    {
        Timer timer = new Timer();
        int delay = 1000;
        int multiplier = 1;

        public MainWindow()
        {
            InitializeComponent();

            TypeBox.SelectedIndex = 0;

            timer.Interval = delay;
            timer.Tick += Tick;
        }

        private void ToggleButton_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
                ToggleButton.Text = "Enable";
                AFKImage.Visible = false;
            }
            else
            {
                if (TypeBox.SelectedIndex == 0)
                {
                    multiplier = 1;
                }
                else if (TypeBox.SelectedIndex == 1)
                {
                    multiplier = 1000;
                }
                delay = Convert.ToInt32(Math.Round(DelayInput.Value, 0)) * multiplier;
                timer.Interval = delay;
                timer.Start();
                ToggleButton.Text = "Disable";
                AFKImage.Visible = true;
            }
        }

        int n = 0;
        public void Tick(object sender, EventArgs e)
        {
            if (n == 0)
            {
                SendKeys.SendWait("a");
                n++;
            }
            else if (n >= 1)
            {
                SendKeys.SendWait("d");
                n = 0;
            }
        }
    }
}
