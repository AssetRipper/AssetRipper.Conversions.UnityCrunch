using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?get_block_values8@dxt5_block@crnd@@SAIPEAV?$color_quad@EH@2@II@Z")]
[DemangledName("public: static unsigned int __cdecl crnd::dxt5_block::get_block_values8(class crnd::color_quad<unsigned char, int> *, unsigned int, unsigned int)")]
[CleanName("Get_block_values8")]
internal static partial class Get_block_values8_xv25ufa
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("class crnd::color_quad<unsigned char, int> *")] void* pDst, [NativeType("unsigned int")] int l, [NativeType("unsigned int")] int h)
	{
		unchecked
		{
			((anon_b9ijpuc*)(&((crnd_color_quad*)pDst)->field_0))->field_3 = (sbyte)l;
			((anon_b9ijpuc*)(&((crnd_color_quad*)pDst)[1].field_0))->field_3 = (sbyte)h;
			sbyte field_ = (sbyte)((uint)(l * 6 + h) / 7u);
			((anon_b9ijpuc*)(&((crnd_color_quad*)pDst)[2L].field_0))->field_3 = field_;
			sbyte field_2 = (sbyte)((uint)(l * 5 + h * 2) / 7u);
			((anon_b9ijpuc*)(&((crnd_color_quad*)pDst)[3L].field_0))->field_3 = field_2;
			sbyte field_3 = (sbyte)((uint)(l * 4 + h * 3) / 7u);
			((anon_b9ijpuc*)(&((crnd_color_quad*)pDst)[4L].field_0))->field_3 = field_3;
			sbyte field_4 = (sbyte)((uint)(l * 3 + h * 4) / 7u);
			((anon_b9ijpuc*)(&((crnd_color_quad*)pDst)[5L].field_0))->field_3 = field_4;
			sbyte field_5 = (sbyte)((uint)(l * 2 + h * 5) / 7u);
			((anon_b9ijpuc*)(&((crnd_color_quad*)pDst)[6L].field_0))->field_3 = field_5;
			sbyte field_6 = (sbyte)((uint)(l + h * 6) / 7u);
			((anon_b9ijpuc*)(&((crnd_color_quad*)pDst)[7L].field_0))->field_3 = field_6;
			return 8;
		}
	}
}
