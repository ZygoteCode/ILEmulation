namespace ILEmulation.Emulator.OpCodes.Handlers
{
    internal class Ldlen : OpCodeHandler
    {
        public override void ExecuteInstruction(Core core, Instruction instr)
        {
            core.VMStack.Push(((byte[])core.VMStack.Pop()).Length);
            core.Index++;
        }
    }
}