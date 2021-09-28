
namespace InstructionSetSimulation.Core.Instructions
{
	public class CMP : Instruction
	{
		public override ushort OpCode => 0x0B;

		public CMP(CPU cpuref) : base(cpuref) {

		}

		public override void Execute(ushort operand) {
			// TODO: This should set every flag, but ZF and CF are good for now

			var reg1c = GetRegister1Code(operand);
			var reg2c = GetRegister2Code(operand);

			var reg1 = cpu.GetRegister(reg1c);
			var reg2 = cpu.GetRegister(reg2c);

			var result = reg1.Data - reg2.Data;

			cpu.EFlags['c'] = DidCarry(reg1.Data, reg2.Data);
			cpu.EFlags['z'] = result == 0;
		}

		public override string ToString() {
			return "CMP";
		}
	}
}
