using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?get_block_values@dxt5_block@crnd@@SAIPEAV?$color_quad@EH@2@II@Z")]
[DemangledName("public: static unsigned int __cdecl crnd::dxt5_block::get_block_values(class crnd::color_quad<unsigned char, int> *, unsigned int, unsigned int)")]
[CleanName("Get_block_values")]
internal static partial class Get_block_values_pxz3b9a
{
	public unsafe static int Invoke(void* pDst, int l, int h)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		void* ptr = null;
		num2 = h;
		num3 = l;
		ptr = pDst;
		if (unchecked((uint)num3 > (uint)num2))
		{
			return Get_block_values8_xv25ufa.Invoke(ptr, num3, num2);
		}
		return Get_block_values6_7gyjbyc.Invoke(ptr, num3, num2);
	}
}
