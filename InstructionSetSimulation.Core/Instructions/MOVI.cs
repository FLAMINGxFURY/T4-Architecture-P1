﻿
namespace InstructionSetSimulation.Core.Instructions
{
    public class MOVI : Instruction
    {
        public override int OpCode => 0x01;
        public override int OperandCount => 2;

        public override void Execute(params ushort[] operands)
        {
            var register = operands[0]; //the register the value will be moved into
            var immediate = operands[1]; //the immediate value being moved

            CPU.Instance.SetRegister(register, immediate);
        }
    }
}
