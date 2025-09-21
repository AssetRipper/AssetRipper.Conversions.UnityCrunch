using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?get_block_colors@dxt1_block@crnd@@SAIPEAV?$color_quad@EH@2@GG@Z")]
[DemangledName("public: static unsigned int __cdecl crnd::dxt1_block::get_block_colors(class crnd::color_quad<unsigned char, int> *, unsigned short, unsigned short)")]
internal static partial class Get_block_colors
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("class crnd::color_quad<unsigned char, int> *")] void* pDst, [NativeType("unsigned short")] short color0, [NativeType("unsigned short")] short color1)
	{
		short num = color1;
		short num2 = color0;
		if (unchecked((ushort)num2 > (ushort)num))
		{
			return Get_block_colors4.Invoke(pDst, num2, num);
		}
		return Get_block_colors3.Invoke(pDst, num2, num);
	}
}
