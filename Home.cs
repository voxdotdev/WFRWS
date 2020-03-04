using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();
            panelLeft.Height = buttonDashboard.Height;
            panelLeft.Top = buttonDashboard.Top;
        }

        public void HidePanels()
        {
            panel3.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HidePanels();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonBackup.Height;
            panelLeft.Top = buttonBackup.Top;

            panel1.Visible = true;
            HidePanels();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonDashboard.Height;
            panelLeft.Top = buttonDashboard.Top;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonReset.Height;
            panelLeft.Top = buttonReset.Top;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            panelLeft.Height = buttonUpdate.Height;
            panelLeft.Top = buttonUpdate.Top;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file1 = openFileDialog1.FileName;

                MessageBox.Show(file1);
            }
        }
    }
}
        
