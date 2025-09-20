using System;
using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;
using AssetRipper.Conversions.UnityCrunch.Intrinsics.Implemented;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_assert@crnd@@YAXPEBD0I@Z")]
[DemangledName("void __cdecl crnd::crnd_assert(char const *, char const *, unsigned int)")]
internal static partial class crnd_assert
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("char const *")] void* pExp, [NativeType("char const *")] void* pFile, [NativeType("unsigned int")] int line)
	{
		InlineArray512_SByte inlineArray512_SByte = default(InlineArray512_SByte);
		sprintf.Invoke(&inlineArray512_SByte, String_tghxvvc.__pointer, default(ReadOnlySpan<nint>));
		crnd_output_debug_string.Invoke(&inlineArray512_SByte);
		puts.Invoke(&inlineArray512_SByte);
		if (crnd_is_debugger_present.Invoke())
		{
			crnd_debug_break.Invoke();
		}
	}
}
