using AssetRipper.Conversions.UnityCrunch.Helpers;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("?_OptionsStorage@?1??__local_stdio_printf_options@@9@4_KA")]
[DemangledName("unsigned __int64 `extern \"C\" __local_stdio_printf_options'::`2'::_OptionsStorage")]
internal static partial class OptionsStorage
{
	public unsafe static long* __pointer;

	public unsafe static long Value
	{
		get
		{
			return *__pointer;
		}
		set
		{
			*__pointer = value;
		}
	}

	unsafe static OptionsStorage()
	{
		__pointer = unchecked((long*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(long))));
		Value = 0L;
	}
}
