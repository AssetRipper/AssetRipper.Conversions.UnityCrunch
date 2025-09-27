using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?get_block_colors3@dxt1_block@crnd@@SAIPEAV?$color_quad@EH@2@GG@Z")]
[DemangledName("public: static unsigned int __cdecl crnd::dxt1_block::get_block_colors3(class crnd::color_quad<unsigned char, int> *, unsigned short, unsigned short)")]
internal static partial class Get_block_colors3
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("class crnd::color_quad<unsigned char, int> *")] void* pDst, [NativeType("unsigned short")] short color0, [NativeType("unsigned short")] short color1)
	{
		crnd_color_quad crnd_color_quad = default(crnd_color_quad);
		crnd_color_quad crnd_color_quad2 = default(crnd_color_quad);
		unpack_color_ifs9dpd.Invoke(&crnd_color_quad, color0, scaled: true, 255);
		unpack_color_ifs9dpd.Invoke(&crnd_color_quad2, color1, scaled: true, 255);
		color_quad_unsigned_char_int_Assignment.Invoke(pDst, &crnd_color_quad);
		color_quad_unsigned_char_int_Assignment.Invoke(unchecked((byte*)pDst) + sizeof(crnd_color_quad), &crnd_color_quad2);
		set.Invoke(unchecked((byte*)pDst + (nint)2 * sizeof(crnd_color_quad)), blue: unchecked((byte)((anon_b9ijpuc*)(&crnd_color_quad.field))->field_2) + unchecked((byte)((anon_b9ijpuc*)(&crnd_color_quad2.field))->field_2) >> 1, green: unchecked((byte)((anon_b9ijpuc*)(&crnd_color_quad.field))->field_1) + unchecked((byte)((anon_b9ijpuc*)(&crnd_color_quad2.field))->field_1) >> 1, red: unchecked((byte)((anon_b9ijpuc*)(&crnd_color_quad.field))->field_0) + unchecked((byte)((anon_b9ijpuc*)(&crnd_color_quad2.field))->field_0) >> 1, alpha: 255);
		set.Invoke(unchecked((byte*)pDst + (nint)3 * sizeof(crnd_color_quad)), 0, 0, 0, 0);
		return 3;
	}
}
