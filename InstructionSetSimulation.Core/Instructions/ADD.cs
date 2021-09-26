
namespace InstructionSetSimulation.Core.Instructions
{
    public class ADD : Instruction
    {
        public override int OpCode => 0x06;
        public override int OperandCount => 2;

        public override void Execute(params ushort[] operands)
        {
            
        }
    }
}
