namespace ILEmulation.Emulator.OpCodes.Handlers
{
    internal class Ldc_I4_6 : OpCodeHandler
    {
        public override void ExecuteInstruction(Core core, Instruction instr)
        {
            core.VMStack.Push(6);
            core.Index++;
        }
    }
}