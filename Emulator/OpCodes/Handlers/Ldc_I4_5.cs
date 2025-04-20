namespace ILEmulation.Emulator.OpCodes.Handlers
{
    internal class Ldc_I4_5 : OpCodeHandler
    {
        public override void ExecuteInstruction(Core core, Instruction instr)
        {
            core.VMStack.Push(5);
            core.Index++;
        }
    }
}