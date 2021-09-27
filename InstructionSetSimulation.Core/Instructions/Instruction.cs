
namespace InstructionSetSimulation.Core.Instructions
{
	public abstract class Instruction
	{

		protected CPU cpu = CPU.GetInstance();

		public abstract int OpCode { get; }

		public abstract void Execute(ushort operand);
	}
}
