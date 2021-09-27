
namespace InstructionSetSimulation.Core.Instructions
{
	public class ADD : Instruction
	{
		public override ushort OpCode => 0x07;

		public ADD(CPU cpuref) : base(cpuref) {

		}

		public override void Execute(ushort operand) {
			// src1
			var srcReg1 = cpu.GetRegister(GetRegister1Code(operand));
			// src2
			var srcReg2 = cpu.GetRegister(GetRegister2Code(operand));
			// src3
			var srcReg3 = cpu.GetRegister(GetRegister3Code(operand));

			srcReg3.Data = (ushort)(srcReg1.Data + srcReg2.Data);
		}
	}
}
