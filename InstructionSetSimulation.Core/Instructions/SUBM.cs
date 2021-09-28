﻿
namespace InstructionSetSimulation.Core.Instructions
{
	public class SUBM : Instruction
	{
		public override ushort OpCode => 0x09;

		public SUBM(CPU cpuref) : base(cpuref) {

		}


		public override void Execute(ushort operand) {
			var register = cpu.GetRegister(GetRegister1Code(operand));
			var addr = GetMemoryAddress();

			//get the 2 bytes from memory; force types to allow shift
			ushort byte1 = (ushort)(cpu.Memory[addr]);
			//next byte is 1 byte forward
			ushort byte2 = (ushort)(cpu.Memory[addr + 1]);

			//stored little endian, shift byte 2 because it is the upper order bits
			byte2 = (ushort)(byte2 << 2);

			//add together
			ushort data = (ushort)(byte1 + byte2);

			register.Data -= data;
		}
	}
}
