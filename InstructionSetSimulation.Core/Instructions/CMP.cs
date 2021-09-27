
namespace InstructionSetSimulation.Core.Instructions
{
	public class CMP : Instruction
	{
		public override int OpCode => 0x0B;

		public CMP(CPU cpuref) : base(cpuref) {

		}

		public override void Execute(ushort operand) {

		}
	}
}
