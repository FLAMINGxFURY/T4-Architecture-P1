using System;

namespace InstructionSetSimulation.Core.Instructions
{
	public class MOVO : Instruction
	{
		public override ushort OpCode => 0x03;

		public MOVO(CPU cpuref) : base(cpuref) {

		}

		public override void Execute(ushort operand) {
			// Get memory address
			var memH = (byte)(operand & 0b_1111_0000_0000);
			var memL = (byte)(operand & 0b_0000_1111_0000);

			var mem = BitConverter.ToUInt16(new[] { memH, memL });

			// Get register
			var reg = cpu.GetRegister((ushort)(operand & 0b_0000_0000_1111));

			// Convert contents of register to bytes
			var dataAsBytes = BitConverter.GetBytes(reg.Data);

			// Put contents of regsiter into memory
			cpu.Memory[mem] = dataAsBytes[1];
			cpu.Memory[mem + 1] = dataAsBytes[0];
		}
	}
}
