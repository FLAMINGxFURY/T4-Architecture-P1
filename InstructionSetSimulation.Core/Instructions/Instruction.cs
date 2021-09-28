using System;

namespace InstructionSetSimulation.Core.Instructions
{
	public abstract class Instruction
	{

		protected CPU cpu;

		public abstract ushort OpCode { get; }

		public Instruction (CPU cpuref) {
			cpu = cpuref;
		}

		public abstract void Execute(ushort operand);

		public virtual string ToText(ushort operand) {
			return "placeholder";
		}

		protected ushort GetRegister1Code(ushort operand)
        {
			return (ushort)(operand >> 8);
		}

		protected ushort GetRegister2Code(ushort operand)
		{
			return (ushort)((operand >> 5) & 0b_0000_0000_0111);
		}

		protected ushort GetImmediate(ushort operand)
		{
			return (ushort)(operand & 0b_0000_1111_1111);
		}

		//These are commented out because upper/lower data are in registers, not in the instruction.

		//protected byte GetUpperData(ushort operand)
  //      {
		//	return (byte)(operand & 0b_0000_1111_0000);
		//}

		//protected byte GetLowerData(ushort operand)
		//{
		//	return (byte)(operand & 0b_0000_0000_1111);
		//}

		//protected ushort GetMemoryAddress(ushort operand)
  //      {
		//	var memH = (byte)(operand & 0b_1111_0000_0000);
		//	var memL = (byte)(operand & 0b_0000_1111_0000);

		//	return BitConverter.ToUInt16(new[] { memH, memL });
		//}

		protected uint GetMemoryAddress() {
			//s0 represents upper half of address. Shift to reflect
			uint s0data = (uint)(cpu.GetRegister(6).Data << 4);
			uint s1data = cpu.GetRegister(7).Data;

			//combine and return
			return s0data + s1data;
		}

		protected bool DidCarry(ushort value1, ushort value2)
        {
			for (int mask = 0x01; mask <= 0x80; mask <<= 1)
			{
				if ((value1 & mask) > (value2 & mask))
				{
					return true;
				}
			}

			return false;
		}
	}
}
