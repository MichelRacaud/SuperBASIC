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
				lib.AddFunction(new Functions.Accumulate(), 2, "ACCUMULATE");
				lib.AddFunction(new Functions.CylinderVol(), 2, "CYLINDER_VOL");
				lib.AddFunction(new Functions.Vec3(), 3, "VEC3_ADD");
				lib.AddFunction(new Functions.SphereVol(), 1, "SPHERE_VOL");
				lib.AddFunction(new Functions.OrthogonalBBox(), 3, "ORTHOGONAL_BBOX");
				lib.AddFunction(new Functions.Partition(), 2, "PARTITION");
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
				/* Rem
				r.OpenFile("C:\\Michel\\SuperBasic\\Test_Rem.txt");
				r.Run();
				*/
				/* Accumulate
				r.OpenFile("C:\\Michel\\SuperBasic\\Test_Accumulate.txt");
				r.Run();
				*/
				/* CylinderVol
				r.OpenFile("C:\\Michel\\SuperBasic\\Test_CylinderVol.txt");
				r.Run();
				*/
				/* Vec3
				r.OpenFile("C:\\Michel\\SuperBasic\\Test_Vec3.txt");
				r.Run();
				*/
				/* SphereVol
				r.OpenFile("C:\\Michel\\SuperBasic\\Test_SphereVol.txt");
				r.Run();
				*/
				/* OrthogonalBBox
				r.OpenFile("C:\\Michel\\SuperBasic\\Test_OrthogonalBBox.txt");
				r.Run(); */
				/* Partition */
				r.OpenFile("C:\\Michel\\SuperBasic\\Test_Partition.txt");
				r.Run();
			}
			catch (Parser.ParseException e)
			{
				Console.WriteLine($"Parsing failed:\n{e}");
			}
		}
	}
}
