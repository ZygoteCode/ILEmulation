namespace ILEmulation.Emulator.OpCodes.Handlers
{
    internal class Nop : OpCodeHandler
    {
        public override void ExecuteInstruction(Core core, Instruction instr)
        {
            core.Index++;
        }
    }
}