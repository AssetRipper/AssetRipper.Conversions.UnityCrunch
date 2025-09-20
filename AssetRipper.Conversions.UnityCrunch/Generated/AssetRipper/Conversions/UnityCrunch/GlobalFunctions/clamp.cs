using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?clamp@?$color_quad@EH@crnd@@CAHH@Z")]
[DemangledName("private: static int __cdecl crnd::color_quad<unsigned char, int>::clamp(int)")]
internal static partial class clamp
{
	[return: NativeType("int")]
	public static int Invoke([NativeType("int")] int v)
	{
		int num = 0;
		if (v < 0)
		{
			return 0;
		}
		if (v > 255)
		{
			return 255;
		}
		return v;
	}
}
