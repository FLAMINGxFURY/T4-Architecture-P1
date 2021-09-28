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
		List<string> dispProgCode;
		int InstCount = 0;
		int CurrentInst = 0;

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
			if (cpu.ParseNextOp())
				NextBtn.Enabled = false;

			//poll registers and flags for data
			AXBox.Text = cpu.GetRegister(0).Data.ToString("X4");
			BXBox.Text = cpu.GetRegister(1).Data.ToString("X4");
			CXBox.Text = cpu.GetRegister(2).Data.ToString("X4");
			DXBox.Text = cpu.GetRegister(3).Data.ToString("X4");
			SPBox.Text = cpu.GetRegister(4).Data.ToString("X4");
			BPBox.Text = cpu.GetRegister(5).Data.ToString("X4");
			S0Box.Text = cpu.GetRegister(6).Data.ToString("X4");
			S1Box.Text = cpu.GetRegister(7).Data.ToString("X4");

			PCBox.Text = cpu.Rd.PC.ToString("X4");

			CBox.Text = Convert.ToInt32(cpu.EFlags['c']).ToString();
			PBox.Text = Convert.ToInt32(cpu.EFlags['p']).ToString();
			ABox.Text = Convert.ToInt32(cpu.EFlags['a']).ToString();
			ZBox.Text = Convert.ToInt32(cpu.EFlags['z']).ToString();
			SBox.Text = Convert.ToInt32(cpu.EFlags['s']).ToString();
			OBox.Text = Convert.ToInt32(cpu.EFlags['o']).ToString();

			if (CurrentInst < InstCount)
			{
				txtCurrentInst.Text = "";
				txtCurrentInst.Text = dispProgCode[CurrentInst];
				CurrentInst++;
			}
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
						InstCount++;
						progDisplay += (s + " ");
					}

					BinaryFileBox.Text = progDisplay;

					//Display Code for Program
					dispProgCode = new List<string>();

					foreach (ushort x in cpu.Rd.proMem) {
						string output = "";
						
						//get opcode
						ushort op = (ushort)(x >> 11);
						output += cpu._operations[op].ToString() + " ";

						//get rest
						ushort remainder = (ushort)(0b_0000_0111_1111_1111 & x); //bit mask for removing opcode
						output += cpu._operations[op].ToText(remainder);

						dispProgCode.Add(output);
					}

					string codeDisplay = "";

					foreach(string s in dispProgCode) {
						codeDisplay += s + Environment.NewLine;
					}

					DecodedInstructionsBox.Text = codeDisplay;
					txtCurrentInst.Text = "";
					CurrentInst = 0;

				}
			}

			
			
		}

		/// <summary>
		/// Displays about form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
			var form = new About();
			form.Show();
        }
    }
}
