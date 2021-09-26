
namespace InstructionSetSimulation.Core.Instructions
{
	public class MOVI : Instruction
	{
		public override int OpCode => 0x01;
		public override int OperandCount => 2;

		public override void Execute(params ushort[] operands)
		{
			
		}
	}
}
