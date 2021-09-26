
namespace InstructionSetSimulation.Core.Instructions
{
    public class SUBM : Instruction
    {
        public override int OpCode => 0x08;
        public override int OperandCount => 2;

        public override void Execute(params ushort[] operands)
        {
            
        }
    }
}
