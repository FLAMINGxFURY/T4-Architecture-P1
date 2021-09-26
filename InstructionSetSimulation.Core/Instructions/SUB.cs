
namespace InstructionSetSimulation.Core.Instructions
{
    public class SUB : Instruction
    {
        public override int OpCode => 0x09;
        public override int OperandCount => 2;

        public override void Execute(params ushort[] operands)
        {
            var register1 = operands[0]; //the register containing the value to be subtracted from
            var register2 = operands[1]; //the register containing the value being subtracted

            CPU.Instance.SetRegister(register1, register2);
        }
    }
}
