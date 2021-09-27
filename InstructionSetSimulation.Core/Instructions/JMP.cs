
namespace InstructionSetSimulation.Core.Instructions
{
	public class JMP : Instruction
	{
		public override int OpCode => 0x0C;

		public JMP(CPU cpuref) : base(cpuref) {

		}

		public override void Execute(ushort operand) {

		}
	}
}
