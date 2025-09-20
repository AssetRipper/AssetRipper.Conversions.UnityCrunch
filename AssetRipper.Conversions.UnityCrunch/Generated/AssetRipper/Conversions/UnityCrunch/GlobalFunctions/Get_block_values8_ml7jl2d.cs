using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?get_block_values8@dxt5_block@crnd@@SAIPEAIII@Z")]
[DemangledName("public: static unsigned int __cdecl crnd::dxt5_block::get_block_values8(unsigned int *, unsigned int, unsigned int)")]
[CleanName("Get_block_values8")]
internal static partial class Get_block_values8_ml7jl2d
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("unsigned int *")] void* pDst, [NativeType("unsigned int")] int l, [NativeType("unsigned int")] int h)
	{
		unchecked
		{
			*(int*)pDst = l;
			((int*)pDst)[1] = h;
			((int*)pDst)[2] = (int)((uint)(l * 6 + h) / 7u);
			((int*)pDst)[3] = (int)((uint)(l * 5 + h * 2) / 7u);
			((int*)pDst)[4] = (int)((uint)(l * 4 + h * 3) / 7u);
			((int*)pDst)[5] = (int)((uint)(l * 3 + h * 4) / 7u);
			((int*)pDst)[6] = (int)((uint)(l * 2 + h * 5) / 7u);
			((int*)pDst)[7] = (int)((uint)(l + h * 6) / 7u);
			return 8;
		}
	}
}
