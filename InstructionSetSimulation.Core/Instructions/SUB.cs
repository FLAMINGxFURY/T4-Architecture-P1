
namespace InstructionSetSimulation.Core.Instructions
{
	public class SUB : Instruction
	{
		public override int OpCode => 0x0A;

		public SUB(CPU cpuref) : base(cpuref) {

		}

		public override void Execute(ushort operand) {

		}
	}
}
