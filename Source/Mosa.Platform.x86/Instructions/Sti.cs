﻿// Copyright (c) MOSA Project. Licensed under the New BSD License.

using Mosa.Compiler.Framework;

namespace Mosa.Platform.x86.Instructions
{
	/// <summary>
	/// Representations the x86 sti instruction.
	/// </summary>
	public sealed class Sti : X86Instruction
	{
		#region Construction

		/// <summary>
		/// Initializes a new instance of <see cref="Sti"/>.
		/// </summary>
		public Sti() :
			base(0, 0)
		{
		}

		#endregion Construction

		#region Methods

		/// <summary>
		/// Emits the specified platform instruction.
		/// </summary>
		/// <param name="node">The node.</param>
		/// <param name="emitter">The emitter.</param>
		protected override void Emit(InstructionNode node, MachineCodeEmitter emitter)
		{
			emitter.WriteByte(0xFB);
		}

		#endregion Methods
	}
}
