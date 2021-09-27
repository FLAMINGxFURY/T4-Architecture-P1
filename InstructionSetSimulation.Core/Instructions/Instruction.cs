
namespace InstructionSetSimulation.Core.Instructions
{
	public abstract class Instruction
	{

		protected CPU cpu;

		public abstract int OpCode { get; }

		public Instruction (CPU cpuref) {
			cpu = cpuref;
		}

		public abstract void Execute(ushort operand);
	}
}
