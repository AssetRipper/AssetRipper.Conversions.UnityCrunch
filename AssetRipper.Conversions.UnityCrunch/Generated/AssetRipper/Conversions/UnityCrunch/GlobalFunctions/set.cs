using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?set@?$color_quad@EH@crnd@@QEAAAEAV12@HHHH@Z")]
[DemangledName("public: class crnd::color_quad<unsigned char, int> & __cdecl crnd::color_quad<unsigned char, int>::set(int, int, int, int)")]
internal static partial class set
{
	public unsafe static void* Invoke(void* @this, int red, int green, int blue, int alpha)
	{
		unchecked
		{
			sbyte field_ = (sbyte)clamp.Invoke(red);
			((anon_b9ijpuc*)(&((crnd_color_quad*)@this)->field_0))->field_0 = field_;
			sbyte field_2 = (sbyte)clamp.Invoke(green);
			((anon_b9ijpuc*)(&((crnd_color_quad*)@this)->field_0))->field_1 = field_2;
			sbyte field_3 = (sbyte)clamp.Invoke(blue);
			((anon_b9ijpuc*)(&((crnd_color_quad*)@this)->field_0))->field_2 = field_3;
			sbyte field_4 = (sbyte)clamp.Invoke(alpha);
			((anon_b9ijpuc*)(&((crnd_color_quad*)@this)->field_0))->field_3 = field_4;
			return @this;
		}
	}
}
