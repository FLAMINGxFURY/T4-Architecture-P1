
namespace InstructionSetSimulation.Core.Instructions
{
	public class SUBI : Instruction
	{
		public override int OpCode => 0x08;

		public SUBI(CPU cpuref) : base(cpuref) {

		}

		public override void Execute(ushort operand) {

		}
			
	}
}
