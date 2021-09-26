
namespace InstructionSetSimulation.Core.Instructions
{
    public class ADDI : Instruction
    {
        public override int OpCode => 0x04;
        public override int OperandCount => 2;

        public override void Execute(params ushort[] operands)
        {
            var register = operands[0]; //the register containing the value to add to
            var immediate = operands[1]; //the immediate value to be added

            CPU.Instance.SetRegister(register, immediate);
        }
    }
}
