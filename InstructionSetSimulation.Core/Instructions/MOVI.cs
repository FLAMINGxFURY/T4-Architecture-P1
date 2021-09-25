
namespace InstructionSetSimulation.Core.Instructions
{
    public class MOVI : Instruction
    {
        public override int OpCode => 0x01;
        public override int OperandCount => 2;

        public override void Execute(params ushort[] operands)
        {
            var register = operands[0];
            var immediate = operands[1];

            CPU.Instance.SetRegister(register, immediate);
        }
    }
}
