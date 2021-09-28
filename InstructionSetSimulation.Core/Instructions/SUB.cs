
namespace InstructionSetSimulation.Core.Instructions
{
	public class SUB : Instruction
	{
		public override ushort OpCode => 0x0A;

		public SUB(CPU cpuref) : base(cpuref) {

		}

		public override void Execute(ushort operand) {
			// src1
			var srcReg1 = cpu.GetRegister(GetRegister1Code(operand));
			// src2
			var srcReg2 = cpu.GetRegister(GetRegister2Code(operand));

			srcReg1.Data = (ushort)(srcReg1.Data - srcReg2.Data);
		}

		public override string ToString() {
			return "SUB";
		}
	}
}
