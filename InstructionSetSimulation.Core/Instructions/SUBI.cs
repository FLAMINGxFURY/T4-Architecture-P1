
namespace InstructionSetSimulation.Core.Instructions
{
	public class SUBI : Instruction
	{
		public override ushort OpCode => 0x08;

		public SUBI(CPU cpuref) : base(cpuref) {

		}

		public override void Execute(ushort operand) {
			var register = cpu.GetRegister(GetRegister1Code(operand));
			register.Data -= GetData(operand);
		}
			
	}
}
