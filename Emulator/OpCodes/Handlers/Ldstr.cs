namespace ILEmulation.Emulator.OpCodes.Handlers
{
    internal class Ldstr : OpCodeHandler
    {
        public override void ExecuteInstruction(Core core, Instruction instr)
        {
            core.VMStack.Push((string)instr.Operand);
            core.Index++;
        }
    }
}