﻿// Copyright (c) MOSA Project. Licensed under the New BSD License.

using Mosa.Compiler.Framework.IR;

namespace Mosa.Compiler.Framework.Intrinsics
{
	/// <summary>
	/// IntrinsicMethods
	/// </summary>
	static partial class IntrinsicMethods
	{
		[IntrinsicMethod("Mosa.Runtime.Intrinsic:GetMethodExceptionLookupTable")]
		private static void GetMethodExceptionLookupTable(Context context, MethodCompiler methodCompiler)
		{
			var move = methodCompiler.Architecture.Is32BitPlatform ? (BaseInstruction)IRInstruction.MoveInt32 : IRInstruction.MoveInt64;

			context.SetInstruction(move, context.Result, Operand.CreateUnmanagedSymbolPointer(Metadata.MethodExceptionLookupTable, methodCompiler.TypeSystem));
		}
	}
}
