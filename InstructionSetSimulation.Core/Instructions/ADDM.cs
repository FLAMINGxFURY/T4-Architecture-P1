
namespace InstructionSetSimulation.Core.Instructions
{
	public class ADDM : Instruction
	{
		public override ushort OpCode => 0x06;

		public ADDM(CPU cpuref) : base(cpuref) {

		}
		public override void Execute(ushort operand) {
			var register = cpu.GetRegister(GetRegister1Code(operand));
			var memory = GetMemoryAddress(operand);

			register.Data += cpu.Memory[memory];
		}
	}
}
