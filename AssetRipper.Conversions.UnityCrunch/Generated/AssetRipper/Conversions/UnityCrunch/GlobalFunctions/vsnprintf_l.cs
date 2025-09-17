using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Intrinsics.Unimplemented;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("_vsnprintf_l")]
[DemangledName("_vsnprintf_l")]
internal static partial class vsnprintf_l
{
	public unsafe static int Invoke(void* Buffer, long BufferCount, void* Format, void* Locale, void* ArgList)
	{
		int num = 0;
		num = stdio_common_vsprintf.Invoke(*unchecked((long*)local_stdio_printf_options.Invoke()) | 1L, Buffer, BufferCount, Format, Locale, ArgList);
		return (num >= 0) ? num : (-1);
	}
}
