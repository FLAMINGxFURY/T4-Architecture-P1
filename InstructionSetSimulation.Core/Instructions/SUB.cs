
namespace InstructionSetSimulation.Core.Instructions
{
    public class SUB : Instruction
    {
        public override int OpCode => 0x09;
        public override int OperandCount => 2;

        public override void Execute(params ushort[] operands)
        {
            
        }
    }
}
