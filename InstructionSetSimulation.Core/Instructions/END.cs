using System;

namespace InstructionSetSimulation.Core.Instructions
{
	public class END : Instruction
	{
		public override int OpCode => 0x1F;

		public END(CPU cpuref) : base(cpuref) {

		}

		public override void Execute(ushort operand) {
			Console.WriteLine("End Reached");
			cpu.End();
		}
	}
}
