
namespace InstructionSetSimulation.Core.Instructions
{
	public class MOVO : Instruction
	{
		public override int OpCode => 0x03;

		public MOVO(CPU cpuref) : base(cpuref) {

		}

		public override void Execute(ushort operand) {

		}
	}
}
