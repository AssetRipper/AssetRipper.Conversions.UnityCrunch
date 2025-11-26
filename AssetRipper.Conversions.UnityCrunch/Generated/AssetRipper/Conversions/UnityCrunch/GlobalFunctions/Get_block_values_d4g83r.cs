using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?get_block_values@dxt5_block@crnd@@SAIPEAV?$color_quad@EH@2@II@Z")]
[DemangledName("public: static unsigned int __cdecl crnd::dxt5_block::get_block_values(class crnd::color_quad<unsigned char, int> *, unsigned int, unsigned int)")]
[CleanName("Get_block_values")]
internal static partial class Get_block_values_d4g83r
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("class crnd::color_quad<unsigned char, int> *")] void* pDst, [NativeType("unsigned int")] int l, [NativeType("unsigned int")] int h)
	{
		if (unchecked((uint)l > (uint)h))
		{
			return Get_block_values8_ekrbu2.Invoke(pDst, l, h);
		}
		return Get_block_values6_36ycpg.Invoke(pDst, l, h);
	}
}
