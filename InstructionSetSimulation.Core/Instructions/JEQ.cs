
namespace InstructionSetSimulation.Core.Instructions
{
    public class JEQ : Instruction
    {
        public override int OpCode => 0xD;
        public override int OperandCount => 2;

        public override void Execute(params ushort[] operands)
        {
            
        }
    }
}
