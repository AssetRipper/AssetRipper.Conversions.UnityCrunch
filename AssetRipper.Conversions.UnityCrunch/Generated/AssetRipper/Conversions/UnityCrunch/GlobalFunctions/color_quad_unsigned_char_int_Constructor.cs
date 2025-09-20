using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??0?$color_quad@EH@crnd@@QEAA@HHHH@Z")]
[DemangledName("public: __cdecl crnd::color_quad<unsigned char, int>::color_quad<unsigned char, int>(int, int, int, int)")]
internal static partial class color_quad_unsigned_char_int_Constructor
{
	public unsafe static void* Invoke(void* @this, [NativeType("int")] int red, [NativeType("int")] int green, [NativeType("int")] int blue, [NativeType("int")] int alpha)
	{
		set.Invoke(@this, red, green, blue, alpha);
		return @this;
	}
}
