using System;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_trace@crnd@@YAXPEBDZZ")]
[DemangledName("void __cdecl crnd::crnd_trace(char const *, ...)")]
[CleanName("crnd_trace")]
internal static partial class crnd_trace_53itvya
{
	public unsafe static void Invoke(void* pFmt, ReadOnlySpan<nint> args)
	{
		void* args2 = null;
		InstructionHelper.VAStart(&args2, args);
		crnd_trace_5g37v2a.Invoke(pFmt, args2);
	}
}
