
namespace InstructionSetSimulation.Core.Instructions
{
	public class ADDM : Instruction
	{
		public override ushort OpCode => 0x06;

		public ADDM(CPU cpuref) : base(cpuref) {

		}
		public override void Execute(ushort operand) {
			var register = cpu.GetRegister(GetRegister1Code(operand));

			//register contains memory location
			cpu.Memory[register.Data] += GetLowerData(operand);
			cpu.Memory[register.Data + 1] += GetUpperData(operand);
		}
	}
}
