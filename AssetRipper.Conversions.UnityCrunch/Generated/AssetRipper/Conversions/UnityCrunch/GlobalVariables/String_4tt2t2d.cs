using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_09GBHJNKCG@index?5?$DM?52?$AA@")]
[DemangledName("\"index < 2\"")]
[CleanName("String")]
internal static partial class String_4tt2t2d
{
	public unsafe static InlineArray_10_w3otm9c* __pointer;

	public unsafe static InlineArray_10_w3otm9c Value
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

	unsafe static String_4tt2t2d()
	{
		__pointer = unchecked((InlineArray_10_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_10_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_10_w3otm9c, byte>("index < 2\0"u8);
	}
}
