namespace ILEmulation.Emulator.OpCodes.Handlers
{
    internal class Ret : OpCodeHandler
    {
        public override void ExecuteInstruction(Core core, Instruction instr)
        {
            if (core.VMStack.Count == 0)
            {
                core.VMStack.Push(null);
            }

            object ret = core.VMStack.Pop();

            core.VMStack.Push(ret);
            core.Index++;
        }
    }
}