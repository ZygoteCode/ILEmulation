namespace ILEmulation.Emulator.OpCodes.Handlers
{
    internal class Clt : OpCodeHandler
    {
        public override void ExecuteInstruction(Core core, Instruction instr)
        {
            if ((int)(core.VMStack.Pop()) < (int)(core.VMStack.Pop()))
            {
                core.VMStack.Push(1);
            }
            else
            {
                core.VMStack.Push(0);
            }

            core.Index++;
        }
    }
}