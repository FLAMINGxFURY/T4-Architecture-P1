﻿
namespace InstructionSetSimulation.Core.Instructions
{
	public class MOV : Instruction
	{
		public override ushort OpCode => 0x04;

		public MOV(CPU cpuref) : base(cpuref) {

		}

		public override void Execute(ushort operand) {
			var dest = cpu.GetRegister(GetRegister1Code(operand));
			var src = cpu.GetRegister(GetRegister2Code(operand));

			dest.Data = src.Data;
		}
	}
}