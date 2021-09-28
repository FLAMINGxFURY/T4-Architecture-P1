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
        public InstructionSetDecoder()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Executes the next instruction, updating the registers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
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
            string filePath;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    var fileStream = openFileDialog.OpenFile();

                    //create CPU instance, passing in filestream from file dialog to create Reader object


                    //**We will need some return values for each line of code to print to the display**

                    //loop while there is another line of code to parse
                        //print out binary instruction in top text box
                        //print out decoded instruction in bottom text box
                        //update registers

                }
            }
            
        }
    }
}
