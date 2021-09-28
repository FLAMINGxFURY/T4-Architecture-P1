﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstructionSetSimulation.Core {
	public class Reader {
		public ushort PC { get; set; }           //Program Counter
		public string fileStr { get; set; }
		public List<ushort> proMem;
		private BinaryReader fileIn;
		private CPU cpu;

		public Reader(CPU cpuref) {
			PC = 0;
			cpu = cpuref;
			proMem = new List<ushort>();
		}

		public void OpenFile() {
			//reset values
			proMem.Clear();
			PC = 0;

			//read in file to program memory
			fileIn = new BinaryReader(File.Open(fileStr, FileMode.Open));
			while (fileIn.PeekChar() != -1) { //ensure not empty
				proMem.Add(fileIn.ReadUInt16());
			}
			fileIn.Close();
		}

		public ushort GetNextWord() {

			var ret = proMem[PC];
			PC++;

			return ret;
		}

		public void ParseNextOp() {
			//grab next 16 bits
			ushort next = GetNextWord();

			//determine opcode
			ushort op = (ushort)(next >> 11);

			//split out remainder
			ushort remainder = (ushort)(0b_0000_0111_1111_1111 & next); //bit mask for removing opcode

			//pass off to instruction
			cpu._operations[op].Execute(remainder);

		}

	}
}
