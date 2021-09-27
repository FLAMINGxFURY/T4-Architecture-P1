
namespace InstructionSetSimulation.Core.Instructions
{
	public class SUBM : Instruction
	{
		public override int OpCode => 0x09;

		public SUBM(CPU cpuref) : base(cpuref) {

		}


		public override void Execute(ushort operand) {

		}
	}
}
