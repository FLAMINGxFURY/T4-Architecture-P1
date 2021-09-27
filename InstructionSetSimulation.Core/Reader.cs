using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstructionSetSimulation.Core {
	public class Reader {
		private static Reader _instance = null;
		private static Object _syncLock = new Object();
		public ushort PC;           //Program Counter
		private ushort currentWord; //current data in reader
		private BinaryReader fileIn;
		private CPU cpu;

		private Reader() {
			PC = 0;
			currentWord = 0;
			fileIn = new BinaryReader(File.Open("../../../../test.bin", FileMode.Open)); //for now we edit the filename here and have no way to select it.
																						 //The directory is the same as the .sln file
																						 //Later we can have this come from a file select screen, need a var for that
			cpu = CPU.GetInstance();
		}

		public static Reader GetInstance() {
			lock(_syncLock) {
				if(_instance == null) {
					return new Reader();
				}
				return _instance;
			}
		}

		public ushort GetNextWord() {

			ushort ret = fileIn.ReadUInt16();

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
			switch(op) {
				case 0b_0_0000:
					//NOP
					break;

				case 0b_0_0001:
					//MOVI
					break;

				case 0b_0_0010:
					//MOVM
					break;

				case 0b_0_0011:
					//MOVO
					break;

				case 0b_0_0100:
					//MOV
					break;

				case 0b_0_0101:
					//ADDI
					break;

				case 0b_0_0110:
					//ADDM
					break;

				case 0b_0_0111:
					//ADD
					break;

				case 0b_0_1000:
					//SUBI
					break;

				case 0b_0_1001:
					//SUBM
					break;

				case 0b_0_1010:
					//SUB
					break;

				case 0b_0_1011:
					//CMP
					break;

				case 0b_0_1100:
					//JMP
					break;

				case 0b_0_1101:
					//JNE
					break;

				case 0b_0_1110:
					//JEQ
					break;

				case 0b_0_1111:
					//Not Assigned
					break;

				//ETC on not assigned

				case 0b_1_1111:
					//END
					break;
			}


		}

	}
}
