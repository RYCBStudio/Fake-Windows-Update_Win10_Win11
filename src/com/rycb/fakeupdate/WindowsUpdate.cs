using System;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;

namespace Update
{
    public partial class WindowsUpdate : Form
    {
        int width, height;
        public WindowsUpdate()
        {
            InitializeComponent();
        }

        private void WindowsUpdate_Load(object sender, EventArgs e)
        {
            string sys = new ComputerInfo().OSFullName;
            this.TopMost = true;
            bool sysInfo = sys.Contains("Microsoft Windows");
            if (!(sysInfo)) { Close(); }
            else
            {
                if (sys.Contains("10")) { this.BackgroundImage = Properties.Resources.Background_Win10; Loading.Image = Properties.Resources.Update_Win10; }
                else if (sys.Contains("11")) { this.BackColor = System.Drawing.Color.Black; Loading.Image = Properties.Resources.Update_Win11; }
                else { Close(); }
            }
            width = Screen.PrimaryScreen.Bounds.Width;
            height = Screen.PrimaryScreen.Bounds.Height;
            this.Width = width;
            this.Height = height;
            Loading.Location = new System.Drawing.Point(width / 2 - 30, (height / 2) - 150);
            Updating.Location = new System.Drawing.Point(width / 2 - 120, (height / 2) - 60);
            Completed.Location = new System.Drawing.Point(width / 2 - 100, (height / 2) - 10);
            CompletedNumber.Location = new System.Drawing.Point(width / 2 - 10, (height / 2) - 10);
            Percent.Location = new System.Drawing.Point(width / 2 + 50, (height / 2) - 10);
            DoNotShutDownTip.Location = new System.Drawing.Point(width / 2 - 150, (height / 2) + 20);
            try
            {
                UpdateTimer.Start();
            }
            catch
            {
                Close();
            }
        }


        private void WindowsUpdate_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.Q:
                    Close();
                    break;
                default:
                    break;

            }

        }

        private void DZUpdate(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(CompletedNumber.Text);
            num++;
            CompletedNumber.Text = num.ToString();
            if (num >= 100) { Close(); }
        }

        
    }
}
