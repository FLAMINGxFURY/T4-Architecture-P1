
namespace InstructionSetSimulation.Core.Instructions
{
	public class JMP : Instruction
	{
		public override int OpCode => 0xB;
		public override int OperandCount => 2;

		public override void Execute(params ushort[] operands)
		{
			
		}
	}
}
