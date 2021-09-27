
namespace InstructionSetSimulation.Core.Instructions
{
	public class JNE : Instruction
	{
		public override int OpCode => 0x0D;

		public JNE(CPU cpuref) : base(cpuref) {

		}

		public override void Execute(ushort operand) {

		}
	}
}
