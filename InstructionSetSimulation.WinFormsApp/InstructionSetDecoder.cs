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
        List<string> dispProgMem;

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
            //after halt disable the button
            if (cpu.ParseNextOp()) NextBtn.Enabled = false;

            //highlight change
        }

        /// <summary>
        /// Allows user to select binary file to decode
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    //pass file path to Reader and open it
                    cpu.Rd.fileStr = openFileDialog.FileName;
                    cpu.Rd.OpenFile();

                    //after new file is opened reenable button
                    NextBtn.Enabled = true;

                    //Display Hex for Program
                    dispProgMem = new List<string>();

                    foreach(ushort x in cpu.Rd.proMem) {
                        string add = x.ToString("X4"); //4 digits of hex
                        add = add.Insert(2, " ");
                        dispProgMem.Add(add);
					}

                    string progDisplay = "";

                    foreach (string s in dispProgMem) {
                        progDisplay += (s + " ");
                    }

                    BinaryFileBox.Text = progDisplay;

                    //Display Code for Program
                    

                }
            }

            
            
        }
	}
}
