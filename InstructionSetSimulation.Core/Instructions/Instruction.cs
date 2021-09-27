
namespace InstructionSetSimulation.Core.Instructions
{
	public abstract class Instruction
	{
		public abstract int OpCode { get; }

		public abstract void Execute(ushort operand);
	}
}
