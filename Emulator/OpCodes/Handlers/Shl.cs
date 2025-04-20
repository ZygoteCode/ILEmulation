namespace ILEmulation.Emulator.OpCodes.Handlers
{
    internal class Shl : OpCodeHandler
    {
        public override void ExecuteInstruction(Core core, Instruction instr)
        {
            core.VMStack.Push((int)(core.VMStack.Pop()) << (int)(core.VMStack.Pop()));
            core.Index++;
        }
    }
}