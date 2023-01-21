using ILEmulation.Emulator;

public abstract class OpCodeHandler
{
    public abstract void ExecuteInstruction(Core core, Instruction instr);
}