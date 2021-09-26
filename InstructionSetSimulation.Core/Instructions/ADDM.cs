
namespace InstructionSetSimulation.Core.Instructions
{
    public class ADDM : Instruction
    {
        public override int OpCode => 0x05;
        public override int OperandCount => 2;

        public override void Execute(params ushort[] operands)
        {
            var register = operands[0];
            var memory = operands[1];

            CPU.Instance.SetRegister(register, memory);
        }
    }
}
