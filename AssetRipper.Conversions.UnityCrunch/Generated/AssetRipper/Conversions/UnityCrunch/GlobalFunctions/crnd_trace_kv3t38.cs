using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_trace@crnd@@YAXPEBDPEAD@Z")]
[DemangledName("void __cdecl crnd::crnd_trace(char const *, char *)")]
[CleanName("crnd_trace")]
internal static partial class crnd_trace_kv3t38
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("char const *")] void* pFmt, [NativeType("char *")] void* args)
	{
		InlineArray512_SByte inlineArray512_SByte = default(InlineArray512_SByte);
		if (crnd_is_debugger_present.Invoke())
		{
			vsprintf.Invoke(&inlineArray512_SByte, pFmt, args);
			crnd_output_debug_string.Invoke(&inlineArray512_SByte);
		}
	}
}
