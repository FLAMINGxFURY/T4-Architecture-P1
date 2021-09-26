﻿
namespace InstructionSetSimulation.Core.Instructions
{
    public class MOVO : Instruction
    {
        public override int OpCode => 0x03;
        public override int OperandCount => 2;

        public override void Execute(params ushort[] operands)
        {
            var register = operands[0];
            var memory = operands[1];

            CPU.Instance.SetRegister(register, memory);
        }
    }
}