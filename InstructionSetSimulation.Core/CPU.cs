using System;
using System.Collections.Generic;
using InstructionSetSimulation.Core.Instructions;
using InstructionSetSimulation.Core.Registers;

namespace InstructionSetSimulation.Core
{
	public class CPU
	{
		public byte[] Memory { get; set; } = new byte[1048576]; //1 MiB = 1024 KiB = 1024 * 1024 B

		public Reader Rd;

		private Dictionary<ushort, Register> _registers = new Dictionary<ushort, Register>();

		public Dictionary<ushort, Instruction> _operations = new Dictionary<ushort, Instruction>();

		private bool endReached;

		public CPU() {

			Rd = new Reader(this);

			endReached = false;

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
			_operations.Add(1, new NOP(this));
			_operations.Add(2, new MOVI(this));
			_operations.Add(3, new MOVM(this));
			_operations.Add(4, new MOVO(this));
			_operations.Add(5, new MOV(this));
			_operations.Add(6, new ADDI(this));
			_operations.Add(7, new ADDM(this));
			_operations.Add(8, new ADD(this));
			_operations.Add(9, new SUBI(this));
			_operations.Add(10, new SUBM(this));
			_operations.Add(11, new SUB(this));
			_operations.Add(12, new CMP(this));
			_operations.Add(13, new JMP(this));
			_operations.Add(14, new JNE(this));
			_operations.Add(15, new JEQ(this));
			_operations.Add(31, new END(this));
		}

		public bool ParseNextOp() {
			Rd.ParseNextOp();

			return endReached;

		}

		public void End() {
			endReached = true;
		}

	}
}
