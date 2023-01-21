namespace ILEmulation.Emulator.OpCodes.Handlers
{
    internal class Ldc_I4_1 : OpCodeHandler
    {
        public override void ExecuteInstruction(Core core, Instruction instr)
        {
            core.VMStack.Push(1);
            core.Index++;
        }
    }
}