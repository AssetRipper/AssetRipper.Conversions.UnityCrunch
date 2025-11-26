using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?get_block_values@dxt5_block@crnd@@SAIPEAIII@Z")]
[DemangledName("public: static unsigned int __cdecl crnd::dxt5_block::get_block_values(unsigned int *, unsigned int, unsigned int)")]
[CleanName("Get_block_values")]
internal static partial class Get_block_values_u8zixf
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("unsigned int *")] void* pDst, [NativeType("unsigned int")] int l, [NativeType("unsigned int")] int h)
	{
		if (unchecked((uint)l > (uint)h))
		{
			return Get_block_values8_9fbjk8.Invoke(pDst, l, h);
		}
		return Get_block_values6_8iwdqp.Invoke(pDst, l, h);
	}
}
