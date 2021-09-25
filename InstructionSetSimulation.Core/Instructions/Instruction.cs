
namespace InstructionSetSimulation.Core.Instructions
{
    public abstract class Instruction
    {
        public abstract int OpCode { get; }
        public abstract int OperandCount { get; }

        public abstract void Execute(params ushort[] operands);
    }
}
