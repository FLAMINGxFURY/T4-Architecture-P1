using System;
using System.Collections.Generic;
using InstructionSetSimulation.Core.Instructions;
using InstructionSetSimulation.Core.Registers;

namespace InstructionSetSimulation.Core
{
	public class CPU
	{
		private static CPU _instance;
		private static Object _syncLock = new Object();

		public byte[] Memory { get; set; } = new byte[1048576]; //1 MiB = 1024 KiB = 1024 * 1024 B

		public Reader Rd;

		private Dictionary<ushort, Register> _registers = new Dictionary<ushort, Register>();

		public Dictionary<ushort, Instruction> _operations = new Dictionary<ushort, Instruction>();

		private bool endReached;

		private CPU() {

			Rd = new Reader(_instance);

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
			_operations.Add(1, new NOP());
			_operations.Add(2, new MOVI());
			_operations.Add(3, new MOVM());
			_operations.Add(4, new MOVO());
			_operations.Add(5, new MOV());
			_operations.Add(6, new ADDI());
			_operations.Add(7, new ADDM());
			_operations.Add(8, new ADD());
			_operations.Add(9, new SUBI());
			_operations.Add(10, new SUBM());
			_operations.Add(11, new SUB());
			_operations.Add(12, new CMP());
			_operations.Add(13, new JMP());
			_operations.Add(14, new JNE());
			_operations.Add(15, new JEQ());
			_operations.Add(31, new END());
		}

		public static CPU GetInstance() {
			if (_instance == null) {
				lock (_syncLock) {
					if (_instance == null) {
						_instance = new CPU();
					}
				}
			}			
			return _instance;						
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
