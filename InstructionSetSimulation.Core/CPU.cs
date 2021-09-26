using System;
using System.Collections.Generic;
using InstructionSetSimulation.Core.Instructions;
using InstructionSetSimulation.Core.Registers;

namespace InstructionSetSimulation.Core
{
    public class CPU
    {
        public static CPU Instance { get; private set; }
        //TODO: remove all registers here. PC has been moved to reader. Other registers have been put in a dictionary.
        public ushort PC { get; private set; }
        public ushort AX { get; private set; }
        public ushort BX { get; private set; }
        public ushort CX { get; private set; }
        public ushort DX { get; private set; }
        public byte[] Memory { get; set; } = new byte[1048576]; //1 MiB = 1024 KiB = 1024 * 1024 B

        //TODO: add all
        private static Dictionary<ushort, Register> _registers = new Dictionary<ushort, Register>();

        // TODO: This could be cached beforehand using reflection and the OpCode property on instructions
        private static Dictionary<ushort, Instruction> _operations = new Dictionary<ushort, Instruction>();

        public void Run()
        {
            var opcode = BitConverter.ToUInt16(new[] { Memory[PC], Memory[++PC] });

            var operand = _operations[opcode];

            var operandCount = operand.OperandCount;

            var operands = new ushort[operandCount];
            for (var i = 0; i < operandCount; i++)
            {
                var op = BitConverter.ToUInt16(new [] { Memory[++PC], Memory[++PC] });
                operands[i] = op;
            }

            operand.Execute(operands);
        }

        public void SetRegister(ushort code, ushort value)
        {
            switch (code)
            {
                case 0:
                    AX = value;
                    break;
                case 1:
                    BX = value;
                    break;
                case 2:
                    CX = value;
                    break;
                case 3:
                    DX = value;
                    break;
                default:
                    throw new ArgumentException($"'{code}' is an invalid register value.");
            }
        }

        public static void Init()
        {
            Instance = new CPU();

            //add all of the registers to the dictionary on initialization
            _registers.Add(1, new AX());
            _registers.Add(2, new BX());
            _registers.Add(3, new CX());
            _registers.Add(4, new DX());
            _registers.Add(5, new SX());
            _registers.Add(6, new PC());
            _registers.Add(7, new S0());
            _registers.Add(8, new S1());

            //add all of the operations to the dictionary on initialization
            _operations.Add(1, new MOVI());
        }
    }
}
