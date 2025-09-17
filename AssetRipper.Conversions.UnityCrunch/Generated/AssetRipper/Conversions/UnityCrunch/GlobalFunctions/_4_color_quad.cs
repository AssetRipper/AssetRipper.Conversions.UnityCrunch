using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("??4?$color_quad@EH@crnd@@QEAAAEAV01@AEBV01@@Z")]
[DemangledName("public: class crnd::color_quad<unsigned char, int> & __cdecl crnd::color_quad<unsigned char, int>::operator=(class crnd::color_quad<unsigned char, int> const &)")]
internal static partial class _4_color_quad
{
	public unsafe static void* Invoke(void* @this, void* other)
	{
		unchecked
		{
			sbyte field_ = ((anon_b9ijpuc*)(&((crnd_color_quad*)other)->field_0))->field_0;
			((anon_b9ijpuc*)(&((crnd_color_quad*)@this)->field_0))->field_0 = field_;
			sbyte field_2 = ((anon_b9ijpuc*)(&((crnd_color_quad*)other)->field_0))->field_1;
			((anon_b9ijpuc*)(&((crnd_color_quad*)@this)->field_0))->field_1 = field_2;
			sbyte field_3 = ((anon_b9ijpuc*)(&((crnd_color_quad*)other)->field_0))->field_2;
			((anon_b9ijpuc*)(&((crnd_color_quad*)@this)->field_0))->field_2 = field_3;
			sbyte field_4 = ((anon_b9ijpuc*)(&((crnd_color_quad*)other)->field_0))->field_3;
			((anon_b9ijpuc*)(&((crnd_color_quad*)@this)->field_0))->field_3 = field_4;
			return @this;
		}
	}
}
