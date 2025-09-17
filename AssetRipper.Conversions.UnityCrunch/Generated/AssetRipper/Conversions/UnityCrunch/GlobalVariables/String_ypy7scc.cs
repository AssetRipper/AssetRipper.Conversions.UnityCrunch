using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0BK@JAPIONGF@crnd_malloc?3?5size?5too?5big?$AA@")]
[DemangledName("\"crnd_malloc: size too big\"")]
[CleanName("String")]
internal static partial class String_ypy7scc
{
	public unsafe static InlineArray_26_w3otm9c* __pointer;

	public unsafe static InlineArray_26_w3otm9c Value
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
		__pointer = unchecked((InlineArray_26_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_26_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_26_w3otm9c, byte>("crnd_malloc: size too big\0"u8);
	}
}
