
namespace InstructionSetSimulation.Core.Instructions
{
    public class SUBI : Instruction
    {
        public override int OpCode => 0x07;
        public override int OperandCount => 2;

        public override void Execute(params ushort[] operands)
        {
            var register = operands[0]; //the register containing the value to subtract from
            var immediate = operands[1]; //the immediate value being subtracted

            CPU.Instance.SetRegister(register, immediate);
        }
    }
}
