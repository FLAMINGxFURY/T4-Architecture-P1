
namespace InstructionSetSimulation.Core.Instructions
{
	public class ADDM : Instruction
	{
		public override int OpCode => 0x06;

		public ADDM(CPU cpuref) : base(cpuref) {

		}
		public override void Execute(ushort operand) {

		}
	}
}
