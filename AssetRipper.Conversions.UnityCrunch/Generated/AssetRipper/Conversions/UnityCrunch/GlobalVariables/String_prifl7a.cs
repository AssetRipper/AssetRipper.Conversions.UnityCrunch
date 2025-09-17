using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0N@MHDHCCDI@num_codes?$FLc?$FN?$AA@")]
[DemangledName("\"num_codes[c]\"")]
[CleanName("String")]
internal static partial class String_prifl7a
{
	public unsafe static InlineArray_13_w3otm9c* __pointer;

	public unsafe static InlineArray_13_w3otm9c Value
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

	unsafe static String_prifl7a()
	{
		__pointer = unchecked((InlineArray_13_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_13_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_13_w3otm9c, byte>("num_codes[c]\0"u8);
	}
}
