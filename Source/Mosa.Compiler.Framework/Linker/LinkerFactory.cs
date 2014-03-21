﻿/*
 * (c) 2012 MOSA - The Managed Operating System Alliance
 *
 * Licensed under the terms of the New BSD License.
 *
 * Authors:
 *  Phil Garcia (tgiphil) <phil@thinkedge.com>
 */

using Mosa.Compiler.Linker;
using Mosa.Compiler.Linker.Elf32;
using Mosa.Compiler.Linker.Elf64;
using Mosa.Compiler.Linker.PE;

namespace Mosa.Compiler.Framework.Linker
{
	/// <summary>
	///
	/// </summary>
	public static class LinkerFactory
	{
		public static ILinker Create(LinkerType linkerType, CompilerOptions compilerOptions, BaseArchitecture architecture)
		{
			ILinker linker = Create(linkerType);

			// setup all the common attributes
			linker.OutputFile = compilerOptions.OutputFile;
			linker.MachineID = architecture.ElfMachineType;
			linker.Endianness = architecture.Endianness;

			// TODO: add specific options based on type

			return linker;
		}

		private static ILinker Create(LinkerType linkerType)
		{
			switch (linkerType)
			{
				case LinkerType.PE: return new PELinker();
				case LinkerType.Elf32: return new Elf32Linker();
				case LinkerType.Elf64: return new Elf64Linker();
				default: throw new LinkerException("unknown linker type");
			}
		}

		/// <summary>
		/// Gets the type of the linker.
		/// </summary>
		/// <param name="format">The format.</param>
		/// <returns></returns>
		/// <exception cref="LinkerException">unknown linker type</exception>
		public static LinkerType GetLinkerType(string format)
		{
			switch (format.ToLower())
			{
				case "elf32": return LinkerType.Elf32;
				case "elf64": return LinkerType.Elf64;
				case "pe": return LinkerType.PE;
				default: throw new LinkerException("unknown linker type");
			}
		}
	}
}