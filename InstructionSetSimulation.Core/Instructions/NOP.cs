using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstructionSetSimulation.Core.Instructions
{
	public class NOP : Instruction {
		public override ushort OpCode => 0x00;

		public NOP(CPU cpuref) : base(cpuref) {

		}

		public override void Execute(ushort operand) {
			//Do nothing, explicitly :)
		}

		public override string ToText(ushort operand) {
			return "";
		}

		public override string ToString() {
			return "NOP";
		}
	}
}
