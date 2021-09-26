
namespace InstructionSetSimulation.Core.Instructions
{
    public class ADD : Instruction
    {
        public override int OpCode => 0x06;
        public override int OperandCount => 2;

        public override void Execute(params ushort[] operands)
        {
            var register1 = operands[0]; //the register containing the value to add to
            var register2 = operands[1]; //the register containing the value being added

            CPU.Instance.SetRegister(register1, register2);
        }
    }
}
