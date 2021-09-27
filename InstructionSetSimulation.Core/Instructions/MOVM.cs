
namespace InstructionSetSimulation.Core.Instructions
{
	public class MOVM : Instruction
	{
		public override int OpCode => 0x02;

		public MOVM(CPU cpuref) : base(cpuref) {

		}

		public override void Execute(ushort operand) {

		}
	}
}
