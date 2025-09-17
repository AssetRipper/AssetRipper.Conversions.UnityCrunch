using AssetRipper.Conversions.UnityCrunch.Helpers;
using AssetRipper.Conversions.UnityCrunch.InlineArrays;

namespace AssetRipper.Conversions.UnityCrunch.GlobalVariables;

[MangledName("??_C@_0BA@BONAGPOI@num_bits?5?$DM?$DN?532U?$AA@")]
[DemangledName("\"num_bits <= 32U\"")]
[CleanName("String")]
internal static partial class String_bhrpdhd
{
	public unsafe static InlineArray_16_w3otm9c* __pointer;

	public unsafe static InlineArray_16_w3otm9c Value
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

	unsafe static String_bhrpdhd()
	{
		__pointer = unchecked((InlineArray_16_w3otm9c*)PointerIndices.Register(NativeMemoryHelper.Allocate(sizeof(InlineArray_16_w3otm9c))));
		Value = InlineArrayHelper.Create<InlineArray_16_w3otm9c, byte>("num_bits <= 32U\0"u8);
	}
}
