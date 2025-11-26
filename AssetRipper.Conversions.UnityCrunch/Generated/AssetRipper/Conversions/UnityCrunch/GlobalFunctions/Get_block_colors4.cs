using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Structures;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?get_block_colors4@dxt1_block@crnd@@SAIPEAV?$color_quad@EH@2@GG@Z")]
[DemangledName("public: static unsigned int __cdecl crnd::dxt1_block::get_block_colors4(class crnd::color_quad<unsigned char, int> *, unsigned short, unsigned short)")]
internal static partial class Get_block_colors4
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("class crnd::color_quad<unsigned char, int> *")] void* pDst, [NativeType("unsigned short")] short color0, [NativeType("unsigned short")] short color1)
	{
		crnd_color_quad crnd_color_quad2 = default(crnd_color_quad);
		crnd_color_quad crnd_color_quad3 = default(crnd_color_quad);
		unpack_color_gac4s5.Invoke(&crnd_color_quad2, color0, scaled: true, 255);
		unpack_color_gac4s5.Invoke(&crnd_color_quad3, color1, scaled: true, 255);
		color_quad_unsigned_char_int_Assignment.Invoke(pDst, &crnd_color_quad2);
		unchecked
		{
			color_quad_unsigned_char_int_Assignment.Invoke((byte*)pDst + sizeof(crnd_color_quad), &crnd_color_quad3);
			set.Invoke((byte*)pDst + (nint)2 * sizeof(crnd_color_quad), blue: checked(unchecked((byte)((anon_m9uqrv*)(&crnd_color_quad2.field))->field_2) * 2 + unchecked((byte)((anon_m9uqrv*)(&crnd_color_quad3.field))->field_2)) / 3, green: checked(unchecked((byte)((anon_m9uqrv*)(&crnd_color_quad2.field))->field_1) * 2 + unchecked((byte)((anon_m9uqrv*)(&crnd_color_quad3.field))->field_1)) / 3, red: checked(unchecked((byte)((anon_m9uqrv*)(&crnd_color_quad2.field))->field_0) * 2 + unchecked((byte)((anon_m9uqrv*)(&crnd_color_quad3.field))->field_0)) / 3, alpha: 255);
			set.Invoke((byte*)pDst + (nint)3 * sizeof(crnd_color_quad), blue: checked(unchecked((byte)((anon_m9uqrv*)(&crnd_color_quad3.field))->field_2) * 2 + unchecked((byte)((anon_m9uqrv*)(&crnd_color_quad2.field))->field_2)) / 3, green: checked(unchecked((byte)((anon_m9uqrv*)(&crnd_color_quad3.field))->field_1) * 2 + unchecked((byte)((anon_m9uqrv*)(&crnd_color_quad2.field))->field_1)) / 3, red: checked(unchecked((byte)((anon_m9uqrv*)(&crnd_color_quad3.field))->field_0) * 2 + unchecked((byte)((anon_m9uqrv*)(&crnd_color_quad2.field))->field_0)) / 3, alpha: 255);
			return 4;
		}
	}
}
