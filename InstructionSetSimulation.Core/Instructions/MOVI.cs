﻿
namespace InstructionSetSimulation.Core.Instructions
{
	public class MOVI : Instruction
	{
		public override ushort OpCode => 0x01;

		public MOVI(CPU cpuref) : base(cpuref) {

		}

		public override void Execute(ushort operand) {
			var reg = cpu.GetRegister(GetRegister1Code(operand));
			var data = GetData(operand);

			reg.Data = data;
		}
	}
}
