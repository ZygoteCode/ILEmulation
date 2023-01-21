namespace ILEmulation.Emulator.OpCodes.Handlers
{
    internal class Pop : OpCodeHandler
    {
        public override void ExecuteInstruction(Core core, Instruction instr)
        {
            core.VMStack.Pop();
            core.Index++;
        }
    }
}