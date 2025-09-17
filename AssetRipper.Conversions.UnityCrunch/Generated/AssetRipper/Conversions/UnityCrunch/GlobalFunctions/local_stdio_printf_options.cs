using AssetRipper.Conversions.UnityCrunch.GlobalVariables;
using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalFunctions;

[MangledName("__local_stdio_printf_options")]
[DemangledName("__local_stdio_printf_options")]
internal static partial class local_stdio_printf_options
{
	public unsafe static void* Invoke()
	{
		return OptionsStorage.__pointer;
	}
}
