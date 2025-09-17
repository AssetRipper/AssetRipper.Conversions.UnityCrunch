using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("?clamp@?$color_quad@EH@crnd@@CAHH@Z")]
[DemangledName("private: static int __cdecl crnd::color_quad<unsigned char, int>::clamp(int)")]
internal static partial class clamp
{
	public static int Invoke(int v)
	{
		int num = 0;
		int num2 = 0;
		num2 = v;
		if (num2 < 0)
		{
			return 0;
		}
		if (num2 > 255)
		{
			return 255;
		}
		return num2;
	}
}
