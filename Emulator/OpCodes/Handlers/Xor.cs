using ILEmulation.Emulator;
using System;

internal class Xor : OpCodeHandler
{
    public override void ExecuteInstruction(Core core, Instruction instr)
    {
        core.VMStack.Push(Convert.ToByte(core.VMStack.Pop()) ^ (int)(core.VMStack.Pop()));
        core.Index++;
    }
}