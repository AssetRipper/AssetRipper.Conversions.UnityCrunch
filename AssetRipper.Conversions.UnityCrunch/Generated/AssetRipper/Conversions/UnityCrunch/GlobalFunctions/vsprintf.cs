using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

internal static partial class vsprintf
{
	public unsafe static int Invoke([MangledName("_Buffer")] void* Buffer, [MangledName("_Format")] void* Format, [MangledName("_ArgList")] void* ArgList)
	{
		return vsnprintf_l.Invoke(Buffer, -1L, Format, null, ArgList);
	}
}
