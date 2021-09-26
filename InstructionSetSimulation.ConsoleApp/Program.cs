using InstructionSetSimulation.Core;
using System;

namespace InstructionSetSimulation.ConsoleApp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			CPU cpu = new CPU();

			Console.WriteLine(cpu.Rd.GetNextWord());

			// Load 0x0001 (MOVI)
			cpu.Memory[0] = 0x01;
			cpu.Memory[1] = 0x00;

			// Load 0x0001 (AX)
			cpu.Memory[2] = 0x00;
			cpu.Memory[3] = 0x00;

			// Load 0x0072 (Hex 72 immediate value)
			cpu.Memory[4] = 0x72;
			cpu.Memory[5] = 0x00;

			cpu.Run();
			// When completed, the AX register holds the value 72h
		}
	}
}
