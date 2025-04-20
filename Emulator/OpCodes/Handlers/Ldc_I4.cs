namespace ILEmulation.Emulator.OpCodes.Handlers
{
    internal class Ldc_I4 : OpCodeHandler
    {
        public override void ExecuteInstruction(Core core, Instruction instr)
        {
            core.VMStack.Push((int)instr.Operand);
            core.Index++;
        }
    }
}