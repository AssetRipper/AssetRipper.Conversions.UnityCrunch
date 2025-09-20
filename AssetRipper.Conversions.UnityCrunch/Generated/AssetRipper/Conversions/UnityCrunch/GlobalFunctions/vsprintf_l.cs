using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("_vsprintf_l")]
[DemangledName("_vsprintf_l")]
internal static partial class vsprintf_l
{
	public unsafe static int Invoke([MangledName("_Buffer")] void* Buffer, [MangledName("_Format")] void* Format, [MangledName("_Locale")] void* Locale, [MangledName("_ArgList")] void* ArgList)
	{
		return vsnprintf_l.Invoke(Buffer, -1L, Format, Locale, ArgList);
	}
}
