using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?get_block_colors@dxt1_block@crnd@@SAIPEAV?$color_quad@EH@2@GG@Z")]
[DemangledName("public: static unsigned int __cdecl crnd::dxt1_block::get_block_colors(class crnd::color_quad<unsigned char, int> *, unsigned short, unsigned short)")]
internal static partial class Get_block_colors
{
	public unsafe static int Invoke(void* pDst, short color0, short color1)
	{
		int num = 0;
		short num2 = 0;
		short num3 = 0;
		void* ptr = null;
		num2 = color1;
		num3 = color0;
		ptr = pDst;
		if (unchecked((ushort)num3 > (ushort)num2))
		{
			return Get_block_colors4.Invoke(ptr, num3, num2);
		}
		return Get_block_colors3.Invoke(ptr, num3, num2);
	}
}
