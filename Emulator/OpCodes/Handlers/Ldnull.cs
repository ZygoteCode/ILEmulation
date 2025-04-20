namespace ILEmulation.Emulator.OpCodes.Handlers
{
    internal class Ldnull : OpCodeHandler
    {
        public override void ExecuteInstruction(Core core, Instruction instr)
        {
            core.VMStack.Push(null);
            core.Index++;
        }
    }
}