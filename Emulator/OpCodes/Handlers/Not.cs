namespace ILEmulation.Emulator.OpCodes.Handlers
{
    internal class Not : OpCodeHandler
    {
        public override void ExecuteInstruction(Core core, Instruction instr)
        {
            core.VMStack.Push(~(int)(core.VMStack.Pop()));
            core.Index++;
        }
    }
}