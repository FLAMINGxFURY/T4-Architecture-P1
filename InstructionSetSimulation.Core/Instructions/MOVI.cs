
namespace InstructionSetSimulation.Core.Instructions
{
	public class MOVI : Instruction
	{
		public override int OpCode => 0x01;

		public MOVI(CPU cpuref) : base(cpuref) {

		}

		public override void Execute(ushort operand) {

		}
	}
}
