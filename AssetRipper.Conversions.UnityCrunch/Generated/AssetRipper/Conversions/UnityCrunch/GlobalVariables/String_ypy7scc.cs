using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0BK@JAPIONGF@crnd_malloc?3?5size?5too?5big?$AA@")]
[DemangledName("\"crnd_malloc: size too big\"")]
[CleanName("String")]
internal static partial class String_ypy7scc
{
	public unsafe static InlineArray26_SByte* __pointer;

	public unsafe static InlineArray26_SByte Value
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

	unsafe static String_ypy7scc()
	{
		__pointer = unchecked((InlineArray26_SByte*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray26_SByte))));
		Value = InlineArrayHelper.Create<InlineArray26_SByte, byte>("crnd_malloc: size too big\0"u8);
	}
}
