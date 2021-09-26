
namespace InstructionSetSimulation.Core.Instructions
{
	public class SUBI : Instruction
	{
		public override int OpCode => 0x07;
		public override int OperandCount => 2;

		public override void Execute(params ushort[] operands) {

		}
			
	}
}
