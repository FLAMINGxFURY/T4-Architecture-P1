using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstructionSetSimulation.Core {
	public class Reader {
		public ushort PC;           //Program Counter
		private ushort currentWord; //current data in reader
		private BinaryReader fileIn;
		private CPU cpu;

		public Reader(CPU cpuref) {
			PC = 0;
			currentWord = 0;
			fileIn = new BinaryReader(File.Open("../../../../Example 3.bin", FileMode.Open)); //for now we edit the filename here and have no way to select it.
																						 //The directory is the same as the .sln file
																						 //Later we can have this come from a file select screen, need a var for that
			cpu = cpuref;
		}

		public ushort GetNextWord() {

			var ret = fileIn.ReadUInt16();

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
