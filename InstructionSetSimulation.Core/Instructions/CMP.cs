
namespace InstructionSetSimulation.Core.Instructions
{
    public class CMP : Instruction
    {
        public override int OpCode => 0xA;
        public override int OperandCount => 2;

        public override void Execute(params ushort[] operands)
        {
            var register1 = operands[0]; //the first register to compare
            var register2 = operands[1]; //the second register to compare

            CPU.Instance.SetRegister(register1, register2);
        }
    }
}
