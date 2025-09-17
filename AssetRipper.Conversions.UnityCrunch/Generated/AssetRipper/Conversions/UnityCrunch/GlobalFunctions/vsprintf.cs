namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

internal static partial class vsprintf
{
	public unsafe static int Invoke(void* Buffer, void* Format, void* ArgList)
	{
		return vsnprintf_l.Invoke(Buffer, -1L, Format, null, ArgList);
	}
}
