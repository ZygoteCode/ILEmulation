namespace ILEmulation.Emulator.OpCodes.Handlers
{
    internal class Ldc_I4_2 : OpCodeHandler
    {
        public override void ExecuteInstruction(Core core, Instruction instr)
        {
            core.VMStack.Push(2);
            core.Index++;
        }
    }
}