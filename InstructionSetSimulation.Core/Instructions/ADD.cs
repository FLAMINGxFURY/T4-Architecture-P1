
namespace InstructionSetSimulation.Core.Instructions
{
	public class ADD : Instruction
	{
		public override int OpCode => 0x07;

		public ADD(CPU cpuref) : base(cpuref) {

		}

		public override void Execute(ushort operand) {
			
		}
	}
}
