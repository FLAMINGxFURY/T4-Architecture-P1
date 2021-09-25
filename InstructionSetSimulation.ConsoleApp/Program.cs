using InstructionSetSimulation.Core;

namespace InstructionSetSimulation.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CPU.Init();

            CPU.Instance.Test();

            // Load 0x0001 (MOVI)
            CPU.Instance.Memory[0] = 0x01;
            CPU.Instance.Memory[1] = 0x00;

            // Load 0x0001 (AX)
            CPU.Instance.Memory[2] = 0x00;
            CPU.Instance.Memory[3] = 0x00;

            // Load 0x0072 (Hex 72 immediate value)
            CPU.Instance.Memory[4] = 0x72;
            CPU.Instance.Memory[5] = 0x00;

            CPU.Instance.Run();
            // When completed, the AX register holds the value 72h
        }
    }
}
