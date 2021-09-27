
namespace InstructionSetSimulation.Core.Instructions
{
	public class ADDI : Instruction
	{
		public override ushort OpCode => 0x05;

		public ADDI(CPU cpuref) : base(cpuref) {

		}

		public override void Execute(ushort operand) {
			var register = cpu.GetRegister(GetRegister1Code(operand));
			register.Data += GetData(operand);
		}
	}
}
