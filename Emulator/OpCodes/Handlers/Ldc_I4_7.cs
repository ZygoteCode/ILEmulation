namespace ILEmulation.Emulator.OpCodes.Handlers
{
    internal class Ldc_I4_7 : OpCodeHandler
    {
        public override void ExecuteInstruction(Core core, Instruction instr)
        {
            core.VMStack.Push(7);
            core.Index++;
        }
    }
}