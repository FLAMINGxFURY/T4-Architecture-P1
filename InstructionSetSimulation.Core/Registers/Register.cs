using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstructionSetSimulation.Core.Registers {
	public abstract class Register {
		public ushort Data { get; set; }
		public ushort ID { get; set; }

		public Register() {
			Data = 0;
		}

	}
}
