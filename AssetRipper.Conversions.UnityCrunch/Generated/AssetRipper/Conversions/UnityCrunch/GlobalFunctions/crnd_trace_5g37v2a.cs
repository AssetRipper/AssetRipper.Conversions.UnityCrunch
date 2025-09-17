using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_trace@crnd@@YAXPEBDPEAD@Z")]
[DemangledName("void __cdecl crnd::crnd_trace(char const *, char *)")]
[CleanName("crnd_trace")]
internal static partial class crnd_trace_5g37v2a
{
	public unsafe static void Invoke(void* pFmt, void* args)
	{
		void* ptr = null;
		void* ptr2 = null;
		InlineArray_512_w3otm9c inlineArray_512_w3otm9c = default(InlineArray_512_w3otm9c);
		ptr = args;
		ptr2 = pFmt;
		if (crnd_is_debugger_present.Invoke())
		{
			vsprintf.Invoke(&inlineArray_512_w3otm9c, ptr2, ptr);
			crnd_output_debug_string.Invoke(&inlineArray_512_w3otm9c);
		}
	}
}
