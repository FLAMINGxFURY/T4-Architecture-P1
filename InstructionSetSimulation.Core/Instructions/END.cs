
namespace InstructionSetSimulation.Core.Instructions
{
	public class END : Instruction
	{
		public override int OpCode => 0xE;
		public override int OperandCount => 0;

		public override void Execute(params ushort[] operands)
		{
			
		}
	}
}
