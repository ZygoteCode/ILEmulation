using ILEmulation.Emulator;
using ILEmulation.Emulator.OpCodes;
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.Title = "IL Emulation Program";
        List<Instruction> instructions = new List<Instruction>();

        instructions.Add(new Instruction(OpCode.Ldc_I4, 15));
        instructions.Add(new Instruction(OpCode.Ldc_I4, 16));
        instructions.Add(new Instruction(OpCode.Add));
        instructions.Add(new Instruction(OpCode.Ret));

        Core core = new Core(instructions);
        object result = core.Execute();
        
        if (result == null)
        {
            Console.WriteLine("No result.");
        }
        else
        {
            Console.WriteLine("Result: " + result.ToString() + ".");
        }

        Console.ReadLine();
    }
}   