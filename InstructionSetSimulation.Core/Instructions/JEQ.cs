
namespace InstructionSetSimulation.Core.Instructions
{
	public class JEQ : Instruction
	{
		public override int OpCode => 0x0E;

		public JEQ(CPU cpuref) : base(cpuref) {

		}

		public override void Execute(ushort operand) {

		}
	}
}
