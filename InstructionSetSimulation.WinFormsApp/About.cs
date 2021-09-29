using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace InstructionSetSimulation.WinFormsApp
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            ProcessStartInfo sInfo = new ProcessStartInfo("https://docs.google.com/document/d/1xquXnmAGT55yLyMfbxOPVF5NNyrsOIM0NLt4d_OKXd0") { UseShellExecute = true };
            Process.Start(sInfo);
        }
    }
}
