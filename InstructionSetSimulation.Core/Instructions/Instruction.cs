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

		/// <summary>
		/// Determines whether or not a subtraction of the two values would 
		/// result in a borrow.
		/// </summary>
		/// <param name="value1">The minuend.</param>
		/// <param name="value2">The subtrahend.</param>
		/// <returns>Whether or not a borrow was required.</returns>
		protected bool WouldBorrow(ushort value1, ushort value2)
        {
			// Goes through each bit in the two values
			for (int mask = 0x01; mask <= 0x80; mask <<= 1)
			{
				// If value2 has a set bit where value 1 doesn't, a borrow occcured
				if ((value1 & mask) > (value2 & mask))
				{
					return true;
				}
			}

			return false;
		}

		/// <summary>
		/// Determines whether or not a carry would occur between the two values.
		/// </summary>
		protected bool WouldCarry(ushort value1, ushort value2)
        {
			if (value1 > 0 && value2 > ushort.MaxValue - value1)
			{
				return true;    // Carry Overflow
			}
			else if (value1 < 0 && value2 < ushort.MaxValue - value1)
			{
				return true;    // Carry Underflow
			}

			return false;
		}

		/// <summary>
		/// Determines whether an overflow or underflow would occur between 
		/// the two values.
		/// </summary>
		protected bool WouldOverflow(ushort value1, ushort value2)
        {
			// Overflow is determined for signed values
			var signed1 = (short)value1;
			var signed2 = (short)value2;

			// If the arithmetic results in a sign change, there was overflow
			if (signed1 > 0 && signed2 > 0 && ((short)(value1 + value2) < 0 || (short)(value1 - value2) < 0))
            {
				return true;
            }
			
			if (signed1 < 0 && signed2 < 0 && ((short)(value1 + value2) > 0 || (short)(value1 + value2) > 0))
			{
				return true;
			}

			return false;
		}

		/// <summary>
		/// Determins parity by counting the number of set bits in the value.
		/// </summary>
		protected bool Parity(ushort value)
        {
			var setBits = 0;

			// Go through each bit
			for (int mask = 0x01; mask <= 0x80; mask <<= 1)
			{
				// If set, increase set bits
				if ((value & mask) == 1)
				{
					setBits++;
				}
			}

			// If setBits is even, there is parity
			return setBits % 2 == 0;
		}

		/// <summary>
		/// Detertmines if a auxiliary carry is required between two added 
		/// values.
		/// </summary>
		protected bool AuxiliaryCarryAddition(ushort value1, ushort value2)
        {
			// If the highest bit in the least significant nibble are both set,
			// then a aux carry would be required.
			var nibble1 = value1 & 0b_0000_0000_0000_1000 >> 3;
			var nibble2 = value2 & 0b_0000_0000_0000_1000 >> 3;

			if (nibble1 == 1 && nibble2 == 1)
            {
				return true;
            }

			return false;
        }

		/// <summary>
		/// Detertmines if a auxiliary carry is required between two subtracted
		/// values.
		/// </summary>
		protected bool AuxiliaryCarrySubtraction(ushort value1, ushort value2)
		{
			// If a borrow is required from the least signicant nibble, then
			// that would also count as an aux carry
			var nibble1 = value1 & 0b_0000_0000_0001_0000 >> 4;
			var nibble2 = value2 & 0b_0000_0000_0001_0000 >> 4;

			if (nibble1 == 1 && nibble2 == 1)
			{
				return true;
			}

			return false;
		}
	}
}
