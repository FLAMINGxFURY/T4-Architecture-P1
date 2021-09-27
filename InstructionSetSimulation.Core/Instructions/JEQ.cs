
namespace InstructionSetSimulation.Core.Instructions
{
	public class JEQ : Instruction
	{
		public override ushort OpCode => 0x0E;

		public JEQ(CPU cpuref) : base(cpuref) {

		}

		public override void Execute(ushort operand) {
			var memory = GetMemoryAddress(operand);

			if (!cpu.EFlags['z'])
			{
				cpu.PC.Data = memory;
			}
		}
	}
}
