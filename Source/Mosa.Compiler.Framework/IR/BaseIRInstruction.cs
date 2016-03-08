﻿// Copyright (c) MOSA Project. Licensed under the New BSD License.

namespace Mosa.Compiler.Framework.IR
{
	/// <summary>
	/// Abstract base class for all instructions in the intermediate representation.
	/// </summary>
	public abstract class BaseIRInstruction : BaseInstruction
	{
		#region Construction

		/// <summary>
		/// Initializes a new instance of <see cref="BaseIRInstruction"/>.
		/// </summary>
		/// <param name="operandCount">Specifies the number of operands of the context.</param>
		/// <param name="resultCount">Specifies the number of results of the context.</param>
		protected BaseIRInstruction(byte operandCount, byte resultCount)
			: base(resultCount, operandCount)
		{
		}

		#endregion Construction

		#region Methods

		/// <summary>
		/// Returns a string representation of the context.
		/// </summary>
		/// <returns>
		/// A <see cref="System.String"/> that represents this instance.
		/// </returns>
		public override string ToString()
		{
			return "IR." + base.ToString();
		}

		#endregion Methods
	}
}
