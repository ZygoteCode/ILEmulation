using System.Collections.Generic;
using ILEmulation.Emulator.OpCodes;
using ILEmulation.Emulator.OpCodes.Handlers;

namespace ILEmulation.Emulator
{
    public class Core
    {
        public Stack<object> VMStack;
        public int Index;

        private List<Instruction> instructions;
        private Dictionary<OpCode, OpCodeHandler> RegisteredHandlers;

        public Core(List<Instruction> instrs)
        {
            VMStack = new Stack<object>();
            instructions = instrs;
            RegisteredHandlers = new Dictionary<OpCode, OpCodeHandler>();
            RegisterOpCode();
        }

        private void RegisterOpCode()
        {
            RegisteredHandlers.Add(OpCode.Add, new Add());
            RegisteredHandlers.Add(OpCode.And, new And());
            RegisteredHandlers.Add(OpCode.Clt, new Clt());
            RegisteredHandlers.Add(OpCode.Div, new Div());
            RegisteredHandlers.Add(OpCode.Ldc_I4, new Ldc_I4());
            RegisteredHandlers.Add(OpCode.Ldc_I4_0, new Ldc_I4_0());
            RegisteredHandlers.Add(OpCode.Ldc_I4_1, new Ldc_I4_1());
            RegisteredHandlers.Add(OpCode.Ldc_I4_2, new Ldc_I4_2());
            RegisteredHandlers.Add(OpCode.Ldc_I4_3, new Ldc_I4_3());
            RegisteredHandlers.Add(OpCode.Ldc_I4_4, new Ldc_I4_4());
            RegisteredHandlers.Add(OpCode.Ldc_I4_5, new Ldc_I4_5());
            RegisteredHandlers.Add(OpCode.Ldc_I4_6, new Ldc_I4_6());
            RegisteredHandlers.Add(OpCode.Ldc_I4_7, new Ldc_I4_7());
            RegisteredHandlers.Add(OpCode.Ldc_I4_8, new Ldc_I4_8());
            RegisteredHandlers.Add(OpCode.Ldc_I4_M1, new Ldc_I4_M1());
            RegisteredHandlers.Add(OpCode.Ldlen, new Ldlen());
            RegisteredHandlers.Add(OpCode.Ldnull, new Ldnull());
            RegisteredHandlers.Add(OpCode.Ldstr, new Ldstr());
            RegisteredHandlers.Add(OpCode.Mul, new Mul());
            RegisteredHandlers.Add(OpCode.Nop, new Nop());
            RegisteredHandlers.Add(OpCode.Not, new Not());
            RegisteredHandlers.Add(OpCode.Or, new Or());
            RegisteredHandlers.Add(OpCode.Pop, new Pop());
            RegisteredHandlers.Add(OpCode.Rem, new Rem());
            RegisteredHandlers.Add(OpCode.Ret, new Ret());
            RegisteredHandlers.Add(OpCode.Shl, new Shl());
            RegisteredHandlers.Add(OpCode.Shr, new Shr());
            RegisteredHandlers.Add(OpCode.Sub, new Sub());
            RegisteredHandlers.Add(OpCode.Xor, new Xor());
        }

        public object Execute()
        {
            while (instructions.Count > Index)
            {
                Instruction instruction = instructions[Index];
                OpCodeHandler registredInstruction = RegisteredHandlers[instruction.OpCode];

                registredInstruction.ExecuteInstruction(this, instruction);
            }

            return VMStack.Count != 0 ? VMStack.Pop() : null;
        }
    }
}