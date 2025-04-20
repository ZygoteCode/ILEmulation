namespace ILEmulation.Emulator.OpCodes.Handlers
{
    internal class Ldc_I4_0 : OpCodeHandler
    {
        public override void ExecuteInstruction(Core core, Instruction instr)
        {
            core.VMStack.Push(0);
            core.Index++;
        }
    }
}