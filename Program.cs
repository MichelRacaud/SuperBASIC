using System;
using System.IO;

namespace SuperBASIC
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Library lib = new Library();
#if MEMORY
				lib.AddFunction(new Functions.MemoryLoad(), 1, "MEMLOAD");
				lib.AddFunction(new Functions.MemoryStore(), 2, "MEMSTORE");
#endif
				lib.AddFunction(new Functions.Print(), 1, "PRINT");
				lib.AddFunction(new Functions.Multiply(), 2, "MULTIPLY");
				lib.AddFunction(new Functions.Add(), 2, "ADD");
				lib.AddFunction(new Functions.Compare(), 2, "COMPARE");
				lib.AddFunction(new Functions.JumpZero(), 2, "JZ");
				lib.AddFunction(new Functions.Goto(), 1, "GOTO");
				lib.AddFunction(new Functions.Pi(), 0, "PI");
				lib.AddFunction(new Functions.Euler(), 0, "EULER");
				lib.AddFunction(new Functions.ArcSin(), 1, "ARCSIN");
				lib.AddFunction(new Functions.Sin(), 1, "SIN");
				lib.AddFunction(new Functions.SolveLinear(), 3, "SOLVE_LINEAR");
				lib.AddFunction(new Functions.Rem(), 2, "REM");
				Runtime r = new Runtime(lib);
				/*	Test.basic			
				 				if (args.Length <= 1)
								{
									r.OpenFile(Directory.GetCurrentDirectory() + "\\Test.basic");
								} 
								else
								{
									r.OpenFile(args[1]);
								}
								r.Run();
				*/
				/* ArcSin
				r.OpenFile("C:\\Michel\\SuperBasic\\Test_ArcSin.txt");
				r.Run();
				*/
				/* Sin
				r.OpenFile("C:\\Michel\\SuperBasic\\Test_Sin.txt");
				r.Run();
				*/
				/* SolveLinear
				r.OpenFile("C:\\Michel\\SuperBasic\\Test_SolveLinear.txt");
				r.Run();
				*/
				/* Rem */
				r.OpenFile("C:\\Michel\\SuperBasic\\Test_Rem.txt");
				r.Run();

			}
			catch (Parser.ParseException e)
			{
				Console.WriteLine($"Parsing failed:\n{e}");
			}
		}
	}
}
