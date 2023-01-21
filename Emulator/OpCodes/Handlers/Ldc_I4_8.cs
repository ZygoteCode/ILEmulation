namespace ILEmulation.Emulator.OpCodes.Handlers
{
    internal class Ldc_I4_8 : OpCodeHandler
    {
        public override void ExecuteInstruction(Core core, Instruction instr)
        {
            core.VMStack.Push(8);
            core.Index++;
        }
    }
}