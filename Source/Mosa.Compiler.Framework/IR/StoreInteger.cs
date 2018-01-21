// Copyright (c) MOSA Project. Licensed under the New BSD License.

// This code was generated by an automated template.

namespace Mosa.Compiler.Framework.IR
{
	/// <summary>
	/// StoreInteger
	/// </summary>
	/// <seealso cref="Mosa.Compiler.Framework.IR.BaseIRInstruction" />
	public sealed class StoreInteger : BaseIRInstruction
	{
		public StoreInteger()
			: base(3, 0)
		{
		}

		public override bool IsMemoryWrite { get { return true; } }
	}
}

