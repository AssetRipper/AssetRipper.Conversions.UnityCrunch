using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?get_block_values6@dxt5_block@crnd@@SAIPEAIII@Z")]
[DemangledName("public: static unsigned int __cdecl crnd::dxt5_block::get_block_values6(unsigned int *, unsigned int, unsigned int)")]
[CleanName("Get_block_values6")]
internal static partial class Get_block_values6_8iwdqp
{
	[return: NativeType("unsigned int")]
	public unsafe static int Invoke([NativeType("unsigned int *")] void* pDst, [NativeType("unsigned int")] int l, [NativeType("unsigned int")] int h)
	{
		unchecked
		{
			*(int*)pDst = l;
			((int*)pDst)[1] = h;
			((int*)pDst)[2] = (int)((uint)(l * 4 + h) / 5u);
			((int*)pDst)[3] = (int)((uint)(l * 3 + h * 2) / 5u);
			((int*)pDst)[4] = (int)((uint)(l * 2 + h * 3) / 5u);
			((int*)pDst)[5] = (int)((uint)(l + h * 4) / 5u);
			((int*)pDst)[6] = 0;
			((int*)pDst)[7] = 255;
			return 6;
		}
	}
}
