using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.Intrinsics.Unimplemented;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("_vsnprintf_l")]
[DemangledName("_vsnprintf_l")]
internal static partial class vsnprintf_l
{
	public unsafe static int Invoke([MangledName("_Buffer")] void* Buffer, [MangledName("_BufferCount")] long BufferCount, [MangledName("_Format")] void* Format, [MangledName("_Locale")] void* Locale, [MangledName("_ArgList")] void* ArgList)
	{
		int num = stdio_common_vsprintf.Invoke(*unchecked((long*)local_stdio_printf_options.Invoke()) | 1L, Buffer, BufferCount, Format, Locale, ArgList);
		return (num >= 0) ? num : (-1);
	}
}
