namespace ILEmulation.Emulator.OpCodes.Handlers
{
    internal class Ldc_I4_3 : OpCodeHandler
    {
        public override void ExecuteInstruction(Core core, Instruction instr)
        {
            core.VMStack.Push(3);
            core.Index++;
        }
    }
}