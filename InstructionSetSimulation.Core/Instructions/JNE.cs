
namespace InstructionSetSimulation.Core.Instructions
{
	public class JNE : Instruction
	{
		public override ushort OpCode => 0x0D;

		public JNE(CPU cpuref) : base(cpuref) {

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
