using System;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_trace@crnd@@YAXPEBDZZ")]
[DemangledName("void __cdecl crnd::crnd_trace(char const *, ...)")]
[CleanName("crnd_trace")]
internal static partial class crnd_trace_7532hv
{
	public unsafe static void Invoke(void* pFmt, ReadOnlySpan<nint> args)
	{
		void* args2 = null;
		InstructionHelper.VAStart(&args2, args);
		crnd_trace_kv3t38.Invoke(pFmt, args2);
	}
}
