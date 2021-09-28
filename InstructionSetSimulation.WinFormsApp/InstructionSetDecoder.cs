using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstructionSetSimulation.Core;
using System.IO;

namespace InstructionSetSimulation.WinFormsApp
{
    public partial class InstructionSetDecoder : Form
    {
        //Variables
        CPU cpu;

        public InstructionSetDecoder()
        {
            InitializeComponent();
            cpu = new CPU();
        }

        /// <summary>
        /// Executes the next instruction, updating the registers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextBtn_Click(object sender, EventArgs e)
        {
            //implement
        }

        /// <summary>
        /// Allows user to select binary file to decode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //pass file path to Reader
                    cpu.Rd.fileStr = openFileDialog.FileName;

                    //**We will need some return values for each line of code to print to the display**

                    //loop while there is another line of code to parse
                        //print out binary instruction in top text box
                        //print out decoded instruction in bottom text box
                        //update registers

                }
            
        }
	}
}
