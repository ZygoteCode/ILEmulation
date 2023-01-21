namespace ILEmulation.Emulator.OpCodes.Handlers
{
    internal class Ldc_I4_4 : OpCodeHandler
    {
        public override void ExecuteInstruction(Core core, Instruction instr)
        {
            core.VMStack.Push(4);
            core.Index++;
        }
    }
}