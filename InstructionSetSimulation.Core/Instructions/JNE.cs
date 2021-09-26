
namespace InstructionSetSimulation.Core.Instructions
{
    public class JNE : Instruction
    {
        public override int OpCode => 0xC;
        public override int OperandCount => 2;

        public override void Execute(params ushort[] operands)
        {
            
        }
    }
}
