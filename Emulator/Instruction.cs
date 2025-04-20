using ILEmulation.Emulator.OpCodes;

namespace ILEmulation.Emulator
{
    public class Instruction
    {
        public OpCode OpCode;
        public object Operand;

        public Instruction(OpCode opCode, object operand)
        {
            OpCode = opCode;
            Operand = operand;
        }

        public Instruction(OpCode opCode)
        {
            OpCode = opCode;
        }
    }
}