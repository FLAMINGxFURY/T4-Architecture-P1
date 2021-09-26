
namespace InstructionSetSimulation.Core.Instructions
{
    public class CMP : Instruction
    {
        public override int OpCode => 0xA;
        public override int OperandCount => 2;

        public override void Execute(params ushort[] operands)
        {
            
        }
    }
}
