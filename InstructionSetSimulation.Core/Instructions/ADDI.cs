
namespace InstructionSetSimulation.Core.Instructions
{
	public class ADDI : Instruction
	{
		public override int OpCode => 0x04;
		public override int OperandCount => 2;

		public override void Execute(params ushort[] operands)
		{
			
		}
	}
}
