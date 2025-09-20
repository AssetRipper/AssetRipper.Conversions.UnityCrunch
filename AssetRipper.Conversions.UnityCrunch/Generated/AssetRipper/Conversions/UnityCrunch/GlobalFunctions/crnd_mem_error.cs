using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?crnd_mem_error@crnd@@YAXPEBD@Z")]
[DemangledName("void __cdecl crnd::crnd_mem_error(char const *)")]
internal static partial class crnd_mem_error
{
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("char const *")] void* p_msg)
	{
		crnd_assert.Invoke(p_msg, String_yguirrd.__pointer, 1993);
	}
}
