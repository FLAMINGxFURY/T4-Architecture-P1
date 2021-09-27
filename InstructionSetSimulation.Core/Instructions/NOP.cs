using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstructionSetSimulation.Core.Instructions
{
	public class NOP : Instruction {
		public override int OpCode => 0x00;

		public override void Execute(ushort operand) {

		}
	}
}
