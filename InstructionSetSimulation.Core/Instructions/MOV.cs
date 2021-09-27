
namespace InstructionSetSimulation.Core.Instructions
{
	public class MOV : Instruction
	{
		public override int OpCode => 0x04;

		public MOV(CPU cpuref) : base(cpuref) {

		}

		public override void Execute(ushort operand) {

		}
	}
}
